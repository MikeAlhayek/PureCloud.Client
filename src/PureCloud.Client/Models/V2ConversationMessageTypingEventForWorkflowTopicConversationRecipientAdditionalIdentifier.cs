using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForWorkflowTopicConversationRecipientAdditionalIdentifier
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationRecipientAdditionalIdentifierTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }
}
