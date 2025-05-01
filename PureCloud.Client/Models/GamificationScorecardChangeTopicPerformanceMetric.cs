using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

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
        return this.Equals(obj as GamificationScorecardChangeTopicPerformanceMetric);
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
                this.Metric == other.Metric ||
                this.Metric != null &&
                this.Metric.Equals(other.Metric)
            ) &&
            (
                this.Points == other.Points ||
                this.Points != null &&
                this.Points.Equals(other.Points)
            ) &&
            (
                this.Value == other.Value ||
                this.Value != null &&
                this.Value.Equals(other.Value)
            ) &&
            (
                this.PunctualityEvents == other.PunctualityEvents ||
                this.PunctualityEvents != null &&
                this.PunctualityEvents.SequenceEqual(other.PunctualityEvents)
            ) &&
            (
                this.EvaluationDetails == other.EvaluationDetails ||
                this.EvaluationDetails != null &&
                this.EvaluationDetails.SequenceEqual(other.EvaluationDetails)
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
            if (this.Metric != null)
            {
                hash = hash * 59 + this.Metric.GetHashCode();
            }

            if (this.Points != null)
            {
                hash = hash * 59 + this.Points.GetHashCode();
            }

            if (this.Value != null)
            {
                hash = hash * 59 + this.Value.GetHashCode();
            }

            if (this.PunctualityEvents != null)
            {
                hash = hash * 59 + this.PunctualityEvents.GetHashCode();
            }

            if (this.EvaluationDetails != null)
            {
                hash = hash * 59 + this.EvaluationDetails.GetHashCode();
            }

            return hash;
        }
    }
}
