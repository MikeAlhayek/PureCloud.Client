namespace PureCloud.Client.Models;

public sealed class ConversationMessageMetadataEvent
{
    /// <summary>
    /// Type of this event element
    /// </summary>
    /// <value>Type of this event element</value>
    public ConversationMessageMetadataEventType? EventType { get; set; }

    /// <summary>
    /// Event subtype
    /// </summary>
    /// <value>Event subtype</value>
    public ConversationMessageMetadataEventSubType? SubType { get; set; }
}
