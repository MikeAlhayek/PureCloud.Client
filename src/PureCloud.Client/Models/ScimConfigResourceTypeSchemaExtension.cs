using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM resource type&#39;s schema extension.
/// </summary>

public partial class ScimConfigResourceTypeSchemaExtension : IEquatable<ScimConfigResourceTypeSchemaExtension>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimConfigResourceTypeSchemaExtension" /> class.
    /// </summary>
    public ScimConfigResourceTypeSchemaExtension()
    {

    }



    /// <summary>
    /// The URI of an extended schema, for example, \&quot;urn:edu:2.0:Staff\&quot;. Must be equal to the \&quot;id\&quot; attribute of a schema.
    /// </summary>
    /// <value>The URI of an extended schema, for example, \&quot;urn:edu:2.0:Staff\&quot;. Must be equal to the \&quot;id\&quot; attribute of a schema.</value>
    [JsonPropertyName("schema")]
    public string Schema { get; set; }



    /// <summary>
    /// Indicates whether a schema extension is required.
    /// </summary>
    /// <value>Indicates whether a schema extension is required.</value>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimConfigResourceTypeSchemaExtension {\n");

        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  Required: ").Append(Required).Append("\n");
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
        return Equals(obj as ScimConfigResourceTypeSchemaExtension);
    }

    /// <summary>
    /// Returns true if ScimConfigResourceTypeSchemaExtension instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimConfigResourceTypeSchemaExtension to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimConfigResourceTypeSchemaExtension other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Schema == other.Schema ||
                Schema != null &&
                Schema.Equals(other.Schema)
            ) &&
            (
                Required == other.Required ||
                Required != null &&
                Required.Equals(other.Required)
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
            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (Required != null)
            {
                hash = hash * 59 + Required.GetHashCode();
            }

            return hash;
        }
    }
}
