using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Leaderboard
/// </summary>

public partial class Leaderboard : IEquatable<Leaderboard>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Leaderboard" /> class.
    /// </summary>
    public Leaderboard()
    {

    }



    /// <summary>
    /// The targeted division for this leaderboard
    /// </summary>
    /// <value>The targeted division for this leaderboard</value>
    [JsonPropertyName("division")]
    public Division Division { get; private set; }



    /// <summary>
    /// The metric id if the leaderboard is about a specific metric
    /// </summary>
    /// <value>The metric id if the leaderboard is about a specific metric</value>
    [JsonPropertyName("metric")]
    public AddressableEntityRef Metric { get; private set; }



    /// <summary>
    /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStartWorkday")]
    public string DateStartWorkday { get; private set; }



    /// <summary>
    /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEndWorkday")]
    public string DateEndWorkday { get; private set; }



    /// <summary>
    /// The list of leaders generated.
    /// </summary>
    /// <value>The list of leaders generated.</value>
    [JsonPropertyName("leaders")]
    public List<LeaderboardItem> Leaders { get; private set; }



    /// <summary>
    /// The requesting user&#39;s rank
    /// </summary>
    /// <value>The requesting user&#39;s rank</value>
    [JsonPropertyName("userRank")]
    public LeaderboardItem UserRank { get; private set; }



    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    [JsonPropertyName("performanceProfile")]
    public AddressableEntityRef PerformanceProfile { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Leaderboard {\n");

        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
        sb.Append("  Leaders: ").Append(Leaders).Append("\n");
        sb.Append("  UserRank: ").Append(UserRank).Append("\n");
        sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
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
        return Equals(obj as Leaderboard);
    }

    /// <summary>
    /// Returns true if Leaderboard instances are equal
    /// </summary>
    /// <param name="other">Instance of Leaderboard to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Leaderboard other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                DateStartWorkday == other.DateStartWorkday ||
                DateStartWorkday != null &&
                DateStartWorkday.Equals(other.DateStartWorkday)
            ) &&
            (
                DateEndWorkday == other.DateEndWorkday ||
                DateEndWorkday != null &&
                DateEndWorkday.Equals(other.DateEndWorkday)
            ) &&
            (
                Leaders == other.Leaders ||
                Leaders != null &&
                Leaders.SequenceEqual(other.Leaders)
            ) &&
            (
                UserRank == other.UserRank ||
                UserRank != null &&
                UserRank.Equals(other.UserRank)
            ) &&
            (
                PerformanceProfile == other.PerformanceProfile ||
                PerformanceProfile != null &&
                PerformanceProfile.Equals(other.PerformanceProfile)
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
            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (DateStartWorkday != null)
            {
                hash = hash * 59 + DateStartWorkday.GetHashCode();
            }

            if (DateEndWorkday != null)
            {
                hash = hash * 59 + DateEndWorkday.GetHashCode();
            }

            if (Leaders != null)
            {
                hash = hash * 59 + Leaders.GetHashCode();
            }

            if (UserRank != null)
            {
                hash = hash * 59 + UserRank.GetHashCode();
            }

            if (PerformanceProfile != null)
            {
                hash = hash * 59 + PerformanceProfile.GetHashCode();
            }

            return hash;
        }
    }
}
