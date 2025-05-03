using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MaxLength
/// </summary>

public partial class MaxLength : IEquatable<MaxLength>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MaxLength" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MaxLength() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MaxLength" /> class.
    /// </summary>
    /// <param name="Min">A non-negative integer for a text-based schema field denoting the minimum largest length string the field can contain for a schema instance. (required).</param>
    /// <param name="Max">A non-negative integer for a text-based schema field denoting the maximum largest string the field can contain for a schema instance. (required).</param>
    public MaxLength(long? Min = null, long? Max = null)
    {
        this.Min = Min;
        this.Max = Max;

    }



    /// <summary>
    /// A non-negative integer for a text-based schema field denoting the minimum largest length string the field can contain for a schema instance.
    /// </summary>
    /// <value>A non-negative integer for a text-based schema field denoting the minimum largest length string the field can contain for a schema instance.</value>
    [JsonPropertyName("min")]
    public long? Min { get; set; }



    /// <summary>
    /// A non-negative integer for a text-based schema field denoting the maximum largest string the field can contain for a schema instance.
    /// </summary>
    /// <value>A non-negative integer for a text-based schema field denoting the maximum largest string the field can contain for a schema instance.</value>
    [JsonPropertyName("max")]
    public long? Max { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MaxLength {\n");

        sb.Append("  Min: ").Append(Min).Append("\n");
        sb.Append("  Max: ").Append(Max).Append("\n");
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
        return Equals(obj as MaxLength);
    }

    /// <summary>
    /// Returns true if MaxLength instances are equal
    /// </summary>
    /// <param name="other">Instance of MaxLength to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MaxLength other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Min == other.Min ||
                Min != null &&
                Min.Equals(other.Min)
            ) &&
            (
                Max == other.Max ||
                Max != null &&
                Max.Equals(other.Max)
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
            if (Min != null)
            {
                hash = hash * 59 + Min.GetHashCode();
            }

            if (Max != null)
            {
                hash = hash * 59 + Max.GetHashCode();
            }

            return hash;
        }
    }
}
