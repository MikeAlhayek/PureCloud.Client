using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// InsightsTrendMetricItem
/// </summary>
[DataContract]
public partial class InsightsTrendMetricItem : IEquatable<InsightsTrendMetricItem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InsightsTrendMetricItem" /> class.
    /// </summary>
    /// <param name="Metric">The gamification metric for the trend.</param>
    /// <param name="Trends">Trends for the metric.</param>
    public InsightsTrendMetricItem(AddressableEntityRef Metric = null, InsightsTrends Trends = null)
    {
        this.Metric = Metric;
        this.Trends = Trends;

    }



    /// <summary>
    /// The gamification metric for the trend
    /// </summary>
    /// <value>The gamification metric for the trend</value>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public AddressableEntityRef Metric { get; set; }



    /// <summary>
    /// Trends for the metric
    /// </summary>
    /// <value>Trends for the metric</value>
    [DataMember(Name = "trends", EmitDefaultValue = false)]
    public InsightsTrends Trends { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InsightsTrendMetricItem {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Trends: ").Append(Trends).Append("\n");
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
        return this.Equals(obj as InsightsTrendMetricItem);
    }

    /// <summary>
    /// Returns true if InsightsTrendMetricItem instances are equal
    /// </summary>
    /// <param name="other">Instance of InsightsTrendMetricItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InsightsTrendMetricItem other)
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
                this.Trends == other.Trends ||
                this.Trends != null &&
                this.Trends.Equals(other.Trends)
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

            if (this.Trends != null)
            {
                hash = hash * 59 + this.Trends.GetHashCode();
            }

            return hash;
        }
    }
}
