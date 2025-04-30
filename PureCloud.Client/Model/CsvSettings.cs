using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// CsvSettings
/// </summary>
[DataContract]
public partial class CsvSettings : IEquatable<CsvSettings>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CsvSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CsvSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CsvSettings" /> class.
    /// </summary>
    /// <param name="ExternalSettingsId">Id of the external settings.</param>
    /// <param name="Mappings">Mappings for the transformation (required).</param>
    public CsvSettings(string ExternalSettingsId = null, List<CsvMappingEntry> Mappings = null)
    {
        this.ExternalSettingsId = ExternalSettingsId;
        this.Mappings = Mappings;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Id of the external settings
    /// </summary>
    /// <value>Id of the external settings</value>
    [DataMember(Name = "externalSettingsId", EmitDefaultValue = false)]
    public string ExternalSettingsId { get; set; }



    /// <summary>
    /// Mappings for the transformation
    /// </summary>
    /// <value>Mappings for the transformation</value>
    [DataMember(Name = "mappings", EmitDefaultValue = false)]
    public List<CsvMappingEntry> Mappings { get; set; }



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
        sb.Append("class CsvSettings {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ExternalSettingsId: ").Append(ExternalSettingsId).Append("\n");
        sb.Append("  Mappings: ").Append(Mappings).Append("\n");
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
        return this.Equals(obj as CsvSettings);
    }

    /// <summary>
    /// Returns true if CsvSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of CsvSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CsvSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.ExternalSettingsId == other.ExternalSettingsId ||
                this.ExternalSettingsId != null &&
                this.ExternalSettingsId.Equals(other.ExternalSettingsId)
            ) &&
            (
                this.Mappings == other.Mappings ||
                this.Mappings != null &&
                this.Mappings.SequenceEqual(other.Mappings)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.ExternalSettingsId != null)
            {
                hash = hash * 59 + this.ExternalSettingsId.GetHashCode();
            }

            if (this.Mappings != null)
            {
                hash = hash * 59 + this.Mappings.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
