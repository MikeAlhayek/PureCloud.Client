using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebChatMemberInfo
{
    /// <summary>
    /// The role of the member, one of [agent, customer, acd, workflow]
    /// </summary>
    /// <value>The role of the member, one of [agent, customer, acd, workflow]</value>
    public WebChatMemberInfoRoleEnum? Role { get; set; }

    /// <summary>
    /// The connection state of this member.
    /// </summary>
    /// <value>The connection state of this member.</value>
    public WebChatMemberInfoStateEnum? State { get; set; }

    /// <summary>
    /// The communicationId of this member.
    /// </summary>
    /// <value>The communicationId of this member.</value>
    public string Id { get; set; }

    /// <summary>
    /// The display name of the member.
    /// </summary>
    /// <value>The display name of the member.</value>
    public string DisplayName { get; set; }

    /// <summary>
    /// The first name of the member.
    /// </summary>
    /// <value>The first name of the member.</value>
    public string FirstName { get; set; }

    /// <summary>
    /// The last name of the member.
    /// </summary>
    /// <value>The last name of the member.</value>
    public string LastName { get; set; }

    /// <summary>
    /// The email address of the member.
    /// </summary>
    /// <value>The email address of the member.</value>
    public string Email { get; set; }

    /// <summary>
    /// The phone number of the member.
    /// </summary>
    /// <value>The phone number of the member.</value>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// The url to the avatar image of the member.
    /// </summary>
    /// <value>The url to the avatar image of the member.</value>
    public string AvatarImageUrl { get; set; }

    /// <summary>
    /// The time the member joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the member joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? JoinDate { get; set; }

    /// <summary>
    /// The time the member left the conversation, or null if the member is still active in the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the member left the conversation, or null if the member is still active in the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? LeaveDate { get; set; }

    /// <summary>
    /// If true, the guest member is an authenticated guest.
    /// </summary>
    /// <value>If true, the guest member is an authenticated guest.</value>
    public bool? AuthenticatedGuest { get; set; }

    /// <summary>
    /// Any custom fields of information pertaining to this member.
    /// </summary>
    /// <value>Any custom fields of information pertaining to this member.</value>
    public Dictionary<string, string> CustomFields { get; set; }
}
