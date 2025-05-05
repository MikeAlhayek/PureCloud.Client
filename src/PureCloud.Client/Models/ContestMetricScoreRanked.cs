using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestMetricScoreRanked
/// </summary>

public partial class ContestMetricScoreRanked : IEquatable<ContestMetricScoreRanked>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestMetricScoreRanked" /> class.
    /// </summary>
    /// <param name="Metric">The gamification metric for the data.</param>
    /// <param name="Score">The Contest Metric score.</param>
    /// <param name="TotalPoints">The Contest Metric totalPoints.</param>
    /// <param name="PercentOfGoal">The Contest Metric percentOfGoal.</param>
    /// <param name="Rank">The Contest Score rank, a lower rank is better (1 is the best).</param>
    public ContestMetricScoreRanked(AddressableEntityRef Metric = null, double? Score = null, double? TotalPoints = null, double? PercentOfGoal = null, int? Rank = null)
    {
        this.Metric = Metric;
        this.Score = Score;
        this.TotalPoints = TotalPoints;
        this.PercentOfGoal = PercentOfGoal;
        this.Rank = Rank;

    }



    /// <summary>
    /// The gamification metric for the data
    /// </summary>
    /// <value>The gamification metric for the data</value>
    [JsonPropertyName("metric")]
    public AddressableEntityRef Metric { get; set; }



    /// <summary>
    /// The Contest Metric score
    /// </summary>
    /// <value>The Contest Metric score</value>
    [JsonPropertyName("score")]
    public double? Score { get; set; }



    /// <summary>
    /// The Contest Metric totalPoints
    /// </summary>
    /// <value>The Contest Metric totalPoints</value>
    [JsonPropertyName("totalPoints")]
    public double? TotalPoints { get; set; }



    /// <summary>
    /// The Contest Metric percentOfGoal
    /// </summary>
    /// <value>The Contest Metric percentOfGoal</value>
    [JsonPropertyName("percentOfGoal")]
    public double? PercentOfGoal { get; set; }



    /// <summary>
    /// The Contest Score rank, a lower rank is better (1 is the best)
    /// </summary>
    /// <value>The Contest Score rank, a lower rank is better (1 is the best)</value>
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestMetricScoreRanked {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Score: ").Append(Score).Append("\n");
        sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
        sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
        sb.Append("  Rank: ").Append(Rank).Append("\n");
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
        return Equals(obj as ContestMetricScoreRanked);
    }

    /// <summary>
    /// Returns true if ContestMetricScoreRanked instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestMetricScoreRanked to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestMetricScoreRanked other)
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
                Score == other.Score ||
                Score != null &&
                Score.Equals(other.Score)
            ) &&
            (
                TotalPoints == other.TotalPoints ||
                TotalPoints != null &&
                TotalPoints.Equals(other.TotalPoints)
            ) &&
            (
                PercentOfGoal == other.PercentOfGoal ||
                PercentOfGoal != null &&
                PercentOfGoal.Equals(other.PercentOfGoal)
            ) &&
            (
                Rank == other.Rank ||
                Rank != null &&
                Rank.Equals(other.Rank)
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

            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            if (TotalPoints != null)
            {
                hash = hash * 59 + TotalPoints.GetHashCode();
            }

            if (PercentOfGoal != null)
            {
                hash = hash * 59 + PercentOfGoal.GetHashCode();
            }

            if (Rank != null)
            {
                hash = hash * 59 + Rank.GetHashCode();
            }

            return hash;
        }
    }
}
