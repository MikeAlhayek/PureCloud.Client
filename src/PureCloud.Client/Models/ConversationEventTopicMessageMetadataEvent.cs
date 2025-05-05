namespace PureCloud.Client.Models;

public sealed class ConversationEventTopicMessageMetadataEvent
{
    /// <summary>
    /// Type of this event element.
    /// </summary>
    /// <value>Type of this event element.</value>
    public string EventType { get; set; }

    /// <summary>
    /// Event subtype, if any
    /// </summary>
    /// <value>Event subtype, if any</value>
    public string SubType { get; set; }
}
