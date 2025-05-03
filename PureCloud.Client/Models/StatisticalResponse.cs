using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// StatisticalResponse
/// </summary>

public partial class StatisticalResponse : IEquatable<StatisticalResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StatisticalResponse" /> class.
    /// </summary>
    /// <param name="Interval">Interval.</param>
    /// <param name="Metrics">Metrics.</param>
    /// <param name="Views">Views.</param>
    public StatisticalResponse(string Interval = null, List<AggregateMetricData> Metrics = null, List<AggregateViewData> Views = null)
    {
        this.Interval = Interval;
        this.Metrics = Metrics;
        this.Views = Views;

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
    public List<AggregateMetricData> Metrics { get; set; }



    /// <summary>
    /// Gets or Sets Views
    /// </summary>
    [JsonPropertyName("views")]
    public List<AggregateViewData> Views { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StatisticalResponse {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  Views: ").Append(Views).Append("\n");
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
        return Equals(obj as StatisticalResponse);
    }

    /// <summary>
    /// Returns true if StatisticalResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of StatisticalResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(StatisticalResponse other)
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
            ) &&
            (
                Views == other.Views ||
                Views != null &&
                Views.SequenceEqual(other.Views)
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

            if (Views != null)
            {
                hash = hash * 59 + Views.GetHashCode();
            }

            return hash;
        }
    }
}
