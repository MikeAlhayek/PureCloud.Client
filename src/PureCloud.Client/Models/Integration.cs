using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details for an Integration
/// </summary>

public partial class Integration : IEquatable<Integration>
{
    /// <summary>
    /// Configured state of the integration.
    /// </summary>
    /// <value>Configured state of the integration.</value>
    
    public enum IntendedStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Enabled for "ENABLED"
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        Enabled,

        /// <summary>
        /// Enum Disabled for "DISABLED"
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        Disabled,

        /// <summary>
        /// Enum Deleted for "DELETED"
        /// </summary>
        [EnumMember(Value = "DELETED")]
        Deleted,

        /// <summary>
        /// Enum Restored for "RESTORED"
        /// </summary>
        [EnumMember(Value = "RESTORED")]
        Restored
    }
    /// <summary>
    /// Configured state of the integration.
    /// </summary>
    /// <value>Configured state of the integration.</value>
    [JsonPropertyName("intendedState")]
    public IntendedStateEnum? IntendedState { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Integration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Integration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Integration" /> class.
    /// </summary>
    /// <param name="IntendedState">Configured state of the integration. (required).</param>
    public Integration(IntendedStateEnum? IntendedState = null)
    {
        this.IntendedState = IntendedState;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the integration, used to distinguish this integration from others of the same type.
    /// </summary>
    /// <value>The name of the integration, used to distinguish this integration from others of the same type.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Type of the integration
    /// </summary>
    /// <value>Type of the integration</value>
    [JsonPropertyName("integrationType")]
    public IntegrationType IntegrationType { get; set; }



    /// <summary>
    /// Notes about the integration.
    /// </summary>
    /// <value>Notes about the integration.</value>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }





    /// <summary>
    /// Configuration information for the integration.
    /// </summary>
    /// <value>Configuration information for the integration.</value>
    [JsonPropertyName("config")]
    public IntegrationConfigurationInfo Config { get; set; }



    /// <summary>
    /// Last reported status of the integration.
    /// </summary>
    /// <value>Last reported status of the integration.</value>
    [JsonPropertyName("reportedState")]
    public IntegrationStatusInfo ReportedState { get; set; }



    /// <summary>
    /// Read-only attributes for the integration.
    /// </summary>
    /// <value>Read-only attributes for the integration.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Integration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IntegrationType: ").Append(IntegrationType).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  IntendedState: ").Append(IntendedState).Append("\n");
        sb.Append("  Config: ").Append(Config).Append("\n");
        sb.Append("  ReportedState: ").Append(ReportedState).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
        return Equals(obj as Integration);
    }

    /// <summary>
    /// Returns true if Integration instances are equal
    /// </summary>
    /// <param name="other">Instance of Integration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Integration other)
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
                IntegrationType == other.IntegrationType ||
                IntegrationType != null &&
                IntegrationType.Equals(other.IntegrationType)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                IntendedState == other.IntendedState ||
                IntendedState != null &&
                IntendedState.Equals(other.IntendedState)
            ) &&
            (
                Config == other.Config ||
                Config != null &&
                Config.Equals(other.Config)
            ) &&
            (
                ReportedState == other.ReportedState ||
                ReportedState != null &&
                ReportedState.Equals(other.ReportedState)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
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

            if (IntegrationType != null)
            {
                hash = hash * 59 + IntegrationType.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (IntendedState != null)
            {
                hash = hash * 59 + IntendedState.GetHashCode();
            }

            if (Config != null)
            {
                hash = hash * 59 + Config.GetHashCode();
            }

            if (ReportedState != null)
            {
                hash = hash * 59 + ReportedState.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
