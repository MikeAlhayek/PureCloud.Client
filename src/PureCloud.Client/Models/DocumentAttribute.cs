using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentAttribute
/// </summary>

public partial class DocumentAttribute : IEquatable<DocumentAttribute>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentAttribute" /> class.
    /// </summary>
    /// <param name="Attribute">Attribute.</param>
    /// <param name="Values">Values.</param>
    public DocumentAttribute(Models.Attribute Attribute = null, List<string> Values = null)
    {
        this.Attribute = Attribute;
        this.Values = Values;

    }

    /// <summary>
    /// Gets or Sets Attribute
    /// </summary>
    [JsonPropertyName("attribute")]
    public Models.Attribute Attribute { get; set; }

    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentAttribute {\n");

        sb.Append("  Attribute: ").Append(Attribute).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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
        return Equals(obj as DocumentAttribute);
    }

    /// <summary>
    /// Returns true if DocumentAttribute instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentAttribute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentAttribute other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Attribute == other.Attribute ||
                Attribute != null &&
                Attribute.Equals(other.Attribute)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
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
            if (Attribute != null)
            {
                hash = hash * 59 + Attribute.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
