using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using PureCloud.Client.Models;
using PureCloud.Client.Repositories;

namespace PureCloud.Client.Extensions.Notifications;

public class NotificationHandler : INotificationHandler, IAsyncDisposable
{
    private readonly ConcurrentDictionary<string, Type> _typeMap = new(StringComparer.OrdinalIgnoreCase);
    private readonly System.Threading.Channels.Channel<string> _messageChannel = System.Threading.Channels.Channel.CreateUnbounded<string>();

    private readonly int _reconnectDelaySeconds = 5;
    private readonly int _maxReconnectAttempts = 10;

    private readonly IChannelRepository _channelRepository;
    private readonly ILogger<NotificationHandler> _logger;

    private ClientWebSocket _webSocket;
    private Channel _channel;
    private CancellationToken _cancellationToken;
    private int _reconnectAttempts;

    private Task _processingTask;

    public delegate void NotificationReceivedHandler(INotificationData notificationData);

    public event NotificationReceivedHandler NotificationReceived;

    public NotificationHandler(
        IChannelRepository channelRepository,
        ILogger<NotificationHandler> logger)
    {
        _channelRepository = channelRepository;
        _logger = logger;
    }

    public async Task StartAsync(Channel channel = null, CancellationToken cancellationToken = default)
    {
        _cancellationToken = cancellationToken;
        _webSocket?.Dispose();

        _channel = channel ?? await _channelRepository.CreateAsync(_cancellationToken);

        if (_channel is null)
        {
            throw new InvalidOperationException("Unable to create a communication channel. Perhaps the user is not authenticated.");
        }

        await _channelRepository.AddSubscriptionTopicsAsync(_channel.Id, _typeMap.Keys.Select(topic => new ChannelTopic { Id = topic }), true, cancellationToken);

        _processingTask = Task.Run(ProcessMessagesAsync, _cancellationToken);

        await ConnectAsync();
    }

    private async Task ConnectAsync()
    {
        _webSocket ??= new ClientWebSocket();

        while (!_cancellationToken.IsCancellationRequested &&
               _reconnectAttempts < _maxReconnectAttempts &&
               _webSocket is not null)
        {
            try
            {
                if (_webSocket.State == WebSocketState.Open)
                {
                    return;
                }

                if (_webSocket.State is WebSocketState.Closed or WebSocketState.Aborted)
                {
                    _webSocket.Dispose();
                    _webSocket = new ClientWebSocket();
                }

                await _webSocket.ConnectAsync(new Uri(_channel.ConnectUri), _cancellationToken);
                _reconnectAttempts = 0;

                _ = Task.Run(ReceiveLoopAsync, _cancellationToken);
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

    private async Task ReceiveLoopAsync()
    {
        _logger.LogInformation("ReceiveLoopAsync started");
        var buffer = new byte[4096];

        while (!_cancellationToken.IsCancellationRequested && _webSocket?.State == WebSocketState.Open)
        {
            try
            {
                var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), _cancellationToken);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    _logger.LogWarning("WebSocket closed by server.");
                    await ConnectAsync();
                    break;
                }

                var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                _logger.LogDebug("Received message: {Message}", message);
                await _messageChannel.Writer.WriteAsync(message, _cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while receiving from WebSocket.");
                await ConnectAsync();
                break;
            }
        }
    }

    private async Task ProcessMessagesAsync()
    {
        _logger.LogInformation("ProcessMessagesAsync started");

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

            var baseData = JsonSerializer.Deserialize<NotificationData>(message);
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
            var data = (INotificationData)JsonSerializer.Deserialize(message, typedNotificationType);

            if (data != null)
            {
                _logger.LogInformation("Raising NotificationReceived for topic {Topic}", baseData.TopicName);
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

        if (_channel is not null)
        {
            await _channelRepository.AddSubscriptionTopicsAsync(_channel.Id,
                filtered.Select(entry => new ChannelTopic { Id = entry.Key }));
        }

        foreach (var topic in filtered)
        {
            _typeMap.TryAdd(topic.Key, topic.Value);
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
        if (_webSocket?.State == WebSocketState.Open)
        {
            await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "disposing", _cancellationToken);
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

        _webSocket?.Dispose();
        _webSocket = null;
    }
}
