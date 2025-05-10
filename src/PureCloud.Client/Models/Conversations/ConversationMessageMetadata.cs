namespace PureCloud.Client.Models;

public sealed class ConversationMessageMetadata
{
    /// <summary>
    /// Message type.
    /// </summary>
    /// <value>Message type.</value>
    public ConversationMessageMetadataType? Type { get; set; }

    /// <summary>
    /// List of events metadata
    /// </summary>
    /// <value>List of events metadata</value>
    public IEnumerable<ConversationMessageMetadataEvent> Events { get; set; }

    /// <summary>
    /// List of message content
    /// </summary>
    /// <value>List of message content</value>
    public IEnumerable<ConversationMessageMetadataContent> Content { get; set; }
}
