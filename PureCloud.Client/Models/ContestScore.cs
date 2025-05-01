using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestScore
/// </summary>
[DataContract]
public partial class ContestScore : IEquatable<ContestScore>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestScore" /> class.
    /// </summary>
    /// <param name="Score">The Contest score.</param>
    /// <param name="TotalPoints">The Contest totalPoints.</param>
    /// <param name="PercentOfGoal">The Contest percentOfGoal.</param>
    public ContestScore(double? Score = null, double? TotalPoints = null, double? PercentOfGoal = null)
    {
        this.Score = Score;
        this.TotalPoints = TotalPoints;
        this.PercentOfGoal = PercentOfGoal;

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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestScore {\n");

        sb.Append("  Score: ").Append(Score).Append("\n");
        sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
        sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
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
        return Equals(obj as ContestScore);
    }

    /// <summary>
    /// Returns true if ContestScore instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestScore to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestScore other)
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

            return hash;
        }
    }
}
