using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForWorkflowTopicConversationNormalizedMessage
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationNormalizedMessageTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationNormalizedMessageDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Gets or Sets Channel
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel Channel { get; set; }

    /// <summary>
    /// Gets or Sets Events
    /// </summary>
    public IEnumerable<V2ConversationMessageTypingEventForWorkflowTopicConversationMessageEvent> Events { get; set; }
}
