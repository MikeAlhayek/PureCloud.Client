using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GuestMemberInfo
{
    /// <summary>
    /// The display name to use for the guest member in the conversation.
    /// </summary>
    /// <value>The display name to use for the guest member in the conversation.</value>
    public string DisplayName { get; set; }

    /// <summary>
    /// The first name to use for the guest member in the conversation.
    /// </summary>
    /// <value>The first name to use for the guest member in the conversation.</value>
    public string FirstName { get; set; }

    /// <summary>
    /// The last name to use for the guest member in the conversation.
    /// </summary>
    /// <value>The last name to use for the guest member in the conversation.</value>
    public string LastName { get; set; }

    /// <summary>
    /// The email address to use for the guest member in the conversation.
    /// </summary>
    /// <value>The email address to use for the guest member in the conversation.</value>
    public string Email { get; set; }

    /// <summary>
    /// The phone number to use for the guest member in the conversation.
    /// </summary>
    /// <value>The phone number to use for the guest member in the conversation.</value>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// The URL to the avatar image to use for the guest member in the conversation, if any.
    /// </summary>
    /// <value>The URL to the avatar image to use for the guest member in the conversation, if any.</value>
    public string AvatarImageUrl { get; set; }

    /// <summary>
    /// Any custom fields of information, in key-value format, to attach to the guest member in the conversation.
    /// </summary>
    /// <value>Any custom fields of information, in key-value format, to attach to the guest member in the conversation.</value>
    public Dictionary<string, string> CustomFields { get; set; }
}
