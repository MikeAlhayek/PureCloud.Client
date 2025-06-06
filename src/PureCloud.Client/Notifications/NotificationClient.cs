using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models.Channels;

namespace PureCloud.Client.Notifications;

public sealed class NotificationClient : IAsyncDisposable
{
    private readonly ConcurrentDictionary<string, Type> _typeMap = new(StringComparer.OrdinalIgnoreCase);

    private readonly IChannelsApi _channelRepository;
    private readonly NotificationClientResilienceOptions _resilienceOptions;
    private readonly PureCloudJsonSerializerOptions _options;
    private readonly ILogger _logger;
    private readonly object _webSocketLock = new();

    private ClientWebSocket _webSocket;
    private Channel _channel;
    private CancellationToken _cancellationToken;
    private System.Threading.Channels.Channel<string> _messageChannel;

    private int _reconnectAttempts;

    private Task _processingTask;

    public delegate void NotificationReceivedHandler(INotificationData notificationData);

    public IList<Func<INotificationData, Task>> NotificationHandlers = [];

    internal NotificationClient(
        IChannelsApi channelRepository,
        PureCloudJsonSerializerOptions options,
        NotificationClientResilienceOptions resilienceOptions,
        ILogger logger)
    {
        ArgumentNullException.ThrowIfNull(channelRepository);
        ArgumentNullException.ThrowIfNull(options);
        ArgumentNullException.ThrowIfNull(resilienceOptions);
        ArgumentNullException.ThrowIfNull(logger);

        _channelRepository = channelRepository;
        _options = options;
        _resilienceOptions = resilienceOptions;
        _logger = logger;
    }

    public NotificationClient(
        IChannelsApi channelRepository,
        IOptions<PureCloudJsonSerializerOptions> options,
        IOptions<NotificationClientResilienceOptions> resilienceOptions,
        ILogger<NotificationClient> logger)
    {
        _channelRepository = channelRepository;
        _resilienceOptions = resilienceOptions.Value;
        _options = options.Value;
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken = default)
    {
        _logger.LogDebug("StartAsync was called.");

        _cancellationToken = cancellationToken;
        _webSocket?.Dispose();

        _channel ??= await _channelRepository?.CreateAsync(_cancellationToken);

        if (_channel is null)
        {
            throw new InvalidOperationException("Unable to create a communication channel. Perhaps the user is not authenticated.");
        }

        if (_messageChannel?.Writer is not null)
        {
            _messageChannel.Writer.TryComplete();
        }

        _messageChannel = System.Threading.Channels.Channel.CreateUnbounded<string>();

        if (!_typeMap.IsEmpty)
        {
            _logger.LogDebug("There are initial events sending them to the server.");

            await _channelRepository.AddSubscriptionTopicsAsync(_channel.Id, _typeMap.Keys.Select(topic => new ChannelTopic { Id = topic }), true, cancellationToken);
        }

        _processingTask = Task.Run(ProcessMessagesAsync, _cancellationToken);

        await ConnectAsync();
    }

