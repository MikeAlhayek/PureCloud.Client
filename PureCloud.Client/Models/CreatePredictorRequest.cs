using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreatePredictorRequest
/// </summary>

public partial class CreatePredictorRequest : IEquatable<CreatePredictorRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreatePredictorRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreatePredictorRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreatePredictorRequest" /> class.
    /// </summary>
    /// <param name="QueueIds">The queue IDs associated with the predictor. (required).</param>
    /// <param name="Kpi">The KPI that the predictor attempts to maximize/minimize. (required).</param>
    /// <param name="RoutingTimeoutSeconds">Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds..</param>
    /// <param name="Schedule">The predictor schedule that determines when the predictor is used for routing interactions..</param>
    /// <param name="WorkloadBalancingConfig">The predictor balancing configuration to enable workload balancing.</param>
    public CreatePredictorRequest(List<string> QueueIds = null, string Kpi = null, int? RoutingTimeoutSeconds = null, PredictorSchedule Schedule = null, PredictorWorkloadBalancing WorkloadBalancingConfig = null)
    {
        this.QueueIds = QueueIds;
        this.Kpi = Kpi;
        this.RoutingTimeoutSeconds = RoutingTimeoutSeconds;
        this.Schedule = Schedule;
        this.WorkloadBalancingConfig = WorkloadBalancingConfig;

    }



    /// <summary>
    /// The queue IDs associated with the predictor.
    /// </summary>
    /// <value>The queue IDs associated with the predictor.</value>
    [JsonPropertyName("queueIds")]
    public List<string> QueueIds { get; set; }



    /// <summary>
    /// The KPI that the predictor attempts to maximize/minimize.
    /// </summary>
    /// <value>The KPI that the predictor attempts to maximize/minimize.</value>
    [JsonPropertyName("kpi")]
    public string Kpi { get; set; }



    /// <summary>
    /// Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds.
    /// </summary>
    /// <value>Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds.</value>
    [JsonPropertyName("routingTimeoutSeconds")]
    public int? RoutingTimeoutSeconds { get; set; }



    /// <summary>
    /// The predictor schedule that determines when the predictor is used for routing interactions.
    /// </summary>
    /// <value>The predictor schedule that determines when the predictor is used for routing interactions.</value>
    [JsonPropertyName("schedule")]
    public PredictorSchedule Schedule { get; set; }



    /// <summary>
    /// The predictor balancing configuration to enable workload balancing
    /// </summary>
    /// <value>The predictor balancing configuration to enable workload balancing</value>
    [JsonPropertyName("workloadBalancingConfig")]
    public PredictorWorkloadBalancing WorkloadBalancingConfig { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreatePredictorRequest {\n");

        sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
        sb.Append("  Kpi: ").Append(Kpi).Append("\n");
        sb.Append("  RoutingTimeoutSeconds: ").Append(RoutingTimeoutSeconds).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  WorkloadBalancingConfig: ").Append(WorkloadBalancingConfig).Append("\n");
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
        return Equals(obj as CreatePredictorRequest);
    }

    /// <summary>
    /// Returns true if CreatePredictorRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreatePredictorRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreatePredictorRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QueueIds == other.QueueIds ||
                QueueIds != null &&
                QueueIds.SequenceEqual(other.QueueIds)
            ) &&
            (
                Kpi == other.Kpi ||
                Kpi != null &&
                Kpi.Equals(other.Kpi)
            ) &&
            (
                RoutingTimeoutSeconds == other.RoutingTimeoutSeconds ||
                RoutingTimeoutSeconds != null &&
                RoutingTimeoutSeconds.Equals(other.RoutingTimeoutSeconds)
            ) &&
            (
                Schedule == other.Schedule ||
                Schedule != null &&
                Schedule.Equals(other.Schedule)
            ) &&
            (
                WorkloadBalancingConfig == other.WorkloadBalancingConfig ||
                WorkloadBalancingConfig != null &&
                WorkloadBalancingConfig.Equals(other.WorkloadBalancingConfig)
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
            if (QueueIds != null)
            {
                hash = hash * 59 + QueueIds.GetHashCode();
            }

            if (Kpi != null)
            {
                hash = hash * 59 + Kpi.GetHashCode();
            }

            if (RoutingTimeoutSeconds != null)
            {
                hash = hash * 59 + RoutingTimeoutSeconds.GetHashCode();
            }

            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            if (WorkloadBalancingConfig != null)
            {
                hash = hash * 59 + WorkloadBalancingConfig.GetHashCode();
            }

            return hash;
        }
    }
}
