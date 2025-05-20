using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForWorkflowTopicMessageData
{
    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets NormalizedMessage
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationNormalizedMessage NormalizedMessage { get; set; }
}
