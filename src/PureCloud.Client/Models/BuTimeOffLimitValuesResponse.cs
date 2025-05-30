using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuTimeOffLimitValuesResponse
/// </summary>

public partial class BuTimeOffLimitValuesResponse : IEquatable<BuTimeOffLimitValuesResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuTimeOffLimitValuesResponse" /> class.
    /// </summary>
    /// <param name="Values">Values.</param>
    public BuTimeOffLimitValuesResponse(List<BuTimeOffLimitValueRange> Values = null)
    {
        this.Values = Values;

    }



    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [JsonPropertyName("values")]
    public List<BuTimeOffLimitValueRange> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuTimeOffLimitValuesResponse {\n");

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
        return Equals(obj as BuTimeOffLimitValuesResponse);
    }

    /// <summary>
    /// Returns true if BuTimeOffLimitValuesResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuTimeOffLimitValuesResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuTimeOffLimitValuesResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
