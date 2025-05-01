using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Predictor
/// </summary>
[DataContract]
public partial class Predictor : IEquatable<Predictor>
{
    /// <summary>
    /// The predictor state.
    /// </summary>
    /// <value>The predictor state.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Created for "Created"
        /// </summary>
        [EnumMember(Value = "Created")]
        Created,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active
    }
    /// <summary>
    /// The predictor state.
    /// </summary>
    /// <value>The predictor state.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Predictor" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Predictor() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Predictor" /> class.
    /// </summary>
    /// <param name="Queues">The queue IDs associated with the predictor. (required).</param>
    /// <param name="Kpi">The KPI that the predictor attempts to maximize/minimize. (required).</param>
    /// <param name="RoutingTimeoutSeconds">Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds..</param>
    /// <param name="Schedule">The predictor schedule that determines when the predictor is used for routing interactions..</param>
    /// <param name="WorkloadBalancingConfig">The predictor balancing configuration to enable workload balancing..</param>
    public Predictor(List<AddressableEntityRef> Queues = null, string Kpi = null, int? RoutingTimeoutSeconds = null, PredictorSchedule Schedule = null, PredictorWorkloadBalancing WorkloadBalancingConfig = null)
    {
        this.Queues = Queues;
        this.Kpi = Kpi;
        this.RoutingTimeoutSeconds = RoutingTimeoutSeconds;
        this.Schedule = Schedule;
        this.WorkloadBalancingConfig = WorkloadBalancingConfig;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The queue IDs associated with the predictor.
    /// </summary>
    /// <value>The queue IDs associated with the predictor.</value>
    [DataMember(Name = "queues", EmitDefaultValue = false)]
    public List<AddressableEntityRef> Queues { get; set; }



    /// <summary>
    /// The KPI that the predictor attempts to maximize/minimize.
    /// </summary>
    /// <value>The KPI that the predictor attempts to maximize/minimize.</value>
    [DataMember(Name = "kpi", EmitDefaultValue = false)]
    public string Kpi { get; set; }



    /// <summary>
    /// Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds.
    /// </summary>
    /// <value>Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds.</value>
    [DataMember(Name = "routingTimeoutSeconds", EmitDefaultValue = false)]
    public int? RoutingTimeoutSeconds { get; set; }



    /// <summary>
    /// The predictor schedule that determines when the predictor is used for routing interactions.
    /// </summary>
    /// <value>The predictor schedule that determines when the predictor is used for routing interactions.</value>
    [DataMember(Name = "schedule", EmitDefaultValue = false)]
    public PredictorSchedule Schedule { get; set; }





    /// <summary>
    /// DateTime indicating when the predictor was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>DateTime indicating when the predictor was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// DateTime indicating when the predictor was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>DateTime indicating when the predictor was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The predictor balancing configuration to enable workload balancing.
    /// </summary>
    /// <value>The predictor balancing configuration to enable workload balancing.</value>
    [DataMember(Name = "workloadBalancingConfig", EmitDefaultValue = false)]
    public PredictorWorkloadBalancing WorkloadBalancingConfig { get; set; }



    /// <summary>
    /// Predictor error code - optional details on why the predictor went into error state.
    /// </summary>
    /// <value>Predictor error code - optional details on why the predictor went into error state.</value>
    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; private set; }



    /// <summary>
    /// Predictor&#39;s models
    /// </summary>
    /// <value>Predictor&#39;s models</value>
    [DataMember(Name = "models", EmitDefaultValue = false)]
    public List<PredictorModelBrief> Models { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Predictor {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Queues: ").Append(Queues).Append("\n");
        sb.Append("  Kpi: ").Append(Kpi).Append("\n");
        sb.Append("  RoutingTimeoutSeconds: ").Append(RoutingTimeoutSeconds).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  WorkloadBalancingConfig: ").Append(WorkloadBalancingConfig).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  Models: ").Append(Models).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as Predictor);
    }

    /// <summary>
    /// Returns true if Predictor instances are equal
    /// </summary>
    /// <param name="other">Instance of Predictor to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Predictor other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Queues == other.Queues ||
                Queues != null &&
                Queues.SequenceEqual(other.Queues)
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
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                WorkloadBalancingConfig == other.WorkloadBalancingConfig ||
                WorkloadBalancingConfig != null &&
                WorkloadBalancingConfig.Equals(other.WorkloadBalancingConfig)
            ) &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                Models == other.Models ||
                Models != null &&
                Models.SequenceEqual(other.Models)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Queues != null)
            {
                hash = hash * 59 + Queues.GetHashCode();
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (WorkloadBalancingConfig != null)
            {
                hash = hash * 59 + WorkloadBalancingConfig.GetHashCode();
            }

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (Models != null)
            {
                hash = hash * 59 + Models.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
