using PureCloud.Client.Notifications;

namespace PureCloud.Client.Contracts;

public interface INotificationClientFactory
{
    NotificationClient Create();
}
