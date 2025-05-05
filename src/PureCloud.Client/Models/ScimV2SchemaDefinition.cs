using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM schema.
/// </summary>

public partial class ScimV2SchemaDefinition : IEquatable<ScimV2SchemaDefinition>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2SchemaDefinition" /> class.
    /// </summary>
    public ScimV2SchemaDefinition()
    {

    }



    /// <summary>
    /// The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.
    /// </summary>
    /// <value>The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the schema.
    /// </summary>
    /// <value>The name of the schema.</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// The description of the schema.
    /// </summary>
    /// <value>The description of the schema.</value>
    [JsonPropertyName("description")]
    public string Description { get; private set; }



    /// <summary>
    /// The list of service provider attributes.
    /// </summary>
    /// <value>The list of service provider attributes.</value>
    [JsonPropertyName("attributes")]
    public List<ScimV2SchemaAttribute> Attributes { get; private set; }



    /// <summary>
    /// The metadata of the SCIM resource. Only \&quot;location\&quot; and \&quot;resourceType\&quot; are set for \&quot;Schema\&quot; resources.
    /// </summary>
    /// <value>The metadata of the SCIM resource. Only \&quot;location\&quot; and \&quot;resourceType\&quot; are set for \&quot;Schema\&quot; resources.</value>
    [JsonPropertyName("meta")]
    public ScimMetadata Meta { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimV2SchemaDefinition {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Meta: ").Append(Meta).Append("\n");
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
        return Equals(obj as ScimV2SchemaDefinition);
    }

    /// <summary>
    /// Returns true if ScimV2SchemaDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2SchemaDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimV2SchemaDefinition other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                Meta == other.Meta ||
                Meta != null &&
                Meta.Equals(other.Meta)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (Meta != null)
            {
                hash = hash * 59 + Meta.GetHashCode();
            }

            return hash;
        }
    }
}
