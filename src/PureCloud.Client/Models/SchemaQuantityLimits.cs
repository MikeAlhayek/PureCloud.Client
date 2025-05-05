using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SchemaQuantityLimits
/// </summary>

public partial class SchemaQuantityLimits : IEquatable<SchemaQuantityLimits>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SchemaQuantityLimits" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    public SchemaQuantityLimits(string Name = null)
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
    /// The minimum number of schema field name characters allowed.
    /// </summary>
    /// <value>The minimum number of schema field name characters allowed.</value>
    [JsonPropertyName("minFieldNameCharacters")]
    public int? MinFieldNameCharacters { get; private set; }



    /// <summary>
    /// The maximum number of schema field name characters allowed.
    /// </summary>
    /// <value>The maximum number of schema field name characters allowed.</value>
    [JsonPropertyName("maxFieldNameCharacters")]
    public int? MaxFieldNameCharacters { get; private set; }



    /// <summary>
    /// The minimum number of schema field description characters allowed.
    /// </summary>
    /// <value>The minimum number of schema field description characters allowed.</value>
    [JsonPropertyName("minFieldDescriptionCharacters")]
    public int? MinFieldDescriptionCharacters { get; private set; }



    /// <summary>
    /// The maximum number of schema field description characters allowed.
    /// </summary>
    /// <value>The maximum number of schema field description characters allowed.</value>
    [JsonPropertyName("maxFieldDescriptionCharacters")]
    public int? MaxFieldDescriptionCharacters { get; private set; }



    /// <summary>
    /// The minimum number of schema name characters allowed.
    /// </summary>
    /// <value>The minimum number of schema name characters allowed.</value>
    [JsonPropertyName("minSchemaNameCharacters")]
    public int? MinSchemaNameCharacters { get; private set; }



    /// <summary>
    /// The maximum number of schema name characters allowed.
    /// </summary>
    /// <value>The maximum number of schema name characters allowed.</value>
    [JsonPropertyName("maxSchemaNameCharacters")]
    public int? MaxSchemaNameCharacters { get; private set; }



    /// <summary>
    /// The minimum number of schema description characters allowed.
    /// </summary>
    /// <value>The minimum number of schema description characters allowed.</value>
    [JsonPropertyName("minSchemaDescriptionCharacters")]
    public int? MinSchemaDescriptionCharacters { get; private set; }



    /// <summary>
    /// The maximum number of schema description characters allowed.
    /// </summary>
    /// <value>The maximum number of schema description characters allowed.</value>
    [JsonPropertyName("maxSchemaDescriptionCharacters")]
    public int? MaxSchemaDescriptionCharacters { get; private set; }



    /// <summary>
    /// The maximum number of schema allowed per org.
    /// </summary>
    /// <value>The maximum number of schema allowed per org.</value>
    [JsonPropertyName("maxNumberOfSchemasPerOrg")]
    public int? MaxNumberOfSchemasPerOrg { get; private set; }



    /// <summary>
    /// The maximum number of schema fields allowed per schema.
    /// </summary>
    /// <value>The maximum number of schema fields allowed per schema.</value>
    [JsonPropertyName("maxNumberOfFieldsPerSchema")]
    public int? MaxNumberOfFieldsPerSchema { get; private set; }



    /// <summary>
    /// The maximum number of schema fields allowed per organization across all of their schemas.
    /// </summary>
    /// <value>The maximum number of schema fields allowed per organization across all of their schemas.</value>
    [JsonPropertyName("maxNumberOfFieldsPerOrg")]
    public int? MaxNumberOfFieldsPerOrg { get; private set; }



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
        sb.Append("class SchemaQuantityLimits {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MinFieldNameCharacters: ").Append(MinFieldNameCharacters).Append("\n");
        sb.Append("  MaxFieldNameCharacters: ").Append(MaxFieldNameCharacters).Append("\n");
        sb.Append("  MinFieldDescriptionCharacters: ").Append(MinFieldDescriptionCharacters).Append("\n");
        sb.Append("  MaxFieldDescriptionCharacters: ").Append(MaxFieldDescriptionCharacters).Append("\n");
        sb.Append("  MinSchemaNameCharacters: ").Append(MinSchemaNameCharacters).Append("\n");
        sb.Append("  MaxSchemaNameCharacters: ").Append(MaxSchemaNameCharacters).Append("\n");
        sb.Append("  MinSchemaDescriptionCharacters: ").Append(MinSchemaDescriptionCharacters).Append("\n");
        sb.Append("  MaxSchemaDescriptionCharacters: ").Append(MaxSchemaDescriptionCharacters).Append("\n");
        sb.Append("  MaxNumberOfSchemasPerOrg: ").Append(MaxNumberOfSchemasPerOrg).Append("\n");
        sb.Append("  MaxNumberOfFieldsPerSchema: ").Append(MaxNumberOfFieldsPerSchema).Append("\n");
        sb.Append("  MaxNumberOfFieldsPerOrg: ").Append(MaxNumberOfFieldsPerOrg).Append("\n");
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
        return Equals(obj as SchemaQuantityLimits);
    }

    /// <summary>
    /// Returns true if SchemaQuantityLimits instances are equal
    /// </summary>
    /// <param name="other">Instance of SchemaQuantityLimits to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SchemaQuantityLimits other)
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
                MinFieldNameCharacters == other.MinFieldNameCharacters ||
                MinFieldNameCharacters != null &&
                MinFieldNameCharacters.Equals(other.MinFieldNameCharacters)
            ) &&
            (
                MaxFieldNameCharacters == other.MaxFieldNameCharacters ||
                MaxFieldNameCharacters != null &&
                MaxFieldNameCharacters.Equals(other.MaxFieldNameCharacters)
            ) &&
            (
                MinFieldDescriptionCharacters == other.MinFieldDescriptionCharacters ||
                MinFieldDescriptionCharacters != null &&
                MinFieldDescriptionCharacters.Equals(other.MinFieldDescriptionCharacters)
            ) &&
            (
                MaxFieldDescriptionCharacters == other.MaxFieldDescriptionCharacters ||
                MaxFieldDescriptionCharacters != null &&
                MaxFieldDescriptionCharacters.Equals(other.MaxFieldDescriptionCharacters)
            ) &&
            (
                MinSchemaNameCharacters == other.MinSchemaNameCharacters ||
                MinSchemaNameCharacters != null &&
                MinSchemaNameCharacters.Equals(other.MinSchemaNameCharacters)
            ) &&
            (
                MaxSchemaNameCharacters == other.MaxSchemaNameCharacters ||
                MaxSchemaNameCharacters != null &&
                MaxSchemaNameCharacters.Equals(other.MaxSchemaNameCharacters)
            ) &&
            (
                MinSchemaDescriptionCharacters == other.MinSchemaDescriptionCharacters ||
                MinSchemaDescriptionCharacters != null &&
                MinSchemaDescriptionCharacters.Equals(other.MinSchemaDescriptionCharacters)
            ) &&
            (
                MaxSchemaDescriptionCharacters == other.MaxSchemaDescriptionCharacters ||
                MaxSchemaDescriptionCharacters != null &&
                MaxSchemaDescriptionCharacters.Equals(other.MaxSchemaDescriptionCharacters)
            ) &&
            (
                MaxNumberOfSchemasPerOrg == other.MaxNumberOfSchemasPerOrg ||
                MaxNumberOfSchemasPerOrg != null &&
                MaxNumberOfSchemasPerOrg.Equals(other.MaxNumberOfSchemasPerOrg)
            ) &&
            (
                MaxNumberOfFieldsPerSchema == other.MaxNumberOfFieldsPerSchema ||
                MaxNumberOfFieldsPerSchema != null &&
                MaxNumberOfFieldsPerSchema.Equals(other.MaxNumberOfFieldsPerSchema)
            ) &&
            (
                MaxNumberOfFieldsPerOrg == other.MaxNumberOfFieldsPerOrg ||
                MaxNumberOfFieldsPerOrg != null &&
                MaxNumberOfFieldsPerOrg.Equals(other.MaxNumberOfFieldsPerOrg)
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

            if (MinFieldNameCharacters != null)
            {
                hash = hash * 59 + MinFieldNameCharacters.GetHashCode();
            }

            if (MaxFieldNameCharacters != null)
            {
                hash = hash * 59 + MaxFieldNameCharacters.GetHashCode();
            }

            if (MinFieldDescriptionCharacters != null)
            {
                hash = hash * 59 + MinFieldDescriptionCharacters.GetHashCode();
            }

            if (MaxFieldDescriptionCharacters != null)
            {
                hash = hash * 59 + MaxFieldDescriptionCharacters.GetHashCode();
            }

            if (MinSchemaNameCharacters != null)
            {
                hash = hash * 59 + MinSchemaNameCharacters.GetHashCode();
            }

            if (MaxSchemaNameCharacters != null)
            {
                hash = hash * 59 + MaxSchemaNameCharacters.GetHashCode();
            }

            if (MinSchemaDescriptionCharacters != null)
            {
                hash = hash * 59 + MinSchemaDescriptionCharacters.GetHashCode();
            }

            if (MaxSchemaDescriptionCharacters != null)
            {
                hash = hash * 59 + MaxSchemaDescriptionCharacters.GetHashCode();
            }

            if (MaxNumberOfSchemasPerOrg != null)
            {
                hash = hash * 59 + MaxNumberOfSchemasPerOrg.GetHashCode();
            }

            if (MaxNumberOfFieldsPerSchema != null)
            {
                hash = hash * 59 + MaxNumberOfFieldsPerSchema.GetHashCode();
            }

            if (MaxNumberOfFieldsPerOrg != null)
            {
                hash = hash * 59 + MaxNumberOfFieldsPerOrg.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
