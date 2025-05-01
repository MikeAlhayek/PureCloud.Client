using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// AggregationRange
/// </summary>
[DataContract]
public partial class AggregationRange : IEquatable<AggregationRange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AggregationRange" /> class.
    /// </summary>
    /// <param name="Gte">Greater than or equal to.</param>
    /// <param name="Lt">Less than.</param>
    public AggregationRange(double? Gte = null, double? Lt = null)
    {
        this.Gte = Gte;
        this.Lt = Lt;

    }



    /// <summary>
    /// Greater than or equal to
    /// </summary>
    /// <value>Greater than or equal to</value>
    [DataMember(Name = "gte", EmitDefaultValue = false)]
    public double? Gte { get; set; }



    /// <summary>
    /// Less than
    /// </summary>
    /// <value>Less than</value>
    [DataMember(Name = "lt", EmitDefaultValue = false)]
    public double? Lt { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AggregationRange {\n");

        sb.Append("  Gte: ").Append(Gte).Append("\n");
        sb.Append("  Lt: ").Append(Lt).Append("\n");
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
        return Equals(obj as AggregationRange);
    }

    /// <summary>
    /// Returns true if AggregationRange instances are equal
    /// </summary>
    /// <param name="other">Instance of AggregationRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AggregationRange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Gte == other.Gte ||
                Gte != null &&
                Gte.Equals(other.Gte)
            ) &&
            (
                Lt == other.Lt ||
                Lt != null &&
                Lt.Equals(other.Lt)
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
            if (Gte != null)
            {
                hash = hash * 59 + Gte.GetHashCode();
            }

            if (Lt != null)
            {
                hash = hash * 59 + Lt.GetHashCode();
            }

            return hash;
        }
    }
}
