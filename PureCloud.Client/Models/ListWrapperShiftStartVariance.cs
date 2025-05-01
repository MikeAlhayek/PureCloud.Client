using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ListWrapperShiftStartVariance
/// </summary>
[DataContract]
public partial class ListWrapperShiftStartVariance : IEquatable<ListWrapperShiftStartVariance>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ListWrapperShiftStartVariance" /> class.
    /// </summary>
    /// <param name="Values">Values.</param>
    public ListWrapperShiftStartVariance(List<ShiftStartVariance> Values = null)
    {
        this.Values = Values;

    }



    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<ShiftStartVariance> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ListWrapperShiftStartVariance {\n");

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
        return this.Equals(obj as ListWrapperShiftStartVariance);
    }

    /// <summary>
    /// Returns true if ListWrapperShiftStartVariance instances are equal
    /// </summary>
    /// <param name="other">Instance of ListWrapperShiftStartVariance to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ListWrapperShiftStartVariance other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Values == other.Values ||
                this.Values != null &&
                this.Values.SequenceEqual(other.Values)
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
            if (this.Values != null)
            {
                hash = hash * 59 + this.Values.GetHashCode();
            }

            return hash;
        }
    }
}
