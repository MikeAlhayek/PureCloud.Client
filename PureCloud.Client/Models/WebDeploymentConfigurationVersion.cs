using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details about the configuration version of a Web Deployment
/// </summary>
[DataContract]
public partial class WebDeploymentConfigurationVersion : IEquatable<WebDeploymentConfigurationVersion>
{
    /// <summary>
    /// The current status of the configuration version
    /// </summary>
    /// <value>The current status of the configuration version</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Deleting for "Deleting"
        /// </summary>
        [EnumMember(Value = "Deleting")]
        Deleting
    }
    /// <summary>
    /// The current status of the configuration version
    /// </summary>
    /// <value>The current status of the configuration version</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentConfigurationVersion" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebDeploymentConfigurationVersion() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentConfigurationVersion" /> class.
    /// </summary>
    /// <param name="Name">The configuration version name (required).</param>
    /// <param name="HeadlessMode">Headless Mode Support which Controls UI components. When enabled, native UI components will be disabled and allows for custom-built UI..</param>
    /// <param name="Description">The description of the configuration.</param>
    /// <param name="Languages">A list of languages supported on the configuration required if the messenger is enabled.</param>
    /// <param name="DefaultLanguage">The default language to use for the configuration required if the messenger is enabled.</param>
    /// <param name="CustomI18nLabels">The localization settings for homescreen app.</param>
    /// <param name="Messenger">The settings for messenger.</param>
    /// <param name="Position">The settings for position.</param>
    /// <param name="SupportCenter">The settings for knowledge portal (previously support center).</param>
    /// <param name="Cobrowse">The settings for cobrowse.</param>
    /// <param name="JourneyEvents">The settings for journey events.</param>
    /// <param name="AuthenticationSettings">The settings for authenticated deployments.</param>
    /// <param name="Video">The settings for video.</param>
    /// <param name="Status">The current status of the configuration version.</param>
    public WebDeploymentConfigurationVersion(string Name = null, WebDeploymentHeadlessMode HeadlessMode = null, string Description = null, List<string> Languages = null, string DefaultLanguage = null, List<CustomI18nLabels> CustomI18nLabels = null, MessengerSettings Messenger = null, PositionSettings Position = null, SupportCenterSettings SupportCenter = null, CobrowseSettings Cobrowse = null, JourneyEventsSettings JourneyEvents = null, AuthenticationSettings AuthenticationSettings = null, VideoSettings Video = null, StatusEnum? Status = null)
    {
        this.Name = Name;
        this.HeadlessMode = HeadlessMode;
        this.Description = Description;
        this.Languages = Languages;
        this.DefaultLanguage = DefaultLanguage;
        this.CustomI18nLabels = CustomI18nLabels;
        this.Messenger = Messenger;
        this.Position = Position;
        this.SupportCenter = SupportCenter;
        this.Cobrowse = Cobrowse;
        this.JourneyEvents = JourneyEvents;
        this.AuthenticationSettings = AuthenticationSettings;
        this.Video = Video;
        this.Status = Status;

    }



    /// <summary>
    /// The configuration version ID
    /// </summary>
    /// <value>The configuration version ID</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The configuration version name
    /// </summary>
    /// <value>The configuration version name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The version of the configuration
    /// </summary>
    /// <value>The version of the configuration</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string Version { get; private set; }



    /// <summary>
    /// Headless Mode Support which Controls UI components. When enabled, native UI components will be disabled and allows for custom-built UI.
    /// </summary>
    /// <value>Headless Mode Support which Controls UI components. When enabled, native UI components will be disabled and allows for custom-built UI.</value>
    [DataMember(Name = "headlessMode", EmitDefaultValue = false)]
    public WebDeploymentHeadlessMode HeadlessMode { get; set; }



    /// <summary>
    /// The description of the configuration
    /// </summary>
    /// <value>The description of the configuration</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// A list of languages supported on the configuration required if the messenger is enabled
    /// </summary>
    /// <value>A list of languages supported on the configuration required if the messenger is enabled</value>
    [DataMember(Name = "languages", EmitDefaultValue = false)]
    public List<string> Languages { get; set; }



    /// <summary>
    /// The default language to use for the configuration required if the messenger is enabled
    /// </summary>
    /// <value>The default language to use for the configuration required if the messenger is enabled</value>
    [DataMember(Name = "defaultLanguage", EmitDefaultValue = false)]
    public string DefaultLanguage { get; set; }



    /// <summary>
    /// The localization settings for homescreen app
    /// </summary>
    /// <value>The localization settings for homescreen app</value>
    [DataMember(Name = "customI18nLabels", EmitDefaultValue = false)]
    public List<CustomI18nLabels> CustomI18nLabels { get; set; }



    /// <summary>
    /// The settings for messenger
    /// </summary>
    /// <value>The settings for messenger</value>
    [DataMember(Name = "messenger", EmitDefaultValue = false)]
    public MessengerSettings Messenger { get; set; }



    /// <summary>
    /// The settings for position
    /// </summary>
    /// <value>The settings for position</value>
    [DataMember(Name = "position", EmitDefaultValue = false)]
    public PositionSettings Position { get; set; }



    /// <summary>
    /// The settings for knowledge portal (previously support center)
    /// </summary>
    /// <value>The settings for knowledge portal (previously support center)</value>
    [DataMember(Name = "supportCenter", EmitDefaultValue = false)]
    public SupportCenterSettings SupportCenter { get; set; }



    /// <summary>
    /// The settings for cobrowse
    /// </summary>
    /// <value>The settings for cobrowse</value>
    [DataMember(Name = "cobrowse", EmitDefaultValue = false)]
    public CobrowseSettings Cobrowse { get; set; }



    /// <summary>
    /// The settings for journey events
    /// </summary>
    /// <value>The settings for journey events</value>
    [DataMember(Name = "journeyEvents", EmitDefaultValue = false)]
    public JourneyEventsSettings JourneyEvents { get; set; }



    /// <summary>
    /// The settings for authenticated deployments
    /// </summary>
    /// <value>The settings for authenticated deployments</value>
    [DataMember(Name = "authenticationSettings", EmitDefaultValue = false)]
    public AuthenticationSettings AuthenticationSettings { get; set; }



    /// <summary>
    /// The settings for video
    /// </summary>
    /// <value>The settings for video</value>
    [DataMember(Name = "video", EmitDefaultValue = false)]
    public VideoSettings Video { get; set; }



    /// <summary>
    /// The date the configuration version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the configuration version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The date the configuration version was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the configuration version was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The date the configuration version was most recently published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the configuration version was most recently published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "datePublished", EmitDefaultValue = false)]
    public DateTime? DatePublished { get; private set; }



    /// <summary>
    /// A reference to the user who most recently modified the configuration version
    /// </summary>
    /// <value>A reference to the user who most recently modified the configuration version</value>
    [DataMember(Name = "lastModifiedUser", EmitDefaultValue = false)]
    public AddressableEntityRef LastModifiedUser { get; private set; }



    /// <summary>
    /// A reference to the user who created the configuration version
    /// </summary>
    /// <value>A reference to the user who created the configuration version</value>
    [DataMember(Name = "createdUser", EmitDefaultValue = false)]
    public AddressableEntityRef CreatedUser { get; private set; }



    /// <summary>
    /// A reference to the user who published the configuration version
    /// </summary>
    /// <value>A reference to the user who published the configuration version</value>
    [DataMember(Name = "publishedUser", EmitDefaultValue = false)]
    public AddressableEntityRef PublishedUser { get; private set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebDeploymentConfigurationVersion {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  HeadlessMode: ").Append(HeadlessMode).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Languages: ").Append(Languages).Append("\n");
        sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
        sb.Append("  CustomI18nLabels: ").Append(CustomI18nLabels).Append("\n");
        sb.Append("  Messenger: ").Append(Messenger).Append("\n");
        sb.Append("  Position: ").Append(Position).Append("\n");
        sb.Append("  SupportCenter: ").Append(SupportCenter).Append("\n");
        sb.Append("  Cobrowse: ").Append(Cobrowse).Append("\n");
        sb.Append("  JourneyEvents: ").Append(JourneyEvents).Append("\n");
        sb.Append("  AuthenticationSettings: ").Append(AuthenticationSettings).Append("\n");
        sb.Append("  Video: ").Append(Video).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
        sb.Append("  LastModifiedUser: ").Append(LastModifiedUser).Append("\n");
        sb.Append("  CreatedUser: ").Append(CreatedUser).Append("\n");
        sb.Append("  PublishedUser: ").Append(PublishedUser).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as WebDeploymentConfigurationVersion);
    }

    /// <summary>
    /// Returns true if WebDeploymentConfigurationVersion instances are equal
    /// </summary>
    /// <param name="other">Instance of WebDeploymentConfigurationVersion to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebDeploymentConfigurationVersion other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                HeadlessMode == other.HeadlessMode ||
                HeadlessMode != null &&
                HeadlessMode.Equals(other.HeadlessMode)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Languages == other.Languages ||
                Languages != null &&
                Languages.SequenceEqual(other.Languages)
            ) &&
            (
                DefaultLanguage == other.DefaultLanguage ||
                DefaultLanguage != null &&
                DefaultLanguage.Equals(other.DefaultLanguage)
            ) &&
            (
                CustomI18nLabels == other.CustomI18nLabels ||
                CustomI18nLabels != null &&
                CustomI18nLabels.SequenceEqual(other.CustomI18nLabels)
            ) &&
            (
                Messenger == other.Messenger ||
                Messenger != null &&
                Messenger.Equals(other.Messenger)
            ) &&
            (
                Position == other.Position ||
                Position != null &&
                Position.Equals(other.Position)
            ) &&
            (
                SupportCenter == other.SupportCenter ||
                SupportCenter != null &&
                SupportCenter.Equals(other.SupportCenter)
            ) &&
            (
                Cobrowse == other.Cobrowse ||
                Cobrowse != null &&
                Cobrowse.Equals(other.Cobrowse)
            ) &&
            (
                JourneyEvents == other.JourneyEvents ||
                JourneyEvents != null &&
                JourneyEvents.Equals(other.JourneyEvents)
            ) &&
            (
                AuthenticationSettings == other.AuthenticationSettings ||
                AuthenticationSettings != null &&
                AuthenticationSettings.Equals(other.AuthenticationSettings)
            ) &&
            (
                Video == other.Video ||
                Video != null &&
                Video.Equals(other.Video)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                DatePublished == other.DatePublished ||
                DatePublished != null &&
                DatePublished.Equals(other.DatePublished)
            ) &&
            (
                LastModifiedUser == other.LastModifiedUser ||
                LastModifiedUser != null &&
                LastModifiedUser.Equals(other.LastModifiedUser)
            ) &&
            (
                CreatedUser == other.CreatedUser ||
                CreatedUser != null &&
                CreatedUser.Equals(other.CreatedUser)
            ) &&
            (
                PublishedUser == other.PublishedUser ||
                PublishedUser != null &&
                PublishedUser.Equals(other.PublishedUser)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (HeadlessMode != null)
            {
                hash = hash * 59 + HeadlessMode.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Languages != null)
            {
                hash = hash * 59 + Languages.GetHashCode();
            }

            if (DefaultLanguage != null)
            {
                hash = hash * 59 + DefaultLanguage.GetHashCode();
            }

            if (CustomI18nLabels != null)
            {
                hash = hash * 59 + CustomI18nLabels.GetHashCode();
            }

            if (Messenger != null)
            {
                hash = hash * 59 + Messenger.GetHashCode();
            }

            if (Position != null)
            {
                hash = hash * 59 + Position.GetHashCode();
            }

            if (SupportCenter != null)
            {
                hash = hash * 59 + SupportCenter.GetHashCode();
            }

            if (Cobrowse != null)
            {
                hash = hash * 59 + Cobrowse.GetHashCode();
            }

            if (JourneyEvents != null)
            {
                hash = hash * 59 + JourneyEvents.GetHashCode();
            }

            if (AuthenticationSettings != null)
            {
                hash = hash * 59 + AuthenticationSettings.GetHashCode();
            }

            if (Video != null)
            {
                hash = hash * 59 + Video.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DatePublished != null)
            {
                hash = hash * 59 + DatePublished.GetHashCode();
            }

            if (LastModifiedUser != null)
            {
                hash = hash * 59 + LastModifiedUser.GetHashCode();
            }

            if (CreatedUser != null)
            {
                hash = hash * 59 + CreatedUser.GetHashCode();
            }

            if (PublishedUser != null)
            {
                hash = hash * 59 + PublishedUser.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
