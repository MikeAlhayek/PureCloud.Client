using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationMessageEventTopicMessageMetadata
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
    public IEnumerable<QueueConversationMessageEventTopicMessageMetadataEvent> Events { get; set; }

    /// <summary>
    /// List of message content, if any
    /// </summary>
    /// <value>List of message content, if any</value>
    public IEnumerable<QueueConversationMessageEventTopicMessageMetadataContent> Content { get; set; }
}
