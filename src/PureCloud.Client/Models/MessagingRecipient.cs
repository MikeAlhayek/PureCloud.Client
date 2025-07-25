using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MessagingRecipient
{
    /// <summary>
    /// The recipient ID type. This is used to indicate the format used for the ID.
    /// </summary>
    /// <value>The recipient ID type. This is used to indicate the format used for the ID.</value>
    public MessagingRecipientIdTypeEnum? IdType { get; set; }

    /// <summary>
    /// Nickname or display name of the recipient.
    /// </summary>
    /// <value>Nickname or display name of the recipient.</value>
    public string Nickname { get; set; }

    /// <summary>
    /// The recipient ID specific to the provider.
    /// </summary>
    /// <value>The recipient ID specific to the provider.</value>
    public string Id { get; set; }

    /// <summary>
    /// URL of an image that represents the recipient.
    /// </summary>
    /// <value>URL of an image that represents the recipient.</value>
    public string Image { get; set; }

    /// <summary>
    /// First name of the recipient.
    /// </summary>
    /// <value>First name of the recipient.</value>
    public string FirstName { get; set; }

    /// <summary>
    /// Last name of the recipient.
    /// </summary>
    /// <value>Last name of the recipient.</value>
    public string LastName { get; set; }

    /// <summary>
    /// E-mail address of the recipient.
    /// </summary>
    /// <value>E-mail address of the recipient.</value>
    public string Email { get; set; }

    /// <summary>
    /// The identifier of the external contact.
    /// </summary>
    /// <value>The identifier of the external contact.</value>
    public string ExternalContactId { get; set; }

    /// <summary>
    /// List of recipient additional identifiers
    /// </summary>
    /// <value>List of recipient additional identifiers</value>
    public IEnumerable<RecipientAdditionalIdentifier> AdditionalIds { get; set; }
}
