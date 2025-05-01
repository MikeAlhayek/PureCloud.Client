using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// AggregationResultEntry
/// </summary>
[DataContract]
public partial class AggregationResultEntry : IEquatable<AggregationResultEntry>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AggregationResultEntry" /> class.
    /// </summary>
    /// <param name="Count">Count.</param>
    /// <param name="Value">For termFrequency aggregations.</param>
    /// <param name="Gte">For numericRange aggregations.</param>
    /// <param name="Lt">For numericRange aggregations.</param>
    public AggregationResultEntry(long? Count = null, string Value = null, double? Gte = null, double? Lt = null)
    {
        this.Count = Count;
        this.Value = Value;
        this.Gte = Gte;
        this.Lt = Lt;

    }



    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name = "count", EmitDefaultValue = false)]
    public long? Count { get; set; }



    /// <summary>
    /// For termFrequency aggregations
    /// </summary>
    /// <value>For termFrequency aggregations</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }



    /// <summary>
    /// For numericRange aggregations
    /// </summary>
    /// <value>For numericRange aggregations</value>
    [DataMember(Name = "gte", EmitDefaultValue = false)]
    public double? Gte { get; set; }



    /// <summary>
    /// For numericRange aggregations
    /// </summary>
    /// <value>For numericRange aggregations</value>
    [DataMember(Name = "lt", EmitDefaultValue = false)]
    public double? Lt { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AggregationResultEntry {\n");

        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as AggregationResultEntry);
    }

    /// <summary>
    /// Returns true if AggregationResultEntry instances are equal
    /// </summary>
    /// <param name="other">Instance of AggregationResultEntry to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AggregationResultEntry other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
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
            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

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
