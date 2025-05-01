using System.Net.WebSockets;
using System.Text;
using PureCloud.Client.Apis;
using PureCloud.Client.Models;

namespace PureCloud.Client.Extensions.Notifications;

/// <summary>
/// A helper class for handling PureCloudEnvironment notifications
/// </summary>
public class NotificationHandler : INotificationHandler
{
    private readonly NotificationsApi _notificationsApi = new();

    private readonly Dictionary<string, Type> _typeMap = new(StringComparer.OrdinalIgnoreCase);

    private readonly int _reconnectDelaySeconds = 5;
    private readonly int _maxReconnectAttempts = 10;

    private int _reconnectAttempts;

    /// <summary>
    /// The WebSocket object used to receive notifications
    /// </summary>
    private ClientWebSocket _webSocket;

    /// <summary>
    /// The notification channel object
    /// </summary>
    private Channel _channel;

    private readonly CancellationToken _cancellationToken;

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
    public NotificationHandler(CancellationToken cancellationToken = default)
    {
        _cancellationToken = cancellationToken;
    }

    public Task StartAsync()
    {
        _webSocket?.Dispose();

        _webSocket = new ClientWebSocket();

        _channel = _notificationsApi.PostNotificationsChannels();

        return ConnectAsync();
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

                // handle events

                var socketClosingTopic = "v2.system.socket_closing";
                AddHandlerNoSubscribe(socketClosingTopic, typeof(SystemMessageSystemMessage));
                AddHandlerNoSubscribe("channel.metadata", typeof(ChannelMetadataNotification));
                NotificationReceived += (data) =>
                {
                    if (data is NotificationData<SystemMessageSystemMessage> &&
                        string.Compare(data.TopicName, socketClosingTopic) == 0)
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
    /// Adds a subscription to the specified topic. Events received on this topic will be cast to the given type.
    /// </summary>
    /// <param name="topic">The notification topic to add</param>
    /// <param name="type">The <see cref="Type"/> to cast notifications on this topic to</param>
    public void AddSubscription(string topic, Type type)
    {
        AddSubscriptions([new Tuple<string, Type>(topic, type)]);
    }

    /// <summary>
    /// Adds a list of subscriptions to the specified topic. Events received on this topic will be cast to the given type.
    /// </summary>
    /// <param name="subscriptions">A List of Tuples where the first value is the notification topic to add and the second is the Type that should be used when deserializing the notification</param>
    public void AddSubscriptions(List<Tuple<string, Type>> subscriptions)
    {
        var topicList = subscriptions.Select(s => new ChannelTopic(s.Item1))
            .Where(t => (!t.Id.Equals("channel.metadata", StringComparison.InvariantCultureIgnoreCase)) &&
            (!t.Id.StartsWith("v2.system", StringComparison.InvariantCultureIgnoreCase)))
            .ToList();

        _notificationsApi.PostNotificationsChannelSubscriptions(_channel.Id, topicList);

        subscriptions.ForEach(s => _typeMap.Add(s.Item1, s.Item2));
    }

    /// <summary>
    /// Adds a handler to the specified topic without subscribing. Events received on this topic will be cast to the given type.
    /// </summary>
    /// <param name="topic">The notification topic to add</param>
    /// <param name="type">The <see cref="Type"/> to cast notifications on this topic to</param>
    public void AddHandlerNoSubscribe(string topic, Type type)
    {
        AddHandlersNoSubscribe([new Tuple<string, Type>(topic, type)]);
    }

    /// <summary>
    /// Adds a list of handlers to the specified topic without subscribing. Events received on this topic will be cast to the given type.
    /// </summary>
    /// <param name="subscriptions">A List of Tuples where the first value is the notification topic to add and the second is the Type that should be used when deserializing the notification</param>
    public void AddHandlersNoSubscribe(List<Tuple<string, Type>> subscriptions)
    {
        subscriptions.ForEach(s => _typeMap.Add(s.Item1.ToLowerInvariant(), s.Item2));
    }

    /// <summary>
    /// Removes the subscribed topic
    /// </summary>
    /// <param name="topic">The notification topic to remove</param>
    public void RemoveSubscription(string topic)
    {
        var subscriptions = _notificationsApi.GetNotificationsChannelSubscriptions(_channel.Id);
        var match =
            subscriptions.Entities.FirstOrDefault(
                e => e.Id.Equals(topic, StringComparison.InvariantCultureIgnoreCase));
        if (match == null)
        {
            return;
        }

        subscriptions.Entities.Remove(match);
        _notificationsApi.PutNotificationsChannelSubscriptions(_channel.Id, subscriptions.Entities);
        _typeMap.Remove(topic.ToLowerInvariant());
    }

    /// <summary>
    /// Removes all subscriptions from the channel
    /// </summary>
    public void RemoveAllSubscriptions()
    {
        _notificationsApi.DeleteNotificationsChannelSubscriptions(_channel.Id);
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

            RemoveAllSubscriptions();
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
