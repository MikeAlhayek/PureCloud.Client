namespace PureCloud.Client.Notifications;

public sealed class NotificationClientResilienceOptions
{
    public int ReconnectDelaySeconds { get; set; } = 5;

    public int MaxReconnectAttempts { get; set; } = 10;

    public int ReconnectDelayMilliseconds { get; set; } = 500;
}
