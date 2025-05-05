using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DevelopmentActivityAggregateQueryResponseStatistics
/// </summary>

public partial class DevelopmentActivityAggregateQueryResponseStatistics : IEquatable<DevelopmentActivityAggregateQueryResponseStatistics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DevelopmentActivityAggregateQueryResponseStatistics" /> class.
    /// </summary>
    /// <param name="Count">The count for this metric.</param>
    /// <param name="Min">The minimum value in this metric.</param>
    /// <param name="Max">The maximum value in this metric.</param>
    /// <param name="Sum">The total of the values for this metric.</param>
    public DevelopmentActivityAggregateQueryResponseStatistics(int? Count = null, double? Min = null, double? Max = null, double? Sum = null)
    {
        this.Count = Count;
        this.Min = Min;
        this.Max = Max;
        this.Sum = Sum;

    }



    /// <summary>
    /// The count for this metric
    /// </summary>
    /// <value>The count for this metric</value>
    [JsonPropertyName("count")]
    public int? Count { get; set; }



    /// <summary>
    /// The minimum value in this metric
    /// </summary>
    /// <value>The minimum value in this metric</value>
    [JsonPropertyName("min")]
    public double? Min { get; set; }



    /// <summary>
    /// The maximum value in this metric
    /// </summary>
    /// <value>The maximum value in this metric</value>
    [JsonPropertyName("max")]
    public double? Max { get; set; }



    /// <summary>
    /// The total of the values for this metric
    /// </summary>
    /// <value>The total of the values for this metric</value>
    [JsonPropertyName("sum")]
    public double? Sum { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DevelopmentActivityAggregateQueryResponseStatistics {\n");

        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  Min: ").Append(Min).Append("\n");
        sb.Append("  Max: ").Append(Max).Append("\n");
        sb.Append("  Sum: ").Append(Sum).Append("\n");
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
        return Equals(obj as DevelopmentActivityAggregateQueryResponseStatistics);
    }

    /// <summary>
    /// Returns true if DevelopmentActivityAggregateQueryResponseStatistics instances are equal
    /// </summary>
    /// <param name="other">Instance of DevelopmentActivityAggregateQueryResponseStatistics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DevelopmentActivityAggregateQueryResponseStatistics other)
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
                Min == other.Min ||
                Min != null &&
                Min.Equals(other.Min)
            ) &&
            (
                Max == other.Max ||
                Max != null &&
                Max.Equals(other.Max)
            ) &&
            (
                Sum == other.Sum ||
                Sum != null &&
                Sum.Equals(other.Sum)
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

            if (Min != null)
            {
                hash = hash * 59 + Min.GetHashCode();
            }

            if (Max != null)
            {
                hash = hash * 59 + Max.GetHashCode();
            }

            if (Sum != null)
            {
                hash = hash * 59 + Sum.GetHashCode();
            }

            return hash;
        }
    }
}
