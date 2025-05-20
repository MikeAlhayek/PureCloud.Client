using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForUserTopicConversationRecipientAdditionalIdentifier
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2ConversationMessageTypingEventForUserTopicConversationRecipientAdditionalIdentifierTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }
}
