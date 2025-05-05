using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using Microsoft.Extensions.Logging;
using PureCloud.Client.Models;
using PureCloud.Client.Repositories;

namespace PureCloud.Client.Extensions.Notifications;

/// <summary>
/// A helper class for handling PureCloudEnvironment notifications
/// </summary>
public class NotificationHandler : INotificationHandler
{
    private readonly ConcurrentDictionary<string, Type> _typeMap = new(StringComparer.OrdinalIgnoreCase);

    private readonly int _reconnectDelaySeconds = 5;
    private readonly int _maxReconnectAttempts = 10;

    private int _reconnectAttempts;

    private readonly IChannelRepository _channelRepository;
    private readonly ILogger _logger;

    /// <summary>
    /// The WebSocket object used to receive notifications
    /// </summary>
    private ClientWebSocket _webSocket;

    /// <summary>
    /// The notification channel object
    /// </summary>
    private Channel _channel;

    private CancellationToken _cancellationToken;

    /// <summary>
    /// The handler for a notification event
    /// </summary>
    /// <param name="notificationData">The notification data, of </param>
    public delegate void NotificationReceivedHandler(INotificationData notificationData);

    /// <summary>
    /// Raised when a notification occurs
    /// </summary>
    public event NotificationReceivedHandler NotificationReceived;

    /// <summary>
    /// Creates a new instance of NotificationHandler
    /// </summary>
    public NotificationHandler(
        IChannelRepository channelRepository,
        ILogger<NotificationHandler> logger)
    {
        _channelRepository = channelRepository;
        _logger = logger;
    }

    public async Task StartAsync(Channel channel = null, CancellationToken cancellationToken = default)
    {
        _webSocket?.Dispose();
        _cancellationToken = cancellationToken;

        _webSocket = new ClientWebSocket();

        _channel = channel ?? await _channelRepository.CreateAsync(_cancellationToken);

        await ConnectAsync();
    }

    private async Task ConnectAsync()
    {
        while (!_cancellationToken.IsCancellationRequested && _reconnectAttempts < _maxReconnectAttempts)
        {
            try
            {
                await _webSocket.ConnectAsync(new Uri(_channel.ConnectUri), _cancellationToken);

                _reconnectAttempts = 0; // Reset attempts on successful connection
                await ReceiveAsync();
            }
            catch (Exception)
            {
                _logger.LogDebug("Unable to connect to the WebSocket on attempt number '{AttemptNumber}'.", _reconnectAttempts);
                _reconnectAttempts++;

                if (_reconnectAttempts >= _maxReconnectAttempts)
                {
                    break;
                }

                await Task.Delay(TimeSpan.FromSeconds(_reconnectDelaySeconds), _cancellationToken);
            }
        }
    }

    private async Task ReceiveAsync()
    {
        var buffer = new byte[1024];

        while (!_cancellationToken.IsCancellationRequested)
        {
            try
            {
                var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), _cancellationToken);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await ConnectAsync();
                    break;
                }

                // Handle Events.

                var socketClosingTopic = "v2.system.socket_closing";

                _typeMap.TryAdd(socketClosingTopic, typeof(SystemMessage));
                _typeMap.TryAdd("channel.metadata", typeof(ChannelMetadataNotification));

                NotificationReceived += (data) =>
                {
                    if (data is NotificationData<SystemMessage> && string.Equals(data.TopicName, socketClosingTopic, StringComparison.Ordinal))
                    {
                        Task.Run(async () =>
                        {
                            await _webSocket.CloseAsync(WebSocketCloseStatus.Empty, "v2.system.socket_closing was raised", _cancellationToken);
                            await _webSocket.ConnectAsync(new Uri(_channel.ConnectUri), _cancellationToken);
                        });
                    }

                    if (_typeMap.ContainsKey(data.TopicName))
                    {
                        NotificationReceived?.Invoke(data);
                    }
                };
            }
            catch (Exception)
            {
                await ConnectAsync();
                break;
            }
        }
    }

    /// <summary>
    /// Sends the ping message to the notification service. Must be subscribed using topic "channel.metadata" and handle with type ChannelMetadataNotification.
    /// </summary>
    public Task PingAsync()
    {
        EnsureStarted();
        var jsonMessage = "{\"message\":\"ping\"}";
        var messageBuffer = Encoding.UTF8.GetBytes(jsonMessage);
        var segment = new ArraySegment<byte>(messageBuffer);

        return _webSocket.SendAsync(segment, WebSocketMessageType.Text, true, _cancellationToken);
    }

    /// <summary>
    /// Adds a list of subscriptions to the specified topic. Events received on this topic will be cast to the given type.
    /// </summary>
    /// <param name="subscriptions">A List of Tuples where the first value is the notification topic to add and the second is the Type that should be used when deserializing the notification</param>
    public async Task AddSubscriptionsAsync(Dictionary<string, Type> subscriptions)
    {
        ArgumentNullException.ThrowIfNull(subscriptions);

        var entries = subscriptions
            .Where(entry => !entry.Key.Equals("channel.metadata", StringComparison.InvariantCultureIgnoreCase) &&
            !entry.Key.StartsWith("v2.system", StringComparison.InvariantCultureIgnoreCase));


        await _channelRepository.AddSubscriptionTopicsAsync(_channel.Id, entries.Select(entry => new ChannelTopic() { Id = entry.Key }));

        lock (_typeMap)
        {
            foreach (var topic in entries)
            {
                _typeMap.TryAdd(topic.Key, topic.Value);
            }
        }
    }

    /// <summary>
    /// Removes the subscribed topic
    /// </summary>
    /// <param name="topic">The notification topic to remove</param>
    public async Task RemoveSubscriptionAsync(string topic)
    {
        var subscriptions = await _channelRepository.GetSubscriptionsAsync(_channel.Id);

        var entry = subscriptions.Entities.FirstOrDefault(e => e.Id.Equals(topic, StringComparison.InvariantCultureIgnoreCase));

        if (entry is null)
        {
            return;
        }

        subscriptions.Entities.Remove(entry);

        await _channelRepository.UpdateSubscriptionTopicsAsync(_channel.Id, subscriptions.Entities);

        _typeMap.TryRemove(topic, out _);
    }

    /// <summary>
    /// Removes all subscriptions from the channel
    /// </summary>
    public async Task RemoveAllSubscriptionsAsync()
    {
        await _channelRepository.DeleteAsync(_channel.Id);

        _typeMap.Clear();
    }

    private void EnsureStarted()
    {
        if (_webSocket == null)
        {
            throw new InvalidOperationException($"You must first invoke {nameof(StartAsync)} before making requests.");
        }
    }

    /// <summary>
    /// Removes all subscriptions and closes the websocket
    /// </summary>
    public ValueTask DisposeAsync()
    {
        return DisposeAsync(true);
    }

    private bool _disposed = false;

    private async ValueTask DisposeAsync(bool disposing)
    {
        if (_disposed || !disposing)
        {
            return;
        }

        try
        {
            _disposed = true;

            await RemoveAllSubscriptionsAsync();
            if (_webSocket != null && _webSocket.State == WebSocketState.Open)
            {
                await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "disposing", _cancellationToken);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            _webSocket = null;
        }
    }
}
