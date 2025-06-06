using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel
{
    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannelPlatformEnum? Platform { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets To
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingToRecipient To { get; set; }

    /// <summary>
    /// Gets or Sets From
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingFromRecipient From { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    public DateTime? Time { get; set; }
}
