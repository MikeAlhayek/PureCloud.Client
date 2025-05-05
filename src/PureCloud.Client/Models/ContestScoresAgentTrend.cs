using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestScoresAgentTrend
/// </summary>

public partial class ContestScoresAgentTrend : IEquatable<ContestScoresAgentTrend>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestScoresAgentTrend" /> class.
    /// </summary>
    /// <param name="ContestScore">The Contest score.</param>
    /// <param name="MetricScores">The Contest metric scores.</param>
    /// <param name="Disqualified">Indicates whether an agent is disqualified or not.</param>
    /// <param name="DateWorkday">Workday of the contest scores leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    public ContestScoresAgentTrend(ContestScoreRanked ContestScore = null, List<ContestMetricScoreRanked> MetricScores = null, bool? Disqualified = null, string DateWorkday = null)
    {
        this.ContestScore = ContestScore;
        this.MetricScores = MetricScores;
        this.Disqualified = Disqualified;
        this.DateWorkday = DateWorkday;

    }



    /// <summary>
    /// The Contest score
    /// </summary>
    /// <value>The Contest score</value>
    [JsonPropertyName("contestScore")]
    public ContestScoreRanked ContestScore { get; set; }



    /// <summary>
    /// The Contest metric scores
    /// </summary>
    /// <value>The Contest metric scores</value>
    [JsonPropertyName("metricScores")]
    public List<ContestMetricScoreRanked> MetricScores { get; set; }



    /// <summary>
    /// Indicates whether an agent is disqualified or not
    /// </summary>
    /// <value>Indicates whether an agent is disqualified or not</value>
    [JsonPropertyName("disqualified")]
    public bool? Disqualified { get; set; }



    /// <summary>
    /// Workday of the contest scores leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Workday of the contest scores leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateWorkday")]
    public string DateWorkday { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestScoresAgentTrend {\n");

        sb.Append("  ContestScore: ").Append(ContestScore).Append("\n");
        sb.Append("  MetricScores: ").Append(MetricScores).Append("\n");
        sb.Append("  Disqualified: ").Append(Disqualified).Append("\n");
        sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
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
        return Equals(obj as ContestScoresAgentTrend);
    }

    /// <summary>
    /// Returns true if ContestScoresAgentTrend instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestScoresAgentTrend to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestScoresAgentTrend other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContestScore == other.ContestScore ||
                ContestScore != null &&
                ContestScore.Equals(other.ContestScore)
            ) &&
            (
                MetricScores == other.MetricScores ||
                MetricScores != null &&
                MetricScores.SequenceEqual(other.MetricScores)
            ) &&
            (
                Disqualified == other.Disqualified ||
                Disqualified != null &&
                Disqualified.Equals(other.Disqualified)
            ) &&
            (
                DateWorkday == other.DateWorkday ||
                DateWorkday != null &&
                DateWorkday.Equals(other.DateWorkday)
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
            if (ContestScore != null)
            {
                hash = hash * 59 + ContestScore.GetHashCode();
            }

            if (MetricScores != null)
            {
                hash = hash * 59 + MetricScores.GetHashCode();
            }

            if (Disqualified != null)
            {
                hash = hash * 59 + Disqualified.GetHashCode();
            }

            if (DateWorkday != null)
            {
                hash = hash * 59 + DateWorkday.GetHashCode();
            }

            return hash;
        }
    }
}
