using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForUserTopicConversationEventTyping
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2ConversationMessageTypingEventForUserTopicConversationEventTypingTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    public long? Duration { get; set; }
}
