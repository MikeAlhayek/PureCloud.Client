namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// Metadata information about a message.
/// </summary>
public sealed class ConversationEventTopicMessageMetadata
{
    /// <summary>
    /// Message type.
    /// </summary>
    /// <value>Message type.</value>
    public string Type { get; set; }

    /// <summary>
    /// List of message events, if any
    /// </summary>
    /// <value>List of message events, if any</value>
    public IEnumerable<ConversationEventTopicMessageMetadataEvent> Events { get; set; }

    /// <summary>
    /// List of message content, if any
    /// </summary>
    /// <value>List of message content, if any</value>
    public IEnumerable<ConversationEventTopicMessageMetadataContent> Content { get; set; }
}
