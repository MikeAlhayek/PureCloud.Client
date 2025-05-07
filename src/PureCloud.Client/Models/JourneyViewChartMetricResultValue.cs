using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyViewChartMetricResultValue
/// </summary>

public partial class JourneyViewChartMetricResultValue : IEquatable<JourneyViewChartMetricResultValue>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewChartMetricResultValue" /> class.
    /// </summary>
    public JourneyViewChartMetricResultValue()
    {

    }



    /// <summary>
    /// Value for this metric
    /// </summary>
    /// <value>Value for this metric</value>
    [JsonPropertyName("value")]
    public int? Value { get; set; }



    /// <summary>
    /// Group by attributes for this metric
    /// </summary>
    /// <value>Group by attributes for this metric</value>
    [JsonPropertyName("groupByAttributes")]
    public List<GroupByAttribute> GroupByAttributes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewChartMetricResultValue {\n");

        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  GroupByAttributes: ").Append(GroupByAttributes).Append("\n");
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
        return Equals(obj as JourneyViewChartMetricResultValue);
    }

    /// <summary>
    /// Returns true if JourneyViewChartMetricResultValue instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewChartMetricResultValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewChartMetricResultValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                GroupByAttributes == other.GroupByAttributes ||
                GroupByAttributes != null &&
                GroupByAttributes.SequenceEqual(other.GroupByAttributes)
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
            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (GroupByAttributes != null)
            {
                hash = hash * 59 + GroupByAttributes.GetHashCode();
            }

            return hash;
        }
    }
}
