using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Configuration for an Integration
/// </summary>

public partial class IntegrationConfiguration : IEquatable<IntegrationConfiguration>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="IntegrationConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected IntegrationConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IntegrationConfiguration" /> class.
    /// </summary>
    /// <param name="Name">The name of the integration, used to distinguish this integration from others of the same type. (required).</param>
    /// <param name="Version">Version number required for updates. (required).</param>
    /// <param name="Properties">Key-value configuration settings described by the schema in the propertiesSchemaUri field. (required).</param>
    /// <param name="Advanced">Advanced configuration described by the schema in the advancedSchemaUri field. (required).</param>
    /// <param name="Notes">Notes about the integration. (required).</param>
    /// <param name="Credentials">Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type (required).</param>
    public IntegrationConfiguration(string Name = null, int? Version = null, object Properties = null, object Advanced = null, string Notes = null, Dictionary<string, CredentialInfo> Credentials = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.Properties = Properties;
        this.Advanced = Advanced;
        this.Notes = Notes;
        this.Credentials = Credentials;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the integration, used to distinguish this integration from others of the same type.
    /// </summary>
    /// <value>The name of the integration, used to distinguish this integration from others of the same type.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Version number required for updates.
    /// </summary>
    /// <value>Version number required for updates.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// Key-value configuration settings described by the schema in the propertiesSchemaUri field.
    /// </summary>
    /// <value>Key-value configuration settings described by the schema in the propertiesSchemaUri field.</value>
    [JsonPropertyName("properties")]
    public object Properties { get; set; }



    /// <summary>
    /// Advanced configuration described by the schema in the advancedSchemaUri field.
    /// </summary>
    /// <value>Advanced configuration described by the schema in the advancedSchemaUri field.</value>
    [JsonPropertyName("advanced")]
    public object Advanced { get; set; }



    /// <summary>
    /// Notes about the integration.
    /// </summary>
    /// <value>Notes about the integration.</value>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }



    /// <summary>
    /// Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type
    /// </summary>
    /// <value>Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type</value>
    [JsonPropertyName("credentials")]
    public Dictionary<string, CredentialInfo> Credentials { get; set; }



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
        sb.Append("class IntegrationConfiguration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  Advanced: ").Append(Advanced).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  Credentials: ").Append(Credentials).Append("\n");
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
        return Equals(obj as IntegrationConfiguration);
    }

    /// <summary>
    /// Returns true if IntegrationConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of IntegrationConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IntegrationConfiguration other)
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
                Properties == other.Properties ||
                Properties != null &&
                Properties.Equals(other.Properties)
            ) &&
            (
                Advanced == other.Advanced ||
                Advanced != null &&
                Advanced.Equals(other.Advanced)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                Credentials == other.Credentials ||
                Credentials != null &&
                Credentials.SequenceEqual(other.Credentials)
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

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (Advanced != null)
            {
                hash = hash * 59 + Advanced.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (Credentials != null)
            {
                hash = hash * 59 + Credentials.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
