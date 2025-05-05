using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaAggregateMetricData
/// </summary>

public partial class SocialMediaAggregateMetricData : IEquatable<SocialMediaAggregateMetricData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SocialMediaAggregateMetricData" /> class.
    /// </summary>
    /// <param name="Metric">Metric.</param>
    /// <param name="Qualifier">Qualifier.</param>
    /// <param name="Stats">Stats.</param>
    public SocialMediaAggregateMetricData(string Metric = null, string Qualifier = null, SocialMediaStatisticalSummary Stats = null)
    {
        this.Metric = Metric;
        this.Qualifier = Qualifier;
        this.Stats = Stats;

    }



    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    [JsonPropertyName("metric")]
    public string Metric { get; set; }



    /// <summary>
    /// Gets or Sets Qualifier
    /// </summary>
    [JsonPropertyName("qualifier")]
    public string Qualifier { get; set; }



    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    [JsonPropertyName("stats")]
    public SocialMediaStatisticalSummary Stats { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SocialMediaAggregateMetricData {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
        sb.Append("  Stats: ").Append(Stats).Append("\n");
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
        return Equals(obj as SocialMediaAggregateMetricData);
    }

    /// <summary>
    /// Returns true if SocialMediaAggregateMetricData instances are equal
    /// </summary>
    /// <param name="other">Instance of SocialMediaAggregateMetricData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SocialMediaAggregateMetricData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                Qualifier == other.Qualifier ||
                Qualifier != null &&
                Qualifier.Equals(other.Qualifier)
            ) &&
            (
                Stats == other.Stats ||
                Stats != null &&
                Stats.Equals(other.Stats)
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
            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (Qualifier != null)
            {
                hash = hash * 59 + Qualifier.GetHashCode();
            }

            if (Stats != null)
            {
                hash = hash * 59 + Stats.GetHashCode();
            }

            return hash;
        }
    }
}
