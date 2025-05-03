using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmForecastModificationIntervalOffsetValue
/// </summary>

public partial class WfmForecastModificationIntervalOffsetValue : IEquatable<WfmForecastModificationIntervalOffsetValue>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmForecastModificationIntervalOffsetValue" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmForecastModificationIntervalOffsetValue() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmForecastModificationIntervalOffsetValue" /> class.
    /// </summary>
    /// <param name="IntervalIndex">The number of intervals past referenceStartDate to which to apply this modification (required).</param>
    /// <param name="Value">The value to set for the given interval (required).</param>
    public WfmForecastModificationIntervalOffsetValue(int? IntervalIndex = null, double? Value = null)
    {
        this.IntervalIndex = IntervalIndex;
        this.Value = Value;

    }



    /// <summary>
    /// The number of intervals past referenceStartDate to which to apply this modification
    /// </summary>
    /// <value>The number of intervals past referenceStartDate to which to apply this modification</value>
    [JsonPropertyName("intervalIndex")]
    public int? IntervalIndex { get; set; }



    /// <summary>
    /// The value to set for the given interval
    /// </summary>
    /// <value>The value to set for the given interval</value>
    [JsonPropertyName("value")]
    public double? Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmForecastModificationIntervalOffsetValue {\n");

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
        return Equals(obj as WfmForecastModificationIntervalOffsetValue);
    }

    /// <summary>
    /// Returns true if WfmForecastModificationIntervalOffsetValue instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmForecastModificationIntervalOffsetValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmForecastModificationIntervalOffsetValue other)
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
