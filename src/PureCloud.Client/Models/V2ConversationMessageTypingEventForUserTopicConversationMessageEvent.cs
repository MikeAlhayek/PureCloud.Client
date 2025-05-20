using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForUserTopicConversationMessageEvent
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public V2ConversationMessageTypingEventForUserTopicConversationMessageEventEventTypeEnum? EventType { get; set; }

    /// <summary>
    /// Gets or Sets Typing
    /// </summary>
    public V2ConversationMessageTypingEventForUserTopicConversationEventTyping Typing { get; set; }
}
