using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DetectedNamedEntityValue
/// </summary>

public partial class DetectedNamedEntityValue : IEquatable<DetectedNamedEntityValue>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DetectedNamedEntityValue" /> class.
    /// </summary>
    public DetectedNamedEntityValue()
    {

    }



    /// <summary>
    /// The raw value of the detected named entity.
    /// </summary>
    /// <value>The raw value of the detected named entity.</value>
    [JsonPropertyName("raw")]
    public string Raw { get; private set; }



    /// <summary>
    /// The resolved value of the detected named entity.
    /// </summary>
    /// <value>The resolved value of the detected named entity.</value>
    [JsonPropertyName("resolved")]
    public string Resolved { get; private set; }



    /// <summary>
    /// The unit of the detected amount of money entity, e.g. EUR, USD.
    /// </summary>
    /// <value>The unit of the detected amount of money entity, e.g. EUR, USD.</value>
    [JsonPropertyName("unit")]
    public string Unit { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DetectedNamedEntityValue {\n");

        sb.Append("  Raw: ").Append(Raw).Append("\n");
        sb.Append("  Resolved: ").Append(Resolved).Append("\n");
        sb.Append("  Unit: ").Append(Unit).Append("\n");
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
        return Equals(obj as DetectedNamedEntityValue);
    }

    /// <summary>
    /// Returns true if DetectedNamedEntityValue instances are equal
    /// </summary>
    /// <param name="other">Instance of DetectedNamedEntityValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DetectedNamedEntityValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Raw == other.Raw ||
                Raw != null &&
                Raw.Equals(other.Raw)
            ) &&
            (
                Resolved == other.Resolved ||
                Resolved != null &&
                Resolved.Equals(other.Resolved)
            ) &&
            (
                Unit == other.Unit ||
                Unit != null &&
                Unit.Equals(other.Unit)
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
            if (Raw != null)
            {
                hash = hash * 59 + Raw.GetHashCode();
            }

            if (Resolved != null)
            {
                hash = hash * 59 + Resolved.GetHashCode();
            }

            if (Unit != null)
            {
                hash = hash * 59 + Unit.GetHashCode();
            }

            return hash;
        }
    }
}
