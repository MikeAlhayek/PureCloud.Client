using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValidationLimits
/// </summary>

public partial class ValidationLimits : IEquatable<ValidationLimits>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationLimits" /> class.
    /// </summary>
    /// <param name="MinLength">MinLength.</param>
    /// <param name="MaxLength">MaxLength.</param>
    /// <param name="MinItems">MinItems.</param>
    /// <param name="MaxItems">MaxItems.</param>
    /// <param name="Minimum">Minimum.</param>
    /// <param name="Maximum">Maximum.</param>
    public ValidationLimits(MinLength MinLength = null, MaxLength MaxLength = null, MinLength MinItems = null, MaxLength MaxItems = null, MinLength Minimum = null, MaxLength Maximum = null)
    {
        this.MinLength = MinLength;
        this.MaxLength = MaxLength;
        this.MinItems = MinItems;
        this.MaxItems = MaxItems;
        this.Minimum = Minimum;
        this.Maximum = Maximum;

    }



    /// <summary>
    /// Gets or Sets MinLength
    /// </summary>
    [JsonPropertyName("minLength")]
    public MinLength MinLength { get; set; }



    /// <summary>
    /// Gets or Sets MaxLength
    /// </summary>
    [JsonPropertyName("maxLength")]
    public MaxLength MaxLength { get; set; }



    /// <summary>
    /// Gets or Sets MinItems
    /// </summary>
    [JsonPropertyName("minItems")]
    public MinLength MinItems { get; set; }



    /// <summary>
    /// Gets or Sets MaxItems
    /// </summary>
    [JsonPropertyName("maxItems")]
    public MaxLength MaxItems { get; set; }



    /// <summary>
    /// Gets or Sets Minimum
    /// </summary>
    [JsonPropertyName("minimum")]
    public MinLength Minimum { get; set; }



    /// <summary>
    /// Gets or Sets Maximum
    /// </summary>
    [JsonPropertyName("maximum")]
    public MaxLength Maximum { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValidationLimits {\n");

        sb.Append("  MinLength: ").Append(MinLength).Append("\n");
        sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
        sb.Append("  MinItems: ").Append(MinItems).Append("\n");
        sb.Append("  MaxItems: ").Append(MaxItems).Append("\n");
        sb.Append("  Minimum: ").Append(Minimum).Append("\n");
        sb.Append("  Maximum: ").Append(Maximum).Append("\n");
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
        return Equals(obj as ValidationLimits);
    }

    /// <summary>
    /// Returns true if ValidationLimits instances are equal
    /// </summary>
    /// <param name="other">Instance of ValidationLimits to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValidationLimits other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MinLength == other.MinLength ||
                MinLength != null &&
                MinLength.Equals(other.MinLength)
            ) &&
            (
                MaxLength == other.MaxLength ||
                MaxLength != null &&
                MaxLength.Equals(other.MaxLength)
            ) &&
            (
                MinItems == other.MinItems ||
                MinItems != null &&
                MinItems.Equals(other.MinItems)
            ) &&
            (
                MaxItems == other.MaxItems ||
                MaxItems != null &&
                MaxItems.Equals(other.MaxItems)
            ) &&
            (
                Minimum == other.Minimum ||
                Minimum != null &&
                Minimum.Equals(other.Minimum)
            ) &&
            (
                Maximum == other.Maximum ||
                Maximum != null &&
                Maximum.Equals(other.Maximum)
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
            if (MinLength != null)
            {
                hash = hash * 59 + MinLength.GetHashCode();
            }

            if (MaxLength != null)
            {
                hash = hash * 59 + MaxLength.GetHashCode();
            }

            if (MinItems != null)
            {
                hash = hash * 59 + MinItems.GetHashCode();
            }

            if (MaxItems != null)
            {
                hash = hash * 59 + MaxItems.GetHashCode();
            }

            if (Minimum != null)
            {
                hash = hash * 59 + Minimum.GetHashCode();
            }

            if (Maximum != null)
            {
                hash = hash * 59 + Maximum.GetHashCode();
            }

            return hash;
        }
    }
}
