using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestScoreRanked
/// </summary>
[DataContract]
public partial class ContestScoreRanked : IEquatable<ContestScoreRanked>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestScoreRanked" /> class.
    /// </summary>
    /// <param name="Score">The Contest score.</param>
    /// <param name="TotalPoints">The Contest totalPoints.</param>
    /// <param name="PercentOfGoal">The Contest percentOfGoal.</param>
    /// <param name="Rank">The Contest Score rank.</param>
    /// <param name="Tier">The Contest Score tier.</param>
    public ContestScoreRanked(double? Score = null, double? TotalPoints = null, double? PercentOfGoal = null, int? Rank = null, int? Tier = null)
    {
        this.Score = Score;
        this.TotalPoints = TotalPoints;
        this.PercentOfGoal = PercentOfGoal;
        this.Rank = Rank;
        this.Tier = Tier;

    }



    /// <summary>
    /// The Contest score
    /// </summary>
    /// <value>The Contest score</value>
    [DataMember(Name = "score", EmitDefaultValue = false)]
    public double? Score { get; set; }



    /// <summary>
    /// The Contest totalPoints
    /// </summary>
    /// <value>The Contest totalPoints</value>
    [DataMember(Name = "totalPoints", EmitDefaultValue = false)]
    public double? TotalPoints { get; set; }



    /// <summary>
    /// The Contest percentOfGoal
    /// </summary>
    /// <value>The Contest percentOfGoal</value>
    [DataMember(Name = "percentOfGoal", EmitDefaultValue = false)]
    public double? PercentOfGoal { get; set; }



    /// <summary>
    /// The Contest Score rank
    /// </summary>
    /// <value>The Contest Score rank</value>
    [DataMember(Name = "rank", EmitDefaultValue = false)]
    public int? Rank { get; set; }



    /// <summary>
    /// The Contest Score tier
    /// </summary>
    /// <value>The Contest Score tier</value>
    [DataMember(Name = "tier", EmitDefaultValue = false)]
    public int? Tier { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestScoreRanked {\n");

        sb.Append("  Score: ").Append(Score).Append("\n");
        sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
        sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
        sb.Append("  Rank: ").Append(Rank).Append("\n");
        sb.Append("  Tier: ").Append(Tier).Append("\n");
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
        return Equals(obj as ContestScoreRanked);
    }

    /// <summary>
    /// Returns true if ContestScoreRanked instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestScoreRanked to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestScoreRanked other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            ) &&
            (
                Tier == other.Tier ||
                Tier != null &&
                Tier.Equals(other.Tier)
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

            if (Tier != null)
            {
                hash = hash * 59 + Tier.GetHashCode();
            }

            return hash;
        }
    }
}
