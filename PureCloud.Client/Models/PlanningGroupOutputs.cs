using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PlanningGroupOutputs
/// </summary>

public partial class PlanningGroupOutputs : IEquatable<PlanningGroupOutputs>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PlanningGroupOutputs" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PlanningGroupOutputs() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PlanningGroupOutputs" /> class.
    /// </summary>
    /// <param name="PlanningGroupId">The ID for for the associated planning group result (required).</param>
    /// <param name="ServiceLevelPerInterval">List of Service Level percentage (0.0-100.0) results per interval (required).</param>
    /// <param name="OccupancyPerInterval">List of Occupancy percentage (0.0-100.0) results per interval (required).</param>
    /// <param name="AverageSpeedOfAnswerSecondsPerInterval">List of Average Speed of Answer (in seconds) results per interval (required).</param>
    /// <param name="AbandonRatePerInterval">List of Abandon rate percentage (0.0-100.0) results per interval (required).</param>
    public PlanningGroupOutputs(string PlanningGroupId = null, List<double?> ServiceLevelPerInterval = null, List<double?> OccupancyPerInterval = null, List<double?> AverageSpeedOfAnswerSecondsPerInterval = null, List<double?> AbandonRatePerInterval = null)
    {
        this.PlanningGroupId = PlanningGroupId;
        this.ServiceLevelPerInterval = ServiceLevelPerInterval;
        this.OccupancyPerInterval = OccupancyPerInterval;
        this.AverageSpeedOfAnswerSecondsPerInterval = AverageSpeedOfAnswerSecondsPerInterval;
        this.AbandonRatePerInterval = AbandonRatePerInterval;

    }



    /// <summary>
    /// The ID for for the associated planning group result
    /// </summary>
    /// <value>The ID for for the associated planning group result</value>
    [JsonPropertyName("planningGroupId")]
    public string PlanningGroupId { get; set; }



    /// <summary>
    /// List of Service Level percentage (0.0-100.0) results per interval
    /// </summary>
    /// <value>List of Service Level percentage (0.0-100.0) results per interval</value>
    [JsonPropertyName("serviceLevelPerInterval")]
    public List<double?> ServiceLevelPerInterval { get; set; }



    /// <summary>
    /// List of Occupancy percentage (0.0-100.0) results per interval
    /// </summary>
    /// <value>List of Occupancy percentage (0.0-100.0) results per interval</value>
    [JsonPropertyName("occupancyPerInterval")]
    public List<double?> OccupancyPerInterval { get; set; }



    /// <summary>
    /// List of Average Speed of Answer (in seconds) results per interval
    /// </summary>
    /// <value>List of Average Speed of Answer (in seconds) results per interval</value>
    [JsonPropertyName("averageSpeedOfAnswerSecondsPerInterval")]
    public List<double?> AverageSpeedOfAnswerSecondsPerInterval { get; set; }



    /// <summary>
    /// List of Abandon rate percentage (0.0-100.0) results per interval
    /// </summary>
    /// <value>List of Abandon rate percentage (0.0-100.0) results per interval</value>
    [JsonPropertyName("abandonRatePerInterval")]
    public List<double?> AbandonRatePerInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PlanningGroupOutputs {\n");

        sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
        sb.Append("  ServiceLevelPerInterval: ").Append(ServiceLevelPerInterval).Append("\n");
        sb.Append("  OccupancyPerInterval: ").Append(OccupancyPerInterval).Append("\n");
        sb.Append("  AverageSpeedOfAnswerSecondsPerInterval: ").Append(AverageSpeedOfAnswerSecondsPerInterval).Append("\n");
        sb.Append("  AbandonRatePerInterval: ").Append(AbandonRatePerInterval).Append("\n");
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
        return Equals(obj as PlanningGroupOutputs);
    }

    /// <summary>
    /// Returns true if PlanningGroupOutputs instances are equal
    /// </summary>
    /// <param name="other">Instance of PlanningGroupOutputs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PlanningGroupOutputs other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PlanningGroupId == other.PlanningGroupId ||
                PlanningGroupId != null &&
                PlanningGroupId.Equals(other.PlanningGroupId)
            ) &&
            (
                ServiceLevelPerInterval == other.ServiceLevelPerInterval ||
                ServiceLevelPerInterval != null &&
                ServiceLevelPerInterval.SequenceEqual(other.ServiceLevelPerInterval)
            ) &&
            (
                OccupancyPerInterval == other.OccupancyPerInterval ||
                OccupancyPerInterval != null &&
                OccupancyPerInterval.SequenceEqual(other.OccupancyPerInterval)
            ) &&
            (
                AverageSpeedOfAnswerSecondsPerInterval == other.AverageSpeedOfAnswerSecondsPerInterval ||
                AverageSpeedOfAnswerSecondsPerInterval != null &&
                AverageSpeedOfAnswerSecondsPerInterval.SequenceEqual(other.AverageSpeedOfAnswerSecondsPerInterval)
            ) &&
            (
                AbandonRatePerInterval == other.AbandonRatePerInterval ||
                AbandonRatePerInterval != null &&
                AbandonRatePerInterval.SequenceEqual(other.AbandonRatePerInterval)
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
            if (PlanningGroupId != null)
            {
                hash = hash * 59 + PlanningGroupId.GetHashCode();
            }

            if (ServiceLevelPerInterval != null)
            {
                hash = hash * 59 + ServiceLevelPerInterval.GetHashCode();
            }

            if (OccupancyPerInterval != null)
            {
                hash = hash * 59 + OccupancyPerInterval.GetHashCode();
            }

            if (AverageSpeedOfAnswerSecondsPerInterval != null)
            {
                hash = hash * 59 + AverageSpeedOfAnswerSecondsPerInterval.GetHashCode();
            }

            if (AbandonRatePerInterval != null)
            {
                hash = hash * 59 + AbandonRatePerInterval.GetHashCode();
            }

            return hash;
        }
    }
}
