using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings concerning messenger
/// </summary>

public partial class MessengerSettings : IEquatable<MessengerSettings>
{
    /// <summary>
    /// The session persistence type for messenger
    /// </summary>
    /// <value>The session persistence type for messenger</value>
    
    public enum SessionPersistenceTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Acrosssubdomains for "AcrossSubdomains"
        /// </summary>
        [EnumMember(Value = "AcrossSubdomains")]
        Acrosssubdomains,

        /// <summary>
        /// Enum Domainorsubdomainonly for "DomainOrSubdomainOnly"
        /// </summary>
        [EnumMember(Value = "DomainOrSubdomainOnly")]
        Domainorsubdomainonly
    }
    /// <summary>
    /// The session persistence type for messenger
    /// </summary>
    /// <value>The session persistence type for messenger</value>
    [JsonPropertyName("sessionPersistenceType")]
    public SessionPersistenceTypeEnum? SessionPersistenceType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessengerSettings" /> class.
    /// </summary>
    /// <param name="Enabled">Whether or not messenger is enabled.</param>
    /// <param name="Styles">The style settings for messenger.</param>
    /// <param name="LauncherButton">The launcher button settings for messenger.</param>
    /// <param name="FileUpload">The file upload settings for messenger.</param>
    /// <param name="Apps">The apps embedded in the messenger.</param>
    /// <param name="HomeScreen">The homescreen settings for messenger.</param>
    /// <param name="SessionPersistenceType">The session persistence type for messenger.</param>
    public MessengerSettings(bool? Enabled = null, MessengerStyles Styles = null, LauncherButtonSettings LauncherButton = null, FileUploadSettings FileUpload = null, MessengerApps Apps = null, MessengerHomeScreen HomeScreen = null, SessionPersistenceTypeEnum? SessionPersistenceType = null)
    {
        this.Enabled = Enabled;
        this.Styles = Styles;
        this.LauncherButton = LauncherButton;
        this.FileUpload = FileUpload;
        this.Apps = Apps;
        this.HomeScreen = HomeScreen;
        this.SessionPersistenceType = SessionPersistenceType;

    }



    /// <summary>
    /// Whether or not messenger is enabled
    /// </summary>
    /// <value>Whether or not messenger is enabled</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The style settings for messenger
    /// </summary>
    /// <value>The style settings for messenger</value>
    [JsonPropertyName("styles")]
    public MessengerStyles Styles { get; set; }



    /// <summary>
    /// The launcher button settings for messenger
    /// </summary>
    /// <value>The launcher button settings for messenger</value>
    [JsonPropertyName("launcherButton")]
    public LauncherButtonSettings LauncherButton { get; set; }



    /// <summary>
    /// The file upload settings for messenger
    /// </summary>
    /// <value>The file upload settings for messenger</value>
    [JsonPropertyName("fileUpload")]
    public FileUploadSettings FileUpload { get; set; }



    /// <summary>
    /// The apps embedded in the messenger
    /// </summary>
    /// <value>The apps embedded in the messenger</value>
    [JsonPropertyName("apps")]
    public MessengerApps Apps { get; set; }



    /// <summary>
    /// The homescreen settings for messenger
    /// </summary>
    /// <value>The homescreen settings for messenger</value>
    [JsonPropertyName("homeScreen")]
    public MessengerHomeScreen HomeScreen { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessengerSettings {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Styles: ").Append(Styles).Append("\n");
        sb.Append("  LauncherButton: ").Append(LauncherButton).Append("\n");
        sb.Append("  FileUpload: ").Append(FileUpload).Append("\n");
        sb.Append("  Apps: ").Append(Apps).Append("\n");
        sb.Append("  HomeScreen: ").Append(HomeScreen).Append("\n");
        sb.Append("  SessionPersistenceType: ").Append(SessionPersistenceType).Append("\n");
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
        return Equals(obj as MessengerSettings);
    }

    /// <summary>
    /// Returns true if MessengerSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of MessengerSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessengerSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Styles == other.Styles ||
                Styles != null &&
                Styles.Equals(other.Styles)
            ) &&
            (
                LauncherButton == other.LauncherButton ||
                LauncherButton != null &&
                LauncherButton.Equals(other.LauncherButton)
            ) &&
            (
                FileUpload == other.FileUpload ||
                FileUpload != null &&
                FileUpload.Equals(other.FileUpload)
            ) &&
            (
                Apps == other.Apps ||
                Apps != null &&
                Apps.Equals(other.Apps)
            ) &&
            (
                HomeScreen == other.HomeScreen ||
                HomeScreen != null &&
                HomeScreen.Equals(other.HomeScreen)
            ) &&
            (
                SessionPersistenceType == other.SessionPersistenceType ||
                SessionPersistenceType != null &&
                SessionPersistenceType.Equals(other.SessionPersistenceType)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Styles != null)
            {
                hash = hash * 59 + Styles.GetHashCode();
            }

            if (LauncherButton != null)
            {
                hash = hash * 59 + LauncherButton.GetHashCode();
            }

            if (FileUpload != null)
            {
                hash = hash * 59 + FileUpload.GetHashCode();
            }

            if (Apps != null)
            {
                hash = hash * 59 + Apps.GetHashCode();
            }

            if (HomeScreen != null)
            {
                hash = hash * 59 + HomeScreen.GetHashCode();
            }

            if (SessionPersistenceType != null)
            {
                hash = hash * 59 + SessionPersistenceType.GetHashCode();
            }

            return hash;
        }
    }
}
