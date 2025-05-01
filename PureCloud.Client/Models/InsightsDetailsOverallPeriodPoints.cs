using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InsightsDetailsOverallPeriodPoints
/// </summary>
[DataContract]
public partial class InsightsDetailsOverallPeriodPoints : IEquatable<InsightsDetailsOverallPeriodPoints>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InsightsDetailsOverallPeriodPoints" /> class.
    /// </summary>
    /// <param name="Points">Points scored.</param>
    /// <param name="MaxPoints">Max possible points.</param>
    /// <param name="DataPointCount">Number of data points.</param>
    /// <param name="PercentOfGoal">Percentage of the goal.</param>
    /// <param name="RankTotalPoints">The agent&#39;s rank in leader board for points on this metric.</param>
    /// <param name="RankPercentagePoints">The agent&#39;s rank in leader board for percentage on this metric.</param>
    public InsightsDetailsOverallPeriodPoints(int? Points = null, int? MaxPoints = null, int? DataPointCount = null, double? PercentOfGoal = null, int? RankTotalPoints = null, int? RankPercentagePoints = null)
    {
        this.Points = Points;
        this.MaxPoints = MaxPoints;
        this.DataPointCount = DataPointCount;
        this.PercentOfGoal = PercentOfGoal;
        this.RankTotalPoints = RankTotalPoints;
        this.RankPercentagePoints = RankPercentagePoints;

    }



    /// <summary>
    /// Points scored
    /// </summary>
    /// <value>Points scored</value>
    [DataMember(Name = "points", EmitDefaultValue = false)]
    public int? Points { get; set; }



    /// <summary>
    /// Max possible points
    /// </summary>
    /// <value>Max possible points</value>
    [DataMember(Name = "maxPoints", EmitDefaultValue = false)]
    public int? MaxPoints { get; set; }



    /// <summary>
    /// Number of data points
    /// </summary>
    /// <value>Number of data points</value>
    [DataMember(Name = "dataPointCount", EmitDefaultValue = false)]
    public int? DataPointCount { get; set; }



    /// <summary>
    /// Percentage of the goal
    /// </summary>
    /// <value>Percentage of the goal</value>
    [DataMember(Name = "percentOfGoal", EmitDefaultValue = false)]
    public double? PercentOfGoal { get; set; }



    /// <summary>
    /// The agent&#39;s rank in leader board for points on this metric
    /// </summary>
    /// <value>The agent&#39;s rank in leader board for points on this metric</value>
    [DataMember(Name = "rankTotalPoints", EmitDefaultValue = false)]
    public int? RankTotalPoints { get; set; }



    /// <summary>
    /// The agent&#39;s rank in leader board for percentage on this metric
    /// </summary>
    /// <value>The agent&#39;s rank in leader board for percentage on this metric</value>
    [DataMember(Name = "rankPercentagePoints", EmitDefaultValue = false)]
    public int? RankPercentagePoints { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InsightsDetailsOverallPeriodPoints {\n");

        sb.Append("  Points: ").Append(Points).Append("\n");
        sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
        sb.Append("  DataPointCount: ").Append(DataPointCount).Append("\n");
        sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
        sb.Append("  RankTotalPoints: ").Append(RankTotalPoints).Append("\n");
        sb.Append("  RankPercentagePoints: ").Append(RankPercentagePoints).Append("\n");
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
        return Equals(obj as InsightsDetailsOverallPeriodPoints);
    }

    /// <summary>
    /// Returns true if InsightsDetailsOverallPeriodPoints instances are equal
    /// </summary>
    /// <param name="other">Instance of InsightsDetailsOverallPeriodPoints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InsightsDetailsOverallPeriodPoints other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Points == other.Points ||
                Points != null &&
                Points.Equals(other.Points)
            ) &&
            (
                MaxPoints == other.MaxPoints ||
                MaxPoints != null &&
                MaxPoints.Equals(other.MaxPoints)
            ) &&
            (
                DataPointCount == other.DataPointCount ||
                DataPointCount != null &&
                DataPointCount.Equals(other.DataPointCount)
            ) &&
            (
                PercentOfGoal == other.PercentOfGoal ||
                PercentOfGoal != null &&
                PercentOfGoal.Equals(other.PercentOfGoal)
            ) &&
            (
                RankTotalPoints == other.RankTotalPoints ||
                RankTotalPoints != null &&
                RankTotalPoints.Equals(other.RankTotalPoints)
            ) &&
            (
                RankPercentagePoints == other.RankPercentagePoints ||
                RankPercentagePoints != null &&
                RankPercentagePoints.Equals(other.RankPercentagePoints)
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
            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
            }

            if (MaxPoints != null)
            {
                hash = hash * 59 + MaxPoints.GetHashCode();
            }

            if (DataPointCount != null)
            {
                hash = hash * 59 + DataPointCount.GetHashCode();
            }

            if (PercentOfGoal != null)
            {
                hash = hash * 59 + PercentOfGoal.GetHashCode();
            }

            if (RankTotalPoints != null)
            {
                hash = hash * 59 + RankTotalPoints.GetHashCode();
            }

            if (RankPercentagePoints != null)
            {
                hash = hash * 59 + RankPercentagePoints.GetHashCode();
            }

            return hash;
        }
    }
}
