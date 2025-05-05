
using PureCloud.Client.Models;

namespace PureCloud.Client.Extensions.Notifications;

/// <summary>
/// A helper class for handling PureCloudEnvironment notifications
/// </summary>
public interface INotificationHandler : IAsyncDisposable
{
    /// <summary>
    /// Raised when a notification occurs
    /// </summary>
    event NotificationHandler.NotificationReceivedHandler NotificationReceived;

    /// <summary>
    /// Adds a list of subscription to the specified topic. Events received on this topic will be cast to the given type.
    /// </summary>
    /// <param name="subscriptions">A List of Tuples where the first value is the notification topic to add and the second is the Type that should be used when deserializing the notification</param>
    Task AddSubscriptionsAsync(Dictionary<string, Type> subscriptions);

    /// <summary>
    /// Removes the subscribed topic
    /// </summary>
    /// <param name="topic">The notification topic to remove</param>
    Task RemoveSubscriptionAsync(string topic);

    /// <summary>
    /// Removes all subscriptions from the channel
    /// </summary>
    Task RemoveAllSubscriptionsAsync();

    /// <summary>
    /// Sends the ping message to the notification service. Must be subscribed using topic "channel.metadata" and handle with type ChannelMetadataNotification.
    /// </summary>
    Task PingAsync();

    /// <summary>
    /// Starts the connection to the service.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task StartAsync(Channel channel = null, CancellationToken cancellationToken = default);
}
