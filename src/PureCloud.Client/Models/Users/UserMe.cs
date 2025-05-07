using System.Text.Json.Serialization;
using PureCloud.Client.Models.Groups;
using PureCloud.Client.Models.Locations;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public partial class UserMe
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
    public IEnumerable<Contact> PrimaryContactInfo { get; set; }

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
    public IEnumerable<string> ProfileSkills { get; set; }

    /// <summary>
    /// The user placement at each site location.
    /// </summary>
    /// <value>The user placement at each site location.</value>
    [JsonPropertyName("locations")]
    public IEnumerable<Location> Locations { get; set; }

    /// <summary>
    /// The groups the user is a member of
    /// </summary>
    /// <value>The groups the user is a member of</value>
    public IEnumerable<Group> Groups { get; set; }

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
    public IEnumerable<UserRoutingSkill> Skills { get; set; }

    /// <summary>
    /// Routing (ACD) languages possessed by the user
    /// </summary>
    /// <value>Routing (ACD) languages possessed by the user</value>
    public IEnumerable<UserRoutingLanguage> Languages { get; set; }

    /// <summary>
    /// Auto answer settings for this user
    /// </summary>
    /// <value>Auto answer settings for this user</value>
    public AutoAnswerSettings AutoAnswerSettings { get; set; }

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
    /// The PureCloudEnvironment system date time.
    /// </summary>
    /// <value>The PureCloudEnvironment system date time.</value>
    public ServerDate Date { get; set; }

    /// <summary>
    /// Geolocation settings for user&#39;s organization.
    /// </summary>
    /// <value>Geolocation settings for user&#39;s organization.</value>
    public GeolocationSettings GeolocationSettings { get; set; }

    /// <summary>
    /// Organization details for this user.
    /// </summary>
    /// <value>Organization details for this user.</value>
    public Organization Organization { get; set; }

    /// <summary>
    /// The first 100 non-divisioned presence definitions for user&#39;s organization.
    /// </summary>
    /// <value>The first 100 non-divisioned presence definitions for user&#39;s organization.</value>
    public IEnumerable<OrganizationPresence> PresenceDefinitions { get; set; }

    /// <summary>
    /// The presence definitions that the user has access to
    /// </summary>
    /// <value>The presence definitions that the user has access to</value>
    public IEnumerable<OrganizationPresenceDefinition> DivisionedPresenceDefinitions { get; set; }

    /// <summary>
    /// The first 100 site locations for user&#39;s organization
    /// </summary>
    /// <value>The first 100 site locations for user&#39;s organization</value>
    public IEnumerable<LocationDefinition> LocationDefinitions { get; set; }

    /// <summary>
    /// The first 100 organization roles, with applicable permission policies, for user&#39;s organization.
    /// </summary>
    /// <value>The first 100 organization roles, with applicable permission policies, for user&#39;s organization.</value>
    public IEnumerable<DomainOrganizationRole> OrgAuthorization { get; set; }

    /// <summary>
    /// The first 50 favorited users.
    /// </summary>
    /// <value>The first 50 favorited users.</value>
    public IEnumerable<User> Favorites { get; set; }

    /// <summary>
    /// The first 50 superiors of this user.
    /// </summary>
    /// <value>The first 50 superiors of this user.</value>
    public IEnumerable<User> Superiors { get; set; }

    /// <summary>
    /// The first 50 direct reports to this user.
    /// </summary>
    /// <value>The first 50 direct reports to this user.</value>
    public IEnumerable<User> DirectReports { get; set; }

    /// <summary>
    /// The first 50 superiors, direct reports, and siblings of this user. Mutually exclusive with superiors and direct reports expands.
    /// </summary>
    /// <value>The first 50 superiors, direct reports, and siblings of this user. Mutually exclusive with superiors and direct reports expands.</value>
    public Adjacents Adjacents { get; set; }

    /// <summary>
    /// The first 50 routing skills for user&#39;s organizations
    /// </summary>
    /// <value>The first 50 routing skills for user&#39;s organizations</value>
    public IEnumerable<RoutingSkill> RoutingSkills { get; set; }

    /// <summary>
    /// The field config for all entities types of user&#39;s organization
    /// </summary>
    /// <value>The field config for all entities types of user&#39;s organization</value>
    public FieldConfigs FieldConfigs { get; set; }

    /// <summary>
    /// Information about the current token
    /// </summary>
    /// <value>Information about the current token</value>
    public TokenInfo Token { get; set; }

    /// <summary>
    /// Organizations having this user as a trustee
    /// </summary>
    /// <value>Organizations having this user as a trustee</value>
    public IEnumerable<Trustor> Trustors { get; set; }

    /// <summary>
    /// Products enabled in this organization
    /// </summary>
    /// <value>Products enabled in this organization</value>
    public IEnumerable<DomainOrganizationProduct> OrgProducts { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
