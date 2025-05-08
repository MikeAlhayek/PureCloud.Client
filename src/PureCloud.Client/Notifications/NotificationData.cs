namespace PureCloud.Client.Notifications;

///<Summary>
/// Notification (i.e. topic) Data received on the Notification Channel (WebSocket)
///</Summary>
public sealed class NotificationData<T> : NotificationData, INotificationData
{
    ///<Summary>
    /// Body of the event
    ///</Summary>
    public T EventBody { get; set; }
}

public class NotificationData : INotificationData
{
    ///<Summary>
    /// Name of the topic
    ///</Summary>
    public string TopicName { get; set; }

    ///<Summary>
    /// Version
    ///</Summary>
    public string Version { get; set; }

    ///<Summary>
    /// Metadata
    ///</Summary>
    public Metadata Metadata { get; set; }
}
