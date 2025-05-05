using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InsightsSummaryUserItem
/// </summary>

public partial class InsightsSummaryUserItem : IEquatable<InsightsSummaryUserItem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InsightsSummaryUserItem" /> class.
    /// </summary>
    /// <param name="User">Queried user.</param>
    /// <param name="MetricData">The list of insights data for each metric of the user.</param>
    /// <param name="OverallData">Overall insights data of the user.</param>
    /// <param name="Ranking">Ranking of the user.</param>
    public InsightsSummaryUserItem(UserReference User = null, List<InsightsSummaryMetricItem> MetricData = null, InsightsSummaryOverallItem OverallData = null, int? Ranking = null)
    {
        this.User = User;
        this.MetricData = MetricData;
        this.OverallData = OverallData;
        this.Ranking = Ranking;

    }



    /// <summary>
    /// Queried user
    /// </summary>
    /// <value>Queried user</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The list of insights data for each metric of the user
    /// </summary>
    /// <value>The list of insights data for each metric of the user</value>
    [JsonPropertyName("metricData")]
    public List<InsightsSummaryMetricItem> MetricData { get; set; }



    /// <summary>
    /// Overall insights data of the user
    /// </summary>
    /// <value>Overall insights data of the user</value>
    [JsonPropertyName("overallData")]
    public InsightsSummaryOverallItem OverallData { get; set; }



    /// <summary>
    /// Ranking of the user
    /// </summary>
    /// <value>Ranking of the user</value>
    [JsonPropertyName("ranking")]
    public int? Ranking { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InsightsSummaryUserItem {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  MetricData: ").Append(MetricData).Append("\n");
        sb.Append("  OverallData: ").Append(OverallData).Append("\n");
        sb.Append("  Ranking: ").Append(Ranking).Append("\n");
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
        return Equals(obj as InsightsSummaryUserItem);
    }

    /// <summary>
    /// Returns true if InsightsSummaryUserItem instances are equal
    /// </summary>
    /// <param name="other">Instance of InsightsSummaryUserItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InsightsSummaryUserItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                MetricData == other.MetricData ||
                MetricData != null &&
                MetricData.SequenceEqual(other.MetricData)
            ) &&
            (
                OverallData == other.OverallData ||
                OverallData != null &&
                OverallData.Equals(other.OverallData)
            ) &&
            (
                Ranking == other.Ranking ||
                Ranking != null &&
                Ranking.Equals(other.Ranking)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (MetricData != null)
            {
                hash = hash * 59 + MetricData.GetHashCode();
            }

            if (OverallData != null)
            {
                hash = hash * 59 + OverallData.GetHashCode();
            }

            if (Ranking != null)
            {
                hash = hash * 59 + Ranking.GetHashCode();
            }

            return hash;
        }
    }
}
