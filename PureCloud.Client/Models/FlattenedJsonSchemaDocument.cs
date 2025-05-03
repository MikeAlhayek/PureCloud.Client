using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JSON schema that defines the transformed result that will be sent back to the caller. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned.
/// </summary>

public partial class FlattenedJsonSchemaDocument : IEquatable<FlattenedJsonSchemaDocument>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlattenedJsonSchemaDocument" /> class.
    /// </summary>
    /// <param name="Schema">Schema.</param>
    /// <param name="ArrayProperties">Properties in the original document that were arrays.</param>
    public FlattenedJsonSchemaDocument(JsonSchemaDocument Schema = null, List<string> ArrayProperties = null)
    {
        this.Schema = Schema;
        this.ArrayProperties = ArrayProperties;

    }



    /// <summary>
    /// Gets or Sets Schema
    /// </summary>
    [JsonPropertyName("schema")]
    public JsonSchemaDocument Schema { get; set; }



    /// <summary>
    /// Properties in the original document that were arrays
    /// </summary>
    /// <value>Properties in the original document that were arrays</value>
    [JsonPropertyName("arrayProperties")]
    public List<string> ArrayProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlattenedJsonSchemaDocument {\n");

        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  ArrayProperties: ").Append(ArrayProperties).Append("\n");
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
        return Equals(obj as FlattenedJsonSchemaDocument);
    }

    /// <summary>
    /// Returns true if FlattenedJsonSchemaDocument instances are equal
    /// </summary>
    /// <param name="other">Instance of FlattenedJsonSchemaDocument to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlattenedJsonSchemaDocument other)
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
                ArrayProperties == other.ArrayProperties ||
                ArrayProperties != null &&
                ArrayProperties.SequenceEqual(other.ArrayProperties)
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

            if (ArrayProperties != null)
            {
                hash = hash * 59 + ArrayProperties.GetHashCode();
            }

            return hash;
        }
    }
}
