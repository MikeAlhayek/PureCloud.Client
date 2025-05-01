using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GamificationScorecardChangeTopicPerformanceMetric
/// </summary>
[DataContract]
public partial class GamificationScorecardChangeTopicPerformanceMetric : IEquatable<GamificationScorecardChangeTopicPerformanceMetric>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GamificationScorecardChangeTopicPerformanceMetric" /> class.
    /// </summary>
    /// <param name="Metric">Metric.</param>
    /// <param name="Points">Points.</param>
    /// <param name="Value">Value.</param>
    /// <param name="PunctualityEvents">PunctualityEvents.</param>
    /// <param name="EvaluationDetails">EvaluationDetails.</param>
    public GamificationScorecardChangeTopicPerformanceMetric(GamificationScorecardChangeTopicMetric Metric = null, long? Points = null, double? Value = null, List<GamificationScorecardChangeTopicPunctualityEvent> PunctualityEvents = null, List<GamificationScorecardChangeTopicEvaluationDetail> EvaluationDetails = null)
    {
        this.Metric = Metric;
        this.Points = Points;
        this.Value = Value;
        this.PunctualityEvents = PunctualityEvents;
        this.EvaluationDetails = EvaluationDetails;

    }



    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public GamificationScorecardChangeTopicMetric Metric { get; set; }



    /// <summary>
    /// Gets or Sets Points
    /// </summary>
    [DataMember(Name = "points", EmitDefaultValue = false)]
    public long? Points { get; set; }



    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public double? Value { get; set; }



    /// <summary>
    /// Gets or Sets PunctualityEvents
    /// </summary>
    [DataMember(Name = "punctualityEvents", EmitDefaultValue = false)]
    public List<GamificationScorecardChangeTopicPunctualityEvent> PunctualityEvents { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationDetails
    /// </summary>
    [DataMember(Name = "evaluationDetails", EmitDefaultValue = false)]
    public List<GamificationScorecardChangeTopicEvaluationDetail> EvaluationDetails { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GamificationScorecardChangeTopicPerformanceMetric {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Points: ").Append(Points).Append("\n");
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
        return Equals(obj as GamificationScorecardChangeTopicPerformanceMetric);
    }

    /// <summary>
    /// Returns true if GamificationScorecardChangeTopicPerformanceMetric instances are equal
    /// </summary>
    /// <param name="other">Instance of GamificationScorecardChangeTopicPerformanceMetric to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GamificationScorecardChangeTopicPerformanceMetric other)
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
                Points == other.Points ||
                Points != null &&
                Points.Equals(other.Points)
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

            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
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