    private async Task ConnectAsync()
    {
        _logger.LogDebug("ConnectAsync was called.");

        lock (_webSocketLock)
        {
            if (_webSocket != null && _webSocket.State == WebSocketState.Open)
            {
                // Don't connect if already connected.
                _logger.LogDebug("WebSocket is already connected. No need to connect again.");
                return;
            }

            _webSocket?.Dispose();
            _webSocket = new ClientWebSocket();
        }

        while (!_cancellationToken.IsCancellationRequested &&
               _reconnectAttempts < _resilienceOptions.MaxReconnectAttempts &&
               _webSocket is not null)
        {
            try
            {
                _logger.LogDebug("Trying to connect to the WebSocket. The current state is {State}", _webSocket.State.ToString());

                if (_webSocket.State == WebSocketState.None)
                {
                    _logger.LogDebug("WebSocket is new and can be connected to.");

                    await _webSocket.ConnectAsync(new Uri(_channel.ConnectUri), _cancellationToken);
                    _reconnectAttempts = 0;

                    _logger.LogDebug("WebSocket is now connected.");
                }

                if (_webSocket.State == WebSocketState.Open)
                {
                    _logger.LogDebug("WebSocket state is open and can receive communication.");

                    _ = Task.Run(() => ReceiveEventsAsync(_webSocket), _cancellationToken);

                    break;
                }
                else
                {
                    _logger.LogDebug("WebSocket was not established. Trying to reconnect.");
                    _reconnectAttempts++;

                    if (_reconnectAttempts < _resilienceOptions.MaxReconnectAttempts)
                    {
                        await ConnectAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "WebSocket connection attempt {AttemptNumber} failed.", _reconnectAttempts);
                _reconnectAttempts++;

                if (_reconnectAttempts >= _resilienceOptions.MaxReconnectAttempts)
                {
                    _logger.LogError("Max reconnect attempts reached. Giving up.");
                    break;
                }

                await Task.Delay(TimeSpan.FromSeconds(_resilienceOptions.ReconnectDelaySeconds), _cancellationToken);
            }
        }
    }

    private async Task ReceiveEventsAsync(ClientWebSocket webSocket)
    {
        _logger.LogDebug("ReceiveEventsAsync was called on a WebSocket with a status {State}", webSocket.State.ToString());

        if (webSocket == null)
        {
            _logger.LogDebug("WebSocket is null!");

            return;
        }

        var buffer = new byte[4096];

        while (!_cancellationToken.IsCancellationRequested)
        {
            if (webSocket.State != WebSocketState.Open)
            {
                _logger.LogDebug("While Receiving events, the WebSocket with a status {State} and can no longer be used. No longer can listen to events.", webSocket.State.ToString());

                break;
            }

            try
            {
                WebSocketReceiveResult result;
                using var messageStream = new MemoryStream();

                do
                {
                    result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), _cancellationToken);
                    messageStream.Write(buffer, 0, result.Count);
                } while (!result.EndOfMessage);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    _logger.LogWarning("WebSocket closed: {Status} - {Description}", result.CloseStatus, result.CloseStatusDescription);

                    // Try to reconnect
                    await ConnectAsync();

                    break;
                }

                string message;

                if (messageStream.TryGetBuffer(out var messageBuffer))
                {
                    message = Encoding.UTF8.GetString(messageBuffer);
                }
                else
                {
                    message = Encoding.UTF8.GetString(messageStream.ToArray());
                }

                _logger.LogDebug("Received message: {Message}", message);

                await _messageChannel.Writer.WriteAsync(message, _cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while receiving from WebSocket.");

                // Try to reconnect
                await ConnectAsync();

                break;
            }
        }
    }

    private async Task ProcessMessagesAsync()
    {
        _logger.LogDebug("ProcessMessagesAsync started");

        await foreach (var message in _messageChannel.Reader.ReadAllAsync(_cancellationToken))
        {
            _logger.LogDebug("Processing message from channel");
            _ = Task.Run(() => HandleMessageAsync(message), _cancellationToken);
        }
    }

    private async Task HandleMessageAsync(string message)
    {
        try
        {
            _logger.LogDebug("Handling message: {Message}", message);

            var baseData = JsonSerializer.Deserialize<NotificationData>(message, _options.JsonSerializerOptions);

            if (string.IsNullOrWhiteSpace(baseData?.TopicName))
            {
                _logger.LogWarning("Message missing TopicName");

                return;
            }

            if (!_typeMap.TryGetValue(baseData.TopicName, out var targetType))
            {
                _logger.LogWarning("Unsubscribed event was received by the server TopicName: {TopicName}", baseData.TopicName);

                return;
            }

            _logger.LogDebug("Received notification for topic: {TopicName}", baseData.TopicName);

            var typedNotificationType = typeof(NotificationData<>).MakeGenericType(targetType);
            var notificationData = JsonSerializer.Deserialize(message, typedNotificationType, _options.JsonSerializerOptions) as INotificationData;

            if (notificationData is not null)
            {
                _logger.LogDebug("Raising NotificationReceived for topic {Topic}", baseData.TopicName);

                foreach (var handler in NotificationHandlers)
                {
                    await handler.Invoke(notificationData);
                }
            }
            else
            {
                _logger.LogWarning("Failed to deserialized data coming from the Genesys server.");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to process message.");
        }
    }

    public async Task AddSubscriptionsAsync(IEnumerable<KeyValuePair<string, Type>> subscriptions)
    {
        ArgumentNullException.ThrowIfNull(subscriptions);

        var filtered = subscriptions
            .Where(entry => !entry.Key.StartsWith("v2.system", StringComparison.OrdinalIgnoreCase));

        foreach (var topic in filtered)
        {
            _typeMap.TryAdd(topic.Key, topic.Value);
        }

        _logger.LogDebug("Subscribing to events. Current events are {Count}", _typeMap.Count);

        if (_channel is not null)
        {
            _logger.LogDebug("Channel already exists, sending the topics tp the server.");
            try
            {
                await _channelRepository.AddSubscriptionTopicsAsync(_channel.Id, filtered.Select(entry => new ChannelTopic { Id = entry.Key }), false, _cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to add event subscriptions.");
            }
        }
    }

    /// <summary>
    /// Add subscription using topic and deserialized type.
    /// </summary>
    /// <typeparam name="T">The topic handler type.</typeparam>
    /// <param name="topic"></param>
    /// <returns></returns>
    public Task<bool> AddSubscriptionAsync<T>(string topic)
    {
        ArgumentNullException.ThrowIfNull(topic);

        return AddSubscriptionAsync(topic, typeof(T));
    }

    /// <summary>
    /// Adds subscription using topic-template.
    /// </summary>
    /// <param name="topicTemplate">Topic templates can be found in PureCloudConstants.TopicTemplates. They are not topic.</param>
    /// <param name="ids"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public Task<bool> AddSubscriptionAsync(string topicTemplate, params object[] ids)
    {
        ArgumentNullException.ThrowIfNull(topicTemplate);

        if (!PureCloudConstants.TopicTemplates.TryGetValue(topicTemplate, out var topicType))
        {
            throw new InvalidOperationException($"The topic template '{topicTemplate}' is invalid. Valid templates can be found in {nameof(PureCloudConstants)}.{nameof(PureCloudConstants.TopicTemplates)}");
        }

        string topic;

        if (ids is not null && ids.Length > 0)
        {
            topic = string.Format(topicTemplate, ids);
        }
        else
        {
            topic = topicTemplate;
        }

        return AddSubscriptionAsync(topic, topicType);
    }

    public async Task RemoveSubscriptionAsync(string topic)
    {
        ArgumentNullException.ThrowIfNull(topic);

        var subscriptions = await _channelRepository.GetSubscriptionsAsync(_channel.Id);
        var entry = subscriptions.Entities.FirstOrDefault(e => e.Id.Equals(topic, StringComparison.OrdinalIgnoreCase));
        if (entry is null)
        {
            return;
        }

        subscriptions.Entities.Remove(entry);

        if (_channel is not null)
        {
            _logger.LogDebug("Channel already exists, removing the '{TopicId}' topic from the server.", topic);
            try
            {
                await _channelRepository.UpdateSubscriptionTopicsAsync(_channel.Id, subscriptions.Entities, false, _cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to remove subscriptions.");
            }
        }

        _typeMap.TryRemove(topic, out _);
    }

    public async Task RemoveAllSubscriptionsAsync()
    {
        if (_channel is not null)
        {
            _logger.LogDebug("Channel already exists, removing all topics from the server.");

            await _channelRepository.DeleteAsync(_channel.Id, _cancellationToken);
        }

        _typeMap.Clear();
    }

    public Task PingAsync()
    {
        if (_webSocket == null)
        {
            throw new InvalidOperationException($"You must first invoke {nameof(StartAsync)} before making requests.");
        }

        var jsonMessage =
            """
            {"message":"ping"}
            """;

        var messageBuffer = Encoding.UTF8.GetBytes(jsonMessage);
        var segment = new ArraySegment<byte>(messageBuffer);

        return _webSocket.SendAsync(segment, WebSocketMessageType.Text, true, _cancellationToken);
    }

    public async ValueTask DisposeAsync()
    {
        lock (_webSocketLock)
        {
            if (_webSocket?.State == WebSocketState.Open)
            {
                _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "disposing", _cancellationToken).Wait();
            }

            _webSocket?.Dispose();
            _webSocket = null;
        }

        _messageChannel.Writer.TryComplete();
        NotificationHandlers.Clear();
        if (_processingTask != null)
        {
            try
            {
                await _processingTask;
            }
            catch (OperationCanceledException) { }
        }
    }

    private async Task<bool> AddSubscriptionAsync(string topic, Type type)
    {
        ArgumentNullException.ThrowIfNull(topic);

        if (topic.Equals("channel.metadata", StringComparison.OrdinalIgnoreCase) || topic.StartsWith("v2.system", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        if (_typeMap.TryAdd(topic, type) && _channel is not null)
        {
            _logger.LogDebug("Channel already exists, sending the '{TopicId}' topic to the server.", topic);

            try
            {
                await _channelRepository.AddSubscriptionTopicsAsync(_channel.Id, [new ChannelTopic { Id = topic }], false, _cancellationToken);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to add subscription.");
            }
        }

        return false;
    }
}
