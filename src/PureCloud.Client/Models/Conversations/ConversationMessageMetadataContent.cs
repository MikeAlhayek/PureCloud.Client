namespace PureCloud.Client.Models;

public sealed class ConversationMessageMetadataContent
{
    /// <summary>
    /// Type of this content element.
    /// </summary>
    /// <value>Type of this content element.</value>
    public ConversationMessageMetadataContentType? ContentType { get; set; }

    /// <summary>
    /// Content subtype
    /// </summary>
    /// <value>Content subtype</value>
    public ConversationMessageMetadataContentSubType? SubType { get; set; }
}
