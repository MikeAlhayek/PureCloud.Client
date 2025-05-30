using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryResponseData
/// </summary>

public partial class QueryResponseData : IEquatable<QueryResponseData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryResponseData" /> class.
    /// </summary>
    /// <param name="Interval">Interval with start and end represented as ISO-8601 string. i.e: yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;/yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;.</param>
    /// <param name="Metrics">A list of aggregated metrics.</param>
    public QueryResponseData(string Interval = null, List<QueryResponseMetric> Metrics = null)
    {
        this.Interval = Interval;
        this.Metrics = Metrics;

    }



    /// <summary>
    /// Interval with start and end represented as ISO-8601 string. i.e: yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;/yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;
    /// </summary>
    /// <value>Interval with start and end represented as ISO-8601 string. i.e: yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;/yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// A list of aggregated metrics
    /// </summary>
    /// <value>A list of aggregated metrics</value>
    [JsonPropertyName("metrics")]
    public List<QueryResponseMetric> Metrics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryResponseData {\n");

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
        return Equals(obj as QueryResponseData);
    }

    /// <summary>
    /// Returns true if QueryResponseData instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryResponseData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryResponseData other)
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
