using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Repositories;

namespace PureCloud.Client.Extensions.Notifications;

public class NotificationClient : IAsyncDisposable
{
    private readonly ConcurrentDictionary<string, Type> _typeMap = new(StringComparer.OrdinalIgnoreCase);
    private readonly System.Threading.Channels.Channel<string> _messageChannel = System.Threading.Channels.Channel.CreateUnbounded<string>();

    private readonly int _reconnectDelaySeconds = 5;
    private readonly int _maxReconnectAttempts = 10;

    private readonly IChannelRepository _channelRepository;
    private readonly PureCloudJsonSerializerOptions _options;
    private readonly ILogger _logger;

    private readonly object _webSocketLock = new();
    private ClientWebSocket _webSocket;
    private Channel _channel;
    private CancellationToken _cancellationToken;
    private int _reconnectAttempts;

    private Task _processingTask;

    public delegate void NotificationReceivedHandler(INotificationData notificationData);

    public event NotificationReceivedHandler NotificationReceived;

    internal NotificationClient(IChannelRepository channelRepository, PureCloudJsonSerializerOptions options, ILogger logger)
    {
        ArgumentNullException.ThrowIfNull(channelRepository);
        ArgumentNullException.ThrowIfNull(options);
        ArgumentNullException.ThrowIfNull(logger);

        _channelRepository = channelRepository;
        _options = options;
        _logger = logger;
    }

    public NotificationClient(
        IChannelRepository channelRepository,
        IOptions<PureCloudJsonSerializerOptions> options,
        ILogger<NotificationClient> logger)
    {
        _channelRepository = channelRepository;
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

        if (_typeMap.Count > 0)
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
               _reconnectAttempts < _maxReconnectAttempts &&
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

                    if (_reconnectAttempts < _maxReconnectAttempts)
                    {
                        await ConnectAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "WebSocket connection attempt {AttemptNumber} failed.", _reconnectAttempts);
                _reconnectAttempts++;

                if (_reconnectAttempts >= _maxReconnectAttempts)
                {
                    _logger.LogError("Max reconnect attempts reached. Giving up.");
                    break;
                }

                await Task.Delay(TimeSpan.FromSeconds(_reconnectDelaySeconds), _cancellationToken);
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
                using var messageBuffer = new MemoryStream();

                do
                {
                    result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), _cancellationToken);
                    messageBuffer.Write(buffer, 0, result.Count);
                } while (!result.EndOfMessage);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    _logger.LogWarning("WebSocket closed: {Status} - {Description}", result.CloseStatus, result.CloseStatusDescription);
                    await ConnectAsync(); // try to reconnect
                    break;
                }

                var message = Encoding.UTF8.GetString(messageBuffer.ToArray());
                _logger.LogDebug("Received message: {Message}", message);
                await _messageChannel.Writer.WriteAsync(message, _cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while receiving from WebSocket.");
                await ConnectAsync(); // reconnect on error
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

    private Task HandleMessageAsync(string message)
    {
        try
        {
            _logger.LogDebug("Handling message: {Message}", message);

            var baseData = JsonSerializer.Deserialize<NotificationData>(message, _options.JsonSerializerOptions);

            if (string.IsNullOrWhiteSpace(baseData?.TopicName))
            {
                _logger.LogWarning("Message missing TopicName");
                return Task.CompletedTask;
            }

            if (!_typeMap.TryGetValue(baseData.TopicName, out var targetType))
            {
                _logger.LogWarning("Unknown TopicName: {TopicName}", baseData.TopicName);

                return Task.CompletedTask;
            }

            var typedNotificationType = typeof(NotificationData<>).MakeGenericType(targetType);
            var data = (INotificationData)JsonSerializer.Deserialize(message, typedNotificationType, _options.JsonSerializerOptions);

            if (data != null)
            {
                _logger.LogDebug("Raising NotificationReceived for topic {Topic}", baseData.TopicName);
                NotificationReceived?.Invoke(data);
            }
            else
            {
                _logger.LogWarning("Deserialized data is null");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to process message.");
        }

        return Task.CompletedTask;
    }

    public async Task AddSubscriptionsAsync(IEnumerable<KeyValuePair<string, Type>> subscriptions)
    {
        ArgumentNullException.ThrowIfNull(subscriptions);

        var filtered = subscriptions
            .Where(entry => !entry.Key.Equals("channel.metadata", StringComparison.OrdinalIgnoreCase) &&
                            !entry.Key.StartsWith("v2.system", StringComparison.OrdinalIgnoreCase));

        foreach (var topic in filtered)
        {
            _typeMap.TryAdd(topic.Key, topic.Value);
        }

        _logger.LogDebug("Subscribing to events. Current events are {Count}", _typeMap.Count);

        if (_channel is not null)
        {
            _logger.LogDebug("Channel already exists, sending the topics tp the server.");

            await _channelRepository.AddSubscriptionTopicsAsync(_channel.Id, filtered.Select(entry => new ChannelTopic { Id = entry.Key }));
        }
    }

    public async Task RemoveSubscriptionAsync(string topic)
    {
        var subscriptions = await _channelRepository.GetSubscriptionsAsync(_channel.Id);
        var entry = subscriptions.Entities.FirstOrDefault(e => e.Id.Equals(topic, StringComparison.OrdinalIgnoreCase));
        if (entry is null)
        {
            return;
        }

        subscriptions.Entities.Remove(entry);

        if (_channel is not null)
        {
            await _channelRepository.UpdateSubscriptionTopicsAsync(_channel.Id, subscriptions.Entities);
        }

        _typeMap.TryRemove(topic, out _);
    }

    public async Task RemoveAllSubscriptionsAsync()
    {
        await _channelRepository.DeleteAsync(_channel.Id);

        _typeMap.Clear();
    }

    public Task PingAsync()
    {
        EnsureStarted();

        var jsonMessage =
            """
            {"message":"ping"}
            """;

        var messageBuffer = Encoding.UTF8.GetBytes(jsonMessage);
        var segment = new ArraySegment<byte>(messageBuffer);

        return _webSocket.SendAsync(segment, WebSocketMessageType.Text, true, _cancellationToken);
    }

    private void EnsureStarted()
    {
        if (_webSocket == null)
        {
            throw new InvalidOperationException($"You must first invoke {nameof(StartAsync)} before making requests.");
        }
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

        if (_processingTask != null)
        {
            try
            {
                await _processingTask;
            }
            catch (OperationCanceledException) { }
        }
    }
}
