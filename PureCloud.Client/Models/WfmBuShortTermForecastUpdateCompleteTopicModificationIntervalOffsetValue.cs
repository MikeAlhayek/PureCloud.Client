using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue
/// </summary>
[DataContract]
public partial class WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue : IEquatable<WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue" /> class.
    /// </summary>
    /// <param name="IntervalIndex">IntervalIndex.</param>
    /// <param name="Value">Value.</param>
    public WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue(long? IntervalIndex = null, double? Value = null)
    {
        this.IntervalIndex = IntervalIndex;
        this.Value = Value;

    }



    /// <summary>
    /// Gets or Sets IntervalIndex
    /// </summary>
    [DataMember(Name = "intervalIndex", EmitDefaultValue = false)]
    public long? IntervalIndex { get; set; }



    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public double? Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue {\n");

        sb.Append("  IntervalIndex: ").Append(IntervalIndex).Append("\n");
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
        return Equals(obj as WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue);
    }

    /// <summary>
    /// Returns true if WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                IntervalIndex == other.IntervalIndex ||
                IntervalIndex != null &&
                IntervalIndex.Equals(other.IntervalIndex)
            ) &&
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
            if (IntervalIndex != null)
            {
                hash = hash * 59 + IntervalIndex.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
