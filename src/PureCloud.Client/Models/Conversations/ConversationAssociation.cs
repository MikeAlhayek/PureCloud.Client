using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationAssociation
{
    /// <summary>
    /// Media type
    /// </summary>
    /// <value>Media type</value>
    public ConversationAssociationMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// An external contact ID.  If not supplied, implies the conversation should be disassociated with any external contact.
    /// </summary>
    /// <value>An external contact ID.  If not supplied, implies the conversation should be disassociated with any external contact.</value>
    public string ExternalContactId { get; set; }

    /// <summary>
    /// Conversation ID
    /// </summary>
    /// <value>Conversation ID</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// Communication ID
    /// </summary>
    /// <value>Communication ID</value>
    public string CommunicationId { get; set; }
}
