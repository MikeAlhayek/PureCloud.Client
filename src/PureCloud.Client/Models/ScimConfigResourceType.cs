using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM resource.
/// </summary>

public partial class ScimConfigResourceType : IEquatable<ScimConfigResourceType>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimConfigResourceType" /> class.
    /// </summary>
    public ScimConfigResourceType()
    {

    }



    /// <summary>
    /// The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.
    /// </summary>
    /// <value>The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    [JsonPropertyName("schemas")]
    public List<string> Schemas { get; private set; }



    /// <summary>
    /// The name of the resource type.
    /// </summary>
    /// <value>The name of the resource type.</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// The description of the resource type.
    /// </summary>
    /// <value>The description of the resource type.</value>
    [JsonPropertyName("description")]
    public string Description { get; private set; }



    /// <summary>
    /// The URI of the primary or base schema for the resource type.
    /// </summary>
    /// <value>The URI of the primary or base schema for the resource type.</value>
    [JsonPropertyName("schema")]
    public string Schema { get; private set; }



    /// <summary>
    /// The list of schema extensions for the resource type.
    /// </summary>
    /// <value>The list of schema extensions for the resource type.</value>
    [JsonPropertyName("schemaExtensions")]
    public List<ScimConfigResourceTypeSchemaExtension> SchemaExtensions { get; private set; }



    /// <summary>
    /// The HTTP-addressable endpoint of the resource type. Appears after the base URL.
    /// </summary>
    /// <value>The HTTP-addressable endpoint of the resource type. Appears after the base URL.</value>
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; private set; }



    /// <summary>
    /// The metadata of the SCIM resource. Only \&quot;location\&quot; and \&quot;resourceType\&quot; are set for \&quot;ResourceType\&quot; resources.
    /// </summary>
    /// <value>The metadata of the SCIM resource. Only \&quot;location\&quot; and \&quot;resourceType\&quot; are set for \&quot;ResourceType\&quot; resources.</value>
    [JsonPropertyName("meta")]
    public ScimMetadata Meta { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimConfigResourceType {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Schemas: ").Append(Schemas).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  SchemaExtensions: ").Append(SchemaExtensions).Append("\n");
        sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
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
        return Equals(obj as ScimConfigResourceType);
    }

    /// <summary>
    /// Returns true if ScimConfigResourceType instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimConfigResourceType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimConfigResourceType other)
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
                Schemas == other.Schemas ||
                Schemas != null &&
                Schemas.SequenceEqual(other.Schemas)
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
                Schema == other.Schema ||
                Schema != null &&
                Schema.Equals(other.Schema)
            ) &&
            (
                SchemaExtensions == other.SchemaExtensions ||
                SchemaExtensions != null &&
                SchemaExtensions.SequenceEqual(other.SchemaExtensions)
            ) &&
            (
                Endpoint == other.Endpoint ||
                Endpoint != null &&
                Endpoint.Equals(other.Endpoint)
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

            if (Schemas != null)
            {
                hash = hash * 59 + Schemas.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (SchemaExtensions != null)
            {
                hash = hash * 59 + SchemaExtensions.GetHashCode();
            }

            if (Endpoint != null)
            {
                hash = hash * 59 + Endpoint.GetHashCode();
            }

            if (Meta != null)
            {
                hash = hash * 59 + Meta.GetHashCode();
            }

            return hash;
        }
    }
}
