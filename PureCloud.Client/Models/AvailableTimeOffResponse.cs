using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// AvailableTimeOffResponse
/// </summary>
[DataContract]
public partial class AvailableTimeOffResponse : IEquatable<AvailableTimeOffResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AvailableTimeOffResponse" /> class.
    /// </summary>
    /// <param name="Values">Values.</param>
    public AvailableTimeOffResponse(List<AvailableTimeOffRange> Values = null)
    {
        this.Values = Values;

    }



    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<AvailableTimeOffRange> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AvailableTimeOffResponse {\n");

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
        return Equals(obj as AvailableTimeOffResponse);
    }

    /// <summary>
    /// Returns true if AvailableTimeOffResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AvailableTimeOffResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AvailableTimeOffResponse other)
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
