using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MetadataAttribute
/// </summary>

public partial class MetadataAttribute : IEquatable<MetadataAttribute>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MetadataAttribute" /> class.
    /// </summary>
    public MetadataAttribute()
    {

    }



    /// <summary>
    /// The value of the metadata attribute.
    /// </summary>
    /// <value>The value of the metadata attribute.</value>
    [JsonPropertyName("value")]
    public string Value { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MetadataAttribute {\n");

        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as MetadataAttribute);
    }

    /// <summary>
    /// Returns true if MetadataAttribute instances are equal
    /// </summary>
    /// <param name="other">Instance of MetadataAttribute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MetadataAttribute other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
