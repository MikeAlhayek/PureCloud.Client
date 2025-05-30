using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Effective Configuration for an ClientApp. This is comprised of the integration specific configuration along with overrides specified in the integration type.
/// </summary>

public partial class EffectiveConfiguration : IEquatable<EffectiveConfiguration>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EffectiveConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EffectiveConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EffectiveConfiguration" /> class.
    /// </summary>
    /// <param name="Properties">Key-value configuration settings described by the schema in the propertiesSchemaUri field. (required).</param>
    /// <param name="Advanced">Advanced configuration described by the schema in the advancedSchemaUri field. (required).</param>
    /// <param name="Name">The name of the integration, used to distinguish this integration from others of the same type. (required).</param>
    /// <param name="Notes">Notes about the integration. (required).</param>
    /// <param name="Credentials">Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type (required).</param>
    public EffectiveConfiguration(Dictionary<string, object> Properties = null, Dictionary<string, object> Advanced = null, string Name = null, string Notes = null, Dictionary<string, CredentialInfo> Credentials = null)
    {
        this.Properties = Properties;
        this.Advanced = Advanced;
        this.Name = Name;
        this.Notes = Notes;
        this.Credentials = Credentials;

    }



    /// <summary>
    /// Key-value configuration settings described by the schema in the propertiesSchemaUri field.
    /// </summary>
    /// <value>Key-value configuration settings described by the schema in the propertiesSchemaUri field.</value>
    [JsonPropertyName("properties")]
    public Dictionary<string, object> Properties { get; set; }



    /// <summary>
    /// Advanced configuration described by the schema in the advancedSchemaUri field.
    /// </summary>
    /// <value>Advanced configuration described by the schema in the advancedSchemaUri field.</value>
    [JsonPropertyName("advanced")]
    public Dictionary<string, object> Advanced { get; set; }



    /// <summary>
    /// The name of the integration, used to distinguish this integration from others of the same type.
    /// </summary>
    /// <value>The name of the integration, used to distinguish this integration from others of the same type.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EffectiveConfiguration {\n");

        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  Advanced: ").Append(Advanced).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  Credentials: ").Append(Credentials).Append("\n");
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
        return Equals(obj as EffectiveConfiguration);
    }

    /// <summary>
    /// Returns true if EffectiveConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of EffectiveConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EffectiveConfiguration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
            ) &&
            (
                Advanced == other.Advanced ||
                Advanced != null &&
                Advanced.SequenceEqual(other.Advanced)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (Advanced != null)
            {
                hash = hash * 59 + Advanced.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (Credentials != null)
            {
                hash = hash * 59 + Credentials.GetHashCode();
            }

            return hash;
        }
    }
}
