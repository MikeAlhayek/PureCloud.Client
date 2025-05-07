using PureCloud.Client.Models.Groups;
using PureCloud.Client.Models.Locations;

namespace PureCloud.Client.Models.Users;

public sealed class User
{
    /// <summary>
    /// The current state for this user.
    /// </summary>
    /// <value>The current state for this user.</value>
    public UserState? State { get; set; }

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
    /// Auto populated from addresses.
    /// </summary>
    /// <value>Auto populated from addresses.</value>
    public List<Contact> PrimaryContactInfo { get; set; }

    /// <summary>
    /// Email addresses and phone numbers for this user
    /// </summary>
    /// <value>Email addresses and phone numbers for this user</value>
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
    /// Gets or Sets Manager
    /// </summary>
    public User Manager { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    public List<Image> Images { get; set; }

    /// <summary>
    /// Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH.
    /// </summary>
    /// <value>Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH.</value>
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets Certifications
    /// </summary>
    public List<string> Certifications { get; set; }

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
    /// ACD routing status
    /// </summary>
    /// <value>ACD routing status</value>
    public RoutingStatus RoutingStatus { get; set; }

    /// <summary>
    /// Active presence
    /// </summary>
    /// <value>Active presence</value>
    public UserPresence Presence { get; set; }

    /// <summary>
    /// Integration presence
    /// </summary>
    /// <value>Integration presence</value>
    public UserPresence IntegrationPresence { get; set; }

    /// <summary>
    /// Summary of conversion statistics for conversation types.
    /// </summary>
    /// <value>Summary of conversion statistics for conversation types.</value>
    public UserConversationSummary ConversationSummary { get; set; }

    /// <summary>
    /// Determine if out of office is enabled
    /// </summary>
    /// <value>Determine if out of office is enabled</value>
    public OutOfOffice OutOfOffice { get; set; }

    /// <summary>
    /// Current geolocation position
    /// </summary>
    /// <value>Current geolocation position</value>
    public Geolocation Geolocation { get; set; }

    /// <summary>
    /// Effective, default, and last station information
    /// </summary>
    /// <value>Effective, default, and last station information</value>
    public UserStations Station { get; set; }

    /// <summary>
    /// Roles and permissions assigned to the user
    /// </summary>
    /// <value>Roles and permissions assigned to the user</value>
    public UserAuthorization Authorization { get; set; }

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
    /// The team the user is a member of
    /// </summary>
    /// <value>The team the user is a member of</value>
    public Team Team { get; set; }

    /// <summary>
    /// The WFM work plan bid rank settings for the user
    /// </summary>
    /// <value>The WFM work plan bid rank settings for the user</value>
    public WorkPlanBidRanks WorkPlanBidRanks { get; set; }

    /// <summary>
    /// Routing (ACD) skills possessed by the user
    /// </summary>
    /// <value>Routing (ACD) skills possessed by the user</value>
    public List<UserRoutingSkill> Skills { get; set; }

    /// <summary>
    /// Routing (ACD) languages possessed by the user
    /// </summary>
    /// <value>Routing (ACD) languages possessed by the user</value>
    public List<UserRoutingLanguage> Languages { get; set; }

    /// <summary>
    /// acd auto answer
    /// </summary>
    /// <value>acd auto answer</value>
    public bool? AcdAutoAnswer { get; set; }

    /// <summary>
    /// preferred language by the user
    /// </summary>
    /// <value>preferred language by the user</value>
    public string LanguagePreference { get; set; }

    /// <summary>
    /// Gets or Sets LastTokenIssued
    /// </summary>
    public OAuthLastTokenIssued LastTokenIssued { get; set; }

    /// <summary>
    /// The last time the user logged in using username and password. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last time the user logged in using username and password. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateLastLogin { get; set; }

    /// <summary>
    /// The date &amp; time the user was sent their welcome email. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date &amp; time the user was sent their welcome email. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateWelcomeSent { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
