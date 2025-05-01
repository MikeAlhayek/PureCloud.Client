using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OrgUser
/// </summary>
[DataContract]
public partial class OrgUser : IEquatable<OrgUser>
{
    /// <summary>
    /// The current state for this user.
    /// </summary>
    /// <value>The current state for this user.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Inactive for "inactive"
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

        /// <summary>
        /// Enum Deleted for "deleted"
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
    /// <summary>
    /// The current state for this user.
    /// </summary>
    /// <value>The current state for this user.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrgUser" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OrgUser() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OrgUser" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Chat">Chat.</param>
    /// <param name="Department">Department.</param>
    /// <param name="Email">Email.</param>
    /// <param name="Addresses">Email addresses and phone numbers for this user.</param>
    /// <param name="Title">Title.</param>
    /// <param name="Username">Username.</param>
    /// <param name="Manager">Manager.</param>
    /// <param name="Images">Images.</param>
    /// <param name="Version">Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH. (required).</param>
    /// <param name="Certifications">Certifications.</param>
    /// <param name="Biography">Biography.</param>
    /// <param name="EmployerInfo">EmployerInfo.</param>
    /// <param name="PreferredName">Preferred full name of the agent.</param>
    /// <param name="AcdAutoAnswer">acd auto answer.</param>
    /// <param name="LastTokenIssued">LastTokenIssued.</param>
    /// <param name="Organization">Organization.</param>
    public OrgUser(string Name = null, Division Division = null, Chat Chat = null, string Department = null, string Email = null, List<Contact> Addresses = null, string Title = null, string Username = null, User Manager = null, List<Image> Images = null, int? Version = null, List<string> Certifications = null, Biography Biography = null, EmployerInfo EmployerInfo = null, string PreferredName = null, bool? AcdAutoAnswer = null, OAuthLastTokenIssued LastTokenIssued = null, Organization Organization = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Chat = Chat;
        this.Department = Department;
        this.Email = Email;
        this.Addresses = Addresses;
        this.Title = Title;
        this.Username = Username;
        this.Manager = Manager;
        this.Images = Images;
        this.Version = Version;
        this.Certifications = Certifications;
        this.Biography = Biography;
        this.EmployerInfo = EmployerInfo;
        this.PreferredName = PreferredName;
        this.AcdAutoAnswer = AcdAutoAnswer;
        this.LastTokenIssued = LastTokenIssued;
        this.Organization = Organization;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public Division Division { get; set; }



    /// <summary>
    /// Gets or Sets Chat
    /// </summary>
    [DataMember(Name = "chat", EmitDefaultValue = false)]
    public Chat Chat { get; set; }



    /// <summary>
    /// Gets or Sets Department
    /// </summary>
    [DataMember(Name = "department", EmitDefaultValue = false)]
    public string Department { get; set; }



    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    public string Email { get; set; }



    /// <summary>
    /// Auto populated from addresses.
    /// </summary>
    /// <value>Auto populated from addresses.</value>
    [DataMember(Name = "primaryContactInfo", EmitDefaultValue = false)]
    public List<Contact> PrimaryContactInfo { get; private set; }



    /// <summary>
    /// Email addresses and phone numbers for this user
    /// </summary>
    /// <value>Email addresses and phone numbers for this user</value>
    [DataMember(Name = "addresses", EmitDefaultValue = false)]
    public List<Contact> Addresses { get; set; }





    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [DataMember(Name = "username", EmitDefaultValue = false)]
    public string Username { get; set; }



    /// <summary>
    /// Gets or Sets Manager
    /// </summary>
    [DataMember(Name = "manager", EmitDefaultValue = false)]
    public User Manager { get; set; }



    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    [DataMember(Name = "images", EmitDefaultValue = false)]
    public List<Image> Images { get; set; }



    /// <summary>
    /// Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH.
    /// </summary>
    /// <value>Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// Gets or Sets Certifications
    /// </summary>
    [DataMember(Name = "certifications", EmitDefaultValue = false)]
    public List<string> Certifications { get; set; }



    /// <summary>
    /// Gets or Sets Biography
    /// </summary>
    [DataMember(Name = "biography", EmitDefaultValue = false)]
    public Biography Biography { get; set; }



    /// <summary>
    /// Gets or Sets EmployerInfo
    /// </summary>
    [DataMember(Name = "employerInfo", EmitDefaultValue = false)]
    public EmployerInfo EmployerInfo { get; set; }



    /// <summary>
    /// Preferred full name of the agent
    /// </summary>
    /// <value>Preferred full name of the agent</value>
    [DataMember(Name = "preferredName", EmitDefaultValue = false)]
    public string PreferredName { get; set; }



    /// <summary>
    /// ACD routing status
    /// </summary>
    /// <value>ACD routing status</value>
    [DataMember(Name = "routingStatus", EmitDefaultValue = false)]
    public RoutingStatus RoutingStatus { get; private set; }



    /// <summary>
    /// Active presence
    /// </summary>
    /// <value>Active presence</value>
    [DataMember(Name = "presence", EmitDefaultValue = false)]
    public UserPresence Presence { get; private set; }



    /// <summary>
    /// Integration presence
    /// </summary>
    /// <value>Integration presence</value>
    [DataMember(Name = "integrationPresence", EmitDefaultValue = false)]
    public UserPresence IntegrationPresence { get; private set; }



    /// <summary>
    /// Summary of conversion statistics for conversation types.
    /// </summary>
    /// <value>Summary of conversion statistics for conversation types.</value>
    [DataMember(Name = "conversationSummary", EmitDefaultValue = false)]
    public UserConversationSummary ConversationSummary { get; private set; }



    /// <summary>
    /// Determine if out of office is enabled
    /// </summary>
    /// <value>Determine if out of office is enabled</value>
    [DataMember(Name = "outOfOffice", EmitDefaultValue = false)]
    public OutOfOffice OutOfOffice { get; private set; }



    /// <summary>
    /// Current geolocation position
    /// </summary>
    /// <value>Current geolocation position</value>
    [DataMember(Name = "geolocation", EmitDefaultValue = false)]
    public Geolocation Geolocation { get; private set; }



    /// <summary>
    /// Effective, default, and last station information
    /// </summary>
    /// <value>Effective, default, and last station information</value>
    [DataMember(Name = "station", EmitDefaultValue = false)]
    public UserStations Station { get; private set; }



    /// <summary>
    /// Roles and permissions assigned to the user
    /// </summary>
    /// <value>Roles and permissions assigned to the user</value>
    [DataMember(Name = "authorization", EmitDefaultValue = false)]
    public UserAuthorization Authorization { get; private set; }



    /// <summary>
    /// Profile skills possessed by the user
    /// </summary>
    /// <value>Profile skills possessed by the user</value>
    [DataMember(Name = "profileSkills", EmitDefaultValue = false)]
    public List<string> ProfileSkills { get; private set; }



    /// <summary>
    /// The user placement at each site location.
    /// </summary>
    /// <value>The user placement at each site location.</value>
    [DataMember(Name = "locations", EmitDefaultValue = false)]
    public List<Location> Locations { get; private set; }



    /// <summary>
    /// The groups the user is a member of
    /// </summary>
    /// <value>The groups the user is a member of</value>
    [DataMember(Name = "groups", EmitDefaultValue = false)]
    public List<Group> Groups { get; private set; }



    /// <summary>
    /// The team the user is a member of
    /// </summary>
    /// <value>The team the user is a member of</value>
    [DataMember(Name = "team", EmitDefaultValue = false)]
    public Team Team { get; private set; }



    /// <summary>
    /// The WFM work plan bid rank settings for the user
    /// </summary>
    /// <value>The WFM work plan bid rank settings for the user</value>
    [DataMember(Name = "workPlanBidRanks", EmitDefaultValue = false)]
    public WorkPlanBidRanks WorkPlanBidRanks { get; private set; }



    /// <summary>
    /// Routing (ACD) skills possessed by the user
    /// </summary>
    /// <value>Routing (ACD) skills possessed by the user</value>
    [DataMember(Name = "skills", EmitDefaultValue = false)]
    public List<UserRoutingSkill> Skills { get; private set; }



    /// <summary>
    /// Routing (ACD) languages possessed by the user
    /// </summary>
    /// <value>Routing (ACD) languages possessed by the user</value>
    [DataMember(Name = "languages", EmitDefaultValue = false)]
    public List<UserRoutingLanguage> Languages { get; private set; }



    /// <summary>
    /// acd auto answer
    /// </summary>
    /// <value>acd auto answer</value>
    [DataMember(Name = "acdAutoAnswer", EmitDefaultValue = false)]
    public bool? AcdAutoAnswer { get; set; }



    /// <summary>
    /// preferred language by the user
    /// </summary>
    /// <value>preferred language by the user</value>
    [DataMember(Name = "languagePreference", EmitDefaultValue = false)]
    public string LanguagePreference { get; private set; }



    /// <summary>
    /// Gets or Sets LastTokenIssued
    /// </summary>
    [DataMember(Name = "lastTokenIssued", EmitDefaultValue = false)]
    public OAuthLastTokenIssued LastTokenIssued { get; set; }



    /// <summary>
    /// The last time the user logged in using username and password. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last time the user logged in using username and password. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateLastLogin", EmitDefaultValue = false)]
    public DateTime? DateLastLogin { get; private set; }



    /// <summary>
    /// The date &amp; time the user was sent their welcome email. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date &amp; time the user was sent their welcome email. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateWelcomeSent", EmitDefaultValue = false)]
    public DateTime? DateWelcomeSent { get; private set; }



    /// <summary>
    /// Gets or Sets Organization
    /// </summary>
    [DataMember(Name = "organization", EmitDefaultValue = false)]
    public Organization Organization { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OrgUser {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Chat: ").Append(Chat).Append("\n");
        sb.Append("  Department: ").Append(Department).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  PrimaryContactInfo: ").Append(PrimaryContactInfo).Append("\n");
        sb.Append("  Addresses: ").Append(Addresses).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
        sb.Append("  Manager: ").Append(Manager).Append("\n");
        sb.Append("  Images: ").Append(Images).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Certifications: ").Append(Certifications).Append("\n");
        sb.Append("  Biography: ").Append(Biography).Append("\n");
        sb.Append("  EmployerInfo: ").Append(EmployerInfo).Append("\n");
        sb.Append("  PreferredName: ").Append(PreferredName).Append("\n");
        sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
        sb.Append("  Presence: ").Append(Presence).Append("\n");
        sb.Append("  IntegrationPresence: ").Append(IntegrationPresence).Append("\n");
        sb.Append("  ConversationSummary: ").Append(ConversationSummary).Append("\n");
        sb.Append("  OutOfOffice: ").Append(OutOfOffice).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  Station: ").Append(Station).Append("\n");
        sb.Append("  Authorization: ").Append(Authorization).Append("\n");
        sb.Append("  ProfileSkills: ").Append(ProfileSkills).Append("\n");
        sb.Append("  Locations: ").Append(Locations).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  Team: ").Append(Team).Append("\n");
        sb.Append("  WorkPlanBidRanks: ").Append(WorkPlanBidRanks).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
        sb.Append("  Languages: ").Append(Languages).Append("\n");
        sb.Append("  AcdAutoAnswer: ").Append(AcdAutoAnswer).Append("\n");
        sb.Append("  LanguagePreference: ").Append(LanguagePreference).Append("\n");
        sb.Append("  LastTokenIssued: ").Append(LastTokenIssued).Append("\n");
        sb.Append("  DateLastLogin: ").Append(DateLastLogin).Append("\n");
        sb.Append("  DateWelcomeSent: ").Append(DateWelcomeSent).Append("\n");
        sb.Append("  Organization: ").Append(Organization).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as OrgUser);
    }

    /// <summary>
    /// Returns true if OrgUser instances are equal
    /// </summary>
    /// <param name="other">Instance of OrgUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OrgUser other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Chat == other.Chat ||
                Chat != null &&
                Chat.Equals(other.Chat)
            ) &&
            (
                Department == other.Department ||
                Department != null &&
                Department.Equals(other.Department)
            ) &&
            (
                Email == other.Email ||
                Email != null &&
                Email.Equals(other.Email)
            ) &&
            (
                PrimaryContactInfo == other.PrimaryContactInfo ||
                PrimaryContactInfo != null &&
                PrimaryContactInfo.SequenceEqual(other.PrimaryContactInfo)
            ) &&
            (
                Addresses == other.Addresses ||
                Addresses != null &&
                Addresses.SequenceEqual(other.Addresses)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Username == other.Username ||
                Username != null &&
                Username.Equals(other.Username)
            ) &&
            (
                Manager == other.Manager ||
                Manager != null &&
                Manager.Equals(other.Manager)
            ) &&
            (
                Images == other.Images ||
                Images != null &&
                Images.SequenceEqual(other.Images)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Certifications == other.Certifications ||
                Certifications != null &&
                Certifications.SequenceEqual(other.Certifications)
            ) &&
            (
                Biography == other.Biography ||
                Biography != null &&
                Biography.Equals(other.Biography)
            ) &&
            (
                EmployerInfo == other.EmployerInfo ||
                EmployerInfo != null &&
                EmployerInfo.Equals(other.EmployerInfo)
            ) &&
            (
                PreferredName == other.PreferredName ||
                PreferredName != null &&
                PreferredName.Equals(other.PreferredName)
            ) &&
            (
                RoutingStatus == other.RoutingStatus ||
                RoutingStatus != null &&
                RoutingStatus.Equals(other.RoutingStatus)
            ) &&
            (
                Presence == other.Presence ||
                Presence != null &&
                Presence.Equals(other.Presence)
            ) &&
            (
                IntegrationPresence == other.IntegrationPresence ||
                IntegrationPresence != null &&
                IntegrationPresence.Equals(other.IntegrationPresence)
            ) &&
            (
                ConversationSummary == other.ConversationSummary ||
                ConversationSummary != null &&
                ConversationSummary.Equals(other.ConversationSummary)
            ) &&
            (
                OutOfOffice == other.OutOfOffice ||
                OutOfOffice != null &&
                OutOfOffice.Equals(other.OutOfOffice)
            ) &&
            (
                Geolocation == other.Geolocation ||
                Geolocation != null &&
                Geolocation.Equals(other.Geolocation)
            ) &&
            (
                Station == other.Station ||
                Station != null &&
                Station.Equals(other.Station)
            ) &&
            (
                Authorization == other.Authorization ||
                Authorization != null &&
                Authorization.Equals(other.Authorization)
            ) &&
            (
                ProfileSkills == other.ProfileSkills ||
                ProfileSkills != null &&
                ProfileSkills.SequenceEqual(other.ProfileSkills)
            ) &&
            (
                Locations == other.Locations ||
                Locations != null &&
                Locations.SequenceEqual(other.Locations)
            ) &&
            (
                Groups == other.Groups ||
                Groups != null &&
                Groups.SequenceEqual(other.Groups)
            ) &&
            (
                Team == other.Team ||
                Team != null &&
                Team.Equals(other.Team)
            ) &&
            (
                WorkPlanBidRanks == other.WorkPlanBidRanks ||
                WorkPlanBidRanks != null &&
                WorkPlanBidRanks.Equals(other.WorkPlanBidRanks)
            ) &&
            (
                Skills == other.Skills ||
                Skills != null &&
                Skills.SequenceEqual(other.Skills)
            ) &&
            (
                Languages == other.Languages ||
                Languages != null &&
                Languages.SequenceEqual(other.Languages)
            ) &&
            (
                AcdAutoAnswer == other.AcdAutoAnswer ||
                AcdAutoAnswer != null &&
                AcdAutoAnswer.Equals(other.AcdAutoAnswer)
            ) &&
            (
                LanguagePreference == other.LanguagePreference ||
                LanguagePreference != null &&
                LanguagePreference.Equals(other.LanguagePreference)
            ) &&
            (
                LastTokenIssued == other.LastTokenIssued ||
                LastTokenIssued != null &&
                LastTokenIssued.Equals(other.LastTokenIssued)
            ) &&
            (
                DateLastLogin == other.DateLastLogin ||
                DateLastLogin != null &&
                DateLastLogin.Equals(other.DateLastLogin)
            ) &&
            (
                DateWelcomeSent == other.DateWelcomeSent ||
                DateWelcomeSent != null &&
                DateWelcomeSent.Equals(other.DateWelcomeSent)
            ) &&
            (
                Organization == other.Organization ||
                Organization != null &&
                Organization.Equals(other.Organization)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Chat != null)
            {
                hash = hash * 59 + Chat.GetHashCode();
            }

