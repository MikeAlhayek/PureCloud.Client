using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationRecipientAdditionalIdentifier
{
    public ConversationRecipientAdditionalIdentifierTypeEnum? Type { get; set; }

    public string Value { get; set; }
}
