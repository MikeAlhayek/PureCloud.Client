using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InsightsSummaryMetricPeriodPoints
/// </summary>

public partial class InsightsSummaryMetricPeriodPoints : IEquatable<InsightsSummaryMetricPeriodPoints>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InsightsSummaryMetricPeriodPoints" /> class.
    /// </summary>
    /// <param name="Points">Points scored.</param>
    /// <param name="MaxPoints">Max possible points.</param>
    /// <param name="DataPointCount">Number of data points.</param>
    /// <param name="PercentOfGoal">Percentage of the goal.</param>
    /// <param name="Value">Average value.</param>
    public InsightsSummaryMetricPeriodPoints(int? Points = null, int? MaxPoints = null, int? DataPointCount = null, double? PercentOfGoal = null, double? Value = null)
    {
        this.Points = Points;
        this.MaxPoints = MaxPoints;
        this.DataPointCount = DataPointCount;
        this.PercentOfGoal = PercentOfGoal;
        this.Value = Value;

    }



    /// <summary>
    /// Points scored
    /// </summary>
    /// <value>Points scored</value>
    [JsonPropertyName("points")]
    public int? Points { get; set; }



    /// <summary>
    /// Max possible points
    /// </summary>
    /// <value>Max possible points</value>
    [JsonPropertyName("maxPoints")]
    public int? MaxPoints { get; set; }



    /// <summary>
    /// Number of data points
    /// </summary>
    /// <value>Number of data points</value>
    [JsonPropertyName("dataPointCount")]
    public int? DataPointCount { get; set; }



    /// <summary>
    /// Percentage of the goal
    /// </summary>
    /// <value>Percentage of the goal</value>
    [JsonPropertyName("percentOfGoal")]
    public double? PercentOfGoal { get; set; }



    /// <summary>
    /// Average value
    /// </summary>
    /// <value>Average value</value>
    [JsonPropertyName("value")]
    public double? Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InsightsSummaryMetricPeriodPoints {\n");

        sb.Append("  Points: ").Append(Points).Append("\n");
        sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
        sb.Append("  DataPointCount: ").Append(DataPointCount).Append("\n");
        sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as InsightsSummaryMetricPeriodPoints);
    }

    /// <summary>
    /// Returns true if InsightsSummaryMetricPeriodPoints instances are equal
    /// </summary>
    /// <param name="other">Instance of InsightsSummaryMetricPeriodPoints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InsightsSummaryMetricPeriodPoints other)
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
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
