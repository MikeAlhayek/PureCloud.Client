using PureCloud.Client.Models.Groups;
using PureCloud.Client.Models.Locations;
using PureCloud.Client.Models.Teams;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class TrustUser
{
    /// <summary>
    /// The current state for this user.
    /// </summary>
    /// <value>The current state for this user.</value>
    public StateEnum? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public Division Division { get; set; }

    /// <summary>
    /// Gets or Sets Chat
    /// </summary>
    public Chat Chat { get; set; }

    /// <summary>
    /// Gets or Sets Department
    /// </summary>
    public string Department { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Email addresses and phone numbers for this user
    /// </summary>
    /// <value>Email addresses and phone numbers for this user</value>
    public IEnumerable<Contact> Addresses { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Gets or Sets Manager
    /// </summary>
    public User Manager { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    public IEnumerable<Image> Images { get; set; }

    /// <summary>
    /// Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH.
    /// </summary>
    /// <value>Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH.</value>
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets Certifications
    /// </summary>
    public IEnumerable<string> Certifications { get; set; }

    /// <summary>
    /// Gets or Sets Biography
    /// </summary>
    public Biography Biography { get; set; }

    /// <summary>
    /// Gets or Sets EmployerInfo
    /// </summary>
    public EmployerInfo EmployerInfo { get; set; }

    /// <summary>
    /// Preferred full name of the agent
    /// </summary>
    /// <value>Preferred full name of the agent</value>
    public string PreferredName { get; set; }

    /// <summary>
    /// acd auto answer
    /// </summary>
    /// <value>acd auto answer</value>
    public bool? AcdAutoAnswer { get; set; }

    /// <summary>
    /// Gets or Sets LastTokenIssued
    /// </summary>
    public OAuthLastTokenIssued LastTokenIssued { get; set; }

    /// <summary>
    /// Gets or Sets TrustUserDetails
    /// </summary>
    public TrustUserDetails TrustUserDetails { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}