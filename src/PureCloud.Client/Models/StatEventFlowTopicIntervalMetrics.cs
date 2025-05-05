using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// StatEventFlowTopicIntervalMetrics
/// </summary>

public partial class StatEventFlowTopicIntervalMetrics : IEquatable<StatEventFlowTopicIntervalMetrics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StatEventFlowTopicIntervalMetrics" /> class.
    /// </summary>
    /// <param name="Interval">Interval.</param>
    /// <param name="Metrics">Metrics.</param>
    public StatEventFlowTopicIntervalMetrics(string Interval = null, List<StatEventFlowTopicMetricStats> Metrics = null)
    {
        this.Interval = Interval;
        this.Metrics = Metrics;

    }



    /// <summary>
    /// Gets or Sets Interval
    /// </summary>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [JsonPropertyName("metrics")]
    public List<StatEventFlowTopicMetricStats> Metrics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StatEventFlowTopicIntervalMetrics {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
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
        return Equals(obj as StatEventFlowTopicIntervalMetrics);
    }

    /// <summary>
    /// Returns true if StatEventFlowTopicIntervalMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of StatEventFlowTopicIntervalMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(StatEventFlowTopicIntervalMetrics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            return hash;
        }
    }
}
