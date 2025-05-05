using System.Text.Json.Serialization;
using PureCloud.Client.Models.Groups;
using PureCloud.Client.Models.Locations;

namespace PureCloud.Client.Models.Users;

/// <summary>
/// UpdateUser
/// </summary>
public partial class UpdateUser
{
    /// <summary>
    /// The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.
    /// </summary>
    /// <value>The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.</value>

    /// <summary>
    /// The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.
    /// </summary>
    /// <value>The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.</value>
    public UserState? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; private set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

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
    /// The address(s) used for primary contact. Updates to the corresponding address in the addresses list will be reflected here.
    /// </summary>
    /// <value>The address(s) used for primary contact. Updates to the corresponding address in the addresses list will be reflected here.</value>
    public List<Contact> PrimaryContactInfo { get; private set; }

    /// <summary>
    /// Email address, phone number, and/or extension for this user. One entry is allowed per media type
    /// </summary>
    /// <value>Email address, phone number, and/or extension for this user. One entry is allowed per media type</value>
    public List<Contact> Addresses { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Preferred full name of agent
    /// </summary>
    /// <value>Preferred full name of agent</value>
    public string PreferredName { get; set; }

    /// <summary>
    /// Gets or Sets Manager
    /// </summary>
    public string Manager { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    public List<Image> Images { get; set; }

    /// <summary>
    /// This value should be the current version of the user. The current version can be obtained with a GET on the user before doing a PATCH.
    /// </summary>
    /// <value>This value should be the current version of the user. The current version can be obtained with a GET on the user before doing a PATCH.</value>
    public int? Version { get; set; }

    /// <summary>
    /// Profile skills possessed by the user
    /// </summary>
    /// <value>Profile skills possessed by the user</value>
    public List<string> ProfileSkills { get; set; }

    /// <summary>
    /// The user placement at each site location.
    /// </summary>
    /// <value>The user placement at each site location.</value>
    public List<Location> Locations { get; set; }

    /// <summary>
    /// The groups the user is a member of
    /// </summary>
    /// <value>The groups the user is a member of</value>
    public List<Group> Groups { get; set; }

    /// <summary>
    /// The value that denotes if acdAutoAnswer is set on the user
    /// </summary>
    /// <value>The value that denotes if acdAutoAnswer is set on the user</value>
    public bool? AcdAutoAnswer { get; set; }

    /// <summary>
    /// Gets or Sets Certifications
    /// </summary>
    [JsonPropertyName("certifications")]
    public List<string> Certifications { get; set; }

    /// <summary>
    /// Gets or Sets Biography
    /// </summary>
    [JsonPropertyName("biography")]
    public Biography Biography { get; set; }

    /// <summary>
    /// Gets or Sets EmployerInfo
    /// </summary>
    [JsonPropertyName("employerInfo")]
    public EmployerInfo EmployerInfo { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; private set; }
}