            if (Department != null)
            {
                hash = hash * 59 + Department.GetHashCode();
            }

            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            if (PrimaryContactInfo != null)
            {
                hash = hash * 59 + PrimaryContactInfo.GetHashCode();
            }

            if (Addresses != null)
            {
                hash = hash * 59 + Addresses.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Username != null)
            {
                hash = hash * 59 + Username.GetHashCode();
            }

            if (Manager != null)
            {
                hash = hash * 59 + Manager.GetHashCode();
            }

            if (Images != null)
            {
                hash = hash * 59 + Images.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Certifications != null)
            {
                hash = hash * 59 + Certifications.GetHashCode();
            }

            if (Biography != null)
            {
                hash = hash * 59 + Biography.GetHashCode();
            }

            if (EmployerInfo != null)
            {
                hash = hash * 59 + EmployerInfo.GetHashCode();
            }

            if (PreferredName != null)
            {
                hash = hash * 59 + PreferredName.GetHashCode();
            }

            if (RoutingStatus != null)
            {
                hash = hash * 59 + RoutingStatus.GetHashCode();
            }

            if (Presence != null)
            {
                hash = hash * 59 + Presence.GetHashCode();
            }

            if (IntegrationPresence != null)
            {
                hash = hash * 59 + IntegrationPresence.GetHashCode();
            }

