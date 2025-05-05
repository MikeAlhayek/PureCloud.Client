using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UC Integration UI configuration data
/// </summary>

public partial class UCIntegration : IEquatable<UCIntegration>
{
    /// <summary>
    /// integrationPresenceType
    /// </summary>
    /// <value>integrationPresenceType</value>
    
    public enum IntegrationPresenceSourceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Microsoftteams for "MicrosoftTeams"
        /// </summary>
        [EnumMember(Value = "MicrosoftTeams")]
        Microsoftteams,

        /// <summary>
        /// Enum Zoomphone for "ZoomPhone"
        /// </summary>
        [EnumMember(Value = "ZoomPhone")]
        Zoomphone,

        /// <summary>
        /// Enum Eightbyeight for "EightByEight"
        /// </summary>
        [EnumMember(Value = "EightByEight")]
        Eightbyeight
    }
    /// <summary>
    /// integrationPresenceType
    /// </summary>
    /// <value>integrationPresenceType</value>
    [JsonPropertyName("integrationPresenceSource")]
    public IntegrationPresenceSourceEnum? IntegrationPresenceSource { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UCIntegration" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    public UCIntegration(string Name = null)
    {
        this.Name = Name;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// ucIntegrationKey
    /// </summary>
    /// <value>ucIntegrationKey</value>
    [JsonPropertyName("ucIntegrationKey")]
    public string UcIntegrationKey { get; private set; }





    /// <summary>
    /// pbxPermission
    /// </summary>
    /// <value>pbxPermission</value>
    [JsonPropertyName("pbxPermission")]
    public string PbxPermission { get; private set; }



    /// <summary>
    /// icon
    /// </summary>
    /// <value>icon</value>
    [JsonPropertyName("icon")]
    public UCIcon Icon { get; private set; }



    /// <summary>
    /// badgeIcon
    /// </summary>
    /// <value>badgeIcon</value>
    [JsonPropertyName("badgeIcons")]
    public Dictionary<string, UCIcon> BadgeIcons { get; private set; }



    /// <summary>
    /// i10n
    /// </summary>
    /// <value>i10n</value>
    [JsonPropertyName("i10n")]
    public Dictionary<string, UCI10n> I10n { get; private set; }



    /// <summary>
    /// polledPresence
    /// </summary>
    /// <value>polledPresence</value>
    [JsonPropertyName("polledPresence")]
    public bool? PolledPresence { get; private set; }



    /// <summary>
    /// userPermissions
    /// </summary>
    /// <value>userPermissions</value>
    [JsonPropertyName("userPermissions")]
    public List<string> UserPermissions { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UCIntegration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UcIntegrationKey: ").Append(UcIntegrationKey).Append("\n");
        sb.Append("  IntegrationPresenceSource: ").Append(IntegrationPresenceSource).Append("\n");
        sb.Append("  PbxPermission: ").Append(PbxPermission).Append("\n");
        sb.Append("  Icon: ").Append(Icon).Append("\n");
        sb.Append("  BadgeIcons: ").Append(BadgeIcons).Append("\n");
        sb.Append("  I10n: ").Append(I10n).Append("\n");
        sb.Append("  PolledPresence: ").Append(PolledPresence).Append("\n");
        sb.Append("  UserPermissions: ").Append(UserPermissions).Append("\n");
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
        return Equals(obj as UCIntegration);
    }

    /// <summary>
    /// Returns true if UCIntegration instances are equal
    /// </summary>
    /// <param name="other">Instance of UCIntegration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UCIntegration other)
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
                UcIntegrationKey == other.UcIntegrationKey ||
                UcIntegrationKey != null &&
                UcIntegrationKey.Equals(other.UcIntegrationKey)
            ) &&
            (
                IntegrationPresenceSource == other.IntegrationPresenceSource ||
                IntegrationPresenceSource != null &&
                IntegrationPresenceSource.Equals(other.IntegrationPresenceSource)
            ) &&
            (
                PbxPermission == other.PbxPermission ||
                PbxPermission != null &&
                PbxPermission.Equals(other.PbxPermission)
            ) &&
            (
                Icon == other.Icon ||
                Icon != null &&
                Icon.Equals(other.Icon)
            ) &&
            (
                BadgeIcons == other.BadgeIcons ||
                BadgeIcons != null &&
                BadgeIcons.SequenceEqual(other.BadgeIcons)
            ) &&
            (
                I10n == other.I10n ||
                I10n != null &&
                I10n.SequenceEqual(other.I10n)
            ) &&
            (
                PolledPresence == other.PolledPresence ||
                PolledPresence != null &&
                PolledPresence.Equals(other.PolledPresence)
            ) &&
            (
                UserPermissions == other.UserPermissions ||
                UserPermissions != null &&
                UserPermissions.SequenceEqual(other.UserPermissions)
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

            if (UcIntegrationKey != null)
            {
                hash = hash * 59 + UcIntegrationKey.GetHashCode();
            }

            if (IntegrationPresenceSource != null)
            {
                hash = hash * 59 + IntegrationPresenceSource.GetHashCode();
            }

            if (PbxPermission != null)
            {
                hash = hash * 59 + PbxPermission.GetHashCode();
            }

            if (Icon != null)
            {
                hash = hash * 59 + Icon.GetHashCode();
            }

            if (BadgeIcons != null)
            {
                hash = hash * 59 + BadgeIcons.GetHashCode();
            }

            if (I10n != null)
            {
                hash = hash * 59 + I10n.GetHashCode();
            }

            if (PolledPresence != null)
            {
                hash = hash * 59 + PolledPresence.GetHashCode();
            }

            if (UserPermissions != null)
            {
                hash = hash * 59 + UserPermissions.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
