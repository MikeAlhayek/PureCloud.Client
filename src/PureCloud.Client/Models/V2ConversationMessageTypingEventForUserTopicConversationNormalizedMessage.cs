using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessageTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessageDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Gets or Sets Channel
    /// </summary>
    public V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel Channel { get; set; }

    /// <summary>
    /// Gets or Sets Events
    /// </summary>
    public IEnumerable<V2ConversationMessageTypingEventForUserTopicConversationMessageEvent> Events { get; set; }
}