            if (ConversationSummary != null)
            {
                hash = hash * 59 + ConversationSummary.GetHashCode();
            }

            if (OutOfOffice != null)
            {
                hash = hash * 59 + OutOfOffice.GetHashCode();
            }

            if (Geolocation != null)
            {
                hash = hash * 59 + Geolocation.GetHashCode();
            }

            if (Station != null)
            {
                hash = hash * 59 + Station.GetHashCode();
            }

            if (Authorization != null)
            {
                hash = hash * 59 + Authorization.GetHashCode();
            }

            if (ProfileSkills != null)
            {
                hash = hash * 59 + ProfileSkills.GetHashCode();
            }

            if (Locations != null)
            {
                hash = hash * 59 + Locations.GetHashCode();
            }

            if (Groups != null)
            {
                hash = hash * 59 + Groups.GetHashCode();
            }

            if (Team != null)
            {
                hash = hash * 59 + Team.GetHashCode();
            }

            if (WorkPlanBidRanks != null)
            {
                hash = hash * 59 + WorkPlanBidRanks.GetHashCode();
            }

            if (Skills != null)
            {
                hash = hash * 59 + Skills.GetHashCode();
            }

            if (Languages != null)
            {
                hash = hash * 59 + Languages.GetHashCode();
            }

            if (AcdAutoAnswer != null)
            {
                hash = hash * 59 + AcdAutoAnswer.GetHashCode();
            }

            if (LanguagePreference != null)
            {
                hash = hash * 59 + LanguagePreference.GetHashCode();
            }

            if (LastTokenIssued != null)
            {
                hash = hash * 59 + LastTokenIssued.GetHashCode();
            }

            if (DateLastLogin != null)
            {
                hash = hash * 59 + DateLastLogin.GetHashCode();
            }

            if (DateWelcomeSent != null)
            {
                hash = hash * 59 + DateWelcomeSent.GetHashCode();
            }

            if (Organization != null)
            {
                hash = hash * 59 + Organization.GetHashCode();
            }

            return hash;
        }
    }
}
