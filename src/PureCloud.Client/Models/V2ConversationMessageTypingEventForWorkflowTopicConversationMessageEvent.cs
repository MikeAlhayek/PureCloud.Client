using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForWorkflowTopicConversationMessageEvent
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationMessageEventEventTypeEnum? EventType { get; set; }

    /// <summary>
    /// Gets or Sets Typing
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping Typing { get; set; }
}
