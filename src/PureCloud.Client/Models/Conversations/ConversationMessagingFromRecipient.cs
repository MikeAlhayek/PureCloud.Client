using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationMessagingFromRecipient
{
    public ConversationMessagingFromRecipientIdTypeEnum? IdType { get; set; }

    public string Nickname { get; set; }

    public string Id { get; set; }

    public string Image { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string ExternalContactId { get; set; }

    public IEnumerable<ConversationRecipientAdditionalIdentifier> AdditionalIds { get; set; }
}
