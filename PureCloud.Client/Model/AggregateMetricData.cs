using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// AggregateMetricData
/// </summary>
[DataContract]
public partial class AggregateMetricData : IEquatable<AggregateMetricData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AggregateMetricData" /> class.
    /// </summary>
    /// <param name="Metric">Metric.</param>
    /// <param name="Qualifier">Qualifier.</param>
    /// <param name="Stats">Stats.</param>
    public AggregateMetricData(string Metric = null, string Qualifier = null, StatisticalSummary Stats = null)
    {
        this.Metric = Metric;
        this.Qualifier = Qualifier;
        this.Stats = Stats;

    }



    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public string Metric { get; set; }



    /// <summary>
    /// Gets or Sets Qualifier
    /// </summary>
    [DataMember(Name = "qualifier", EmitDefaultValue = false)]
    public string Qualifier { get; set; }



    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    [DataMember(Name = "stats", EmitDefaultValue = false)]
    public StatisticalSummary Stats { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AggregateMetricData {\n");

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
        return this.Equals(obj as AggregateMetricData);
    }

    /// <summary>
    /// Returns true if AggregateMetricData instances are equal
    /// </summary>
    /// <param name="other">Instance of AggregateMetricData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AggregateMetricData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Metric == other.Metric ||
                this.Metric != null &&
                this.Metric.Equals(other.Metric)
            ) &&
            (
                this.Qualifier == other.Qualifier ||
                this.Qualifier != null &&
                this.Qualifier.Equals(other.Qualifier)
            ) &&
            (
                this.Stats == other.Stats ||
                this.Stats != null &&
                this.Stats.Equals(other.Stats)
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
            if (this.Metric != null)
            {
                hash = hash * 59 + this.Metric.GetHashCode();
            }

            if (this.Qualifier != null)
            {
                hash = hash * 59 + this.Qualifier.GetHashCode();
            }

            if (this.Stats != null)
            {
                hash = hash * 59 + this.Stats.GetHashCode();
            }

            return hash;
        }
    }
}
