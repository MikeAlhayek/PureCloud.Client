namespace PureCloud.Client.Models;

public sealed class ConversationEventTopicMessageMetadataContent
{
    /// <summary>
    /// Type of this content element.
    /// </summary>
    /// <value>Type of this content element.</value>
    public string ContentType { get; set; }

    /// <summary>
    /// Content subtype, if any
    /// </summary>
    /// <value>Content subtype, if any</value>
    public string SubType { get; set; }
}
