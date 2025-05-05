using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkdayMetric
/// </summary>

public partial class WorkdayMetric : IEquatable<WorkdayMetric>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkdayMetric" /> class.
    /// </summary>
    public WorkdayMetric()
    {

    }



    /// <summary>
    /// Gamification metric
    /// </summary>
    /// <value>Gamification metric</value>
    [JsonPropertyName("metric")]
    public Metric Metric { get; private set; }



    /// <summary>
    /// Current objective for this metric
    /// </summary>
    /// <value>Current objective for this metric</value>
    [JsonPropertyName("objective")]
    public Objective Objective { get; private set; }



    /// <summary>
    /// Gamification points earned for this metric
    /// </summary>
    /// <value>Gamification points earned for this metric</value>
    [JsonPropertyName("points")]
    public int? Points { get; private set; }



    /// <summary>
    /// The maximum Gamification points a user may earn for this metric
    /// </summary>
    /// <value>The maximum Gamification points a user may earn for this metric</value>
    [JsonPropertyName("maxPoints")]
    public int? MaxPoints { get; private set; }



    /// <summary>
    /// Value of this metric
    /// </summary>
    /// <value>Value of this metric</value>
    [JsonPropertyName("value")]
    public double? Value { get; private set; }



    /// <summary>
    /// List of schedule activity events for punctuality metrics
    /// </summary>
    /// <value>List of schedule activity events for punctuality metrics</value>
    [JsonPropertyName("punctualityEvents")]
    public List<PunctualityEvent> PunctualityEvents { get; private set; }



    /// <summary>
    /// List of evaluations for quality evaluation score metrics
    /// </summary>
    /// <value>List of evaluations for quality evaluation score metrics</value>
    [JsonPropertyName("evaluationDetails")]
    public List<QualityEvaluationScoreItem> EvaluationDetails { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkdayMetric {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Objective: ").Append(Objective).Append("\n");
        sb.Append("  Points: ").Append(Points).Append("\n");
        sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  PunctualityEvents: ").Append(PunctualityEvents).Append("\n");
        sb.Append("  EvaluationDetails: ").Append(EvaluationDetails).Append("\n");
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
        return Equals(obj as WorkdayMetric);
    }

    /// <summary>
    /// Returns true if WorkdayMetric instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkdayMetric to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkdayMetric other)
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
                Objective == other.Objective ||
                Objective != null &&
                Objective.Equals(other.Objective)
            ) &&
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
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                PunctualityEvents == other.PunctualityEvents ||
                PunctualityEvents != null &&
                PunctualityEvents.SequenceEqual(other.PunctualityEvents)
            ) &&
            (
                EvaluationDetails == other.EvaluationDetails ||
                EvaluationDetails != null &&
                EvaluationDetails.SequenceEqual(other.EvaluationDetails)
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

            if (Objective != null)
            {
                hash = hash * 59 + Objective.GetHashCode();
            }

            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
            }

            if (MaxPoints != null)
            {
                hash = hash * 59 + MaxPoints.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (PunctualityEvents != null)
            {
                hash = hash * 59 + PunctualityEvents.GetHashCode();
            }

            if (EvaluationDetails != null)
            {
                hash = hash * 59 + EvaluationDetails.GetHashCode();
            }

            return hash;
        }
    }
}
