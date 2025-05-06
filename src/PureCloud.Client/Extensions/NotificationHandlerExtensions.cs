namespace PureCloud.Client.Extensions.Notifications;

public static class NotificationHandlerExtensions
{
    public static Task AddSubscriptionsAsync(this INotificationHandler handler, Action<SubscriptionBuilder> action)
    {
        var builder = new SubscriptionBuilder();

        action(builder);

        return handler.AddSubscriptionsAsync(builder.Build());
    }
}
