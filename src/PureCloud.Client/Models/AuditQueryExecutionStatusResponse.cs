using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditQueryExecutionStatusResponse
/// </summary>

public partial class AuditQueryExecutionStatusResponse : IEquatable<AuditQueryExecutionStatusResponse>
{
    /// <summary>
    /// Status of the audit query execution request.
    /// </summary>
    /// <value>Status of the audit query execution request.</value>
    
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
        /// Enum Queued for "Queued"
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued,

        /// <summary>
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,

        /// <summary>
        /// Enum Succeeded for "Succeeded"
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Cancelled for "Cancelled"
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled
    }
    /// <summary>
    /// Status of the audit query execution request.
    /// </summary>
    /// <value>Status of the audit query execution request.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQueryExecutionStatusResponse" /> class.
    /// </summary>
    /// <param name="Id">Id of the audit query execution request..</param>
    /// <param name="State">Status of the audit query execution request..</param>
    /// <param name="StartDate">Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Interval">Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    /// <param name="ServiceName">Service name for the audit query..</param>
    /// <param name="Filters">Filters for the audit query..</param>
    /// <param name="Sort">Sort parameter for the audit query..</param>
    public AuditQueryExecutionStatusResponse(string Id = null, StateEnum? State = null, DateTime? StartDate = null, string Interval = null, string ServiceName = null, List<AuditQueryFilter> Filters = null, List<AuditQuerySort> Sort = null)
    {
        this.Id = Id;
        this.State = State;
        this.StartDate = StartDate;
        this.Interval = Interval;
        this.ServiceName = ServiceName;
        this.Filters = Filters;
        this.Sort = Sort;

    }



    /// <summary>
    /// Id of the audit query execution request.
    /// </summary>
    /// <value>Id of the audit query execution request.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// Service name for the audit query.
    /// </summary>
    /// <value>Service name for the audit query.</value>
    [JsonPropertyName("serviceName")]
    public string ServiceName { get; set; }



    /// <summary>
    /// Filters for the audit query.
    /// </summary>
    /// <value>Filters for the audit query.</value>
    [JsonPropertyName("filters")]
    public List<AuditQueryFilter> Filters { get; set; }



    /// <summary>
    /// Sort parameter for the audit query.
    /// </summary>
    /// <value>Sort parameter for the audit query.</value>
    [JsonPropertyName("sort")]
    public List<AuditQuerySort> Sort { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditQueryExecutionStatusResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
        sb.Append("  Filters: ").Append(Filters).Append("\n");
        sb.Append("  Sort: ").Append(Sort).Append("\n");
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
        return Equals(obj as AuditQueryExecutionStatusResponse);
    }

    /// <summary>
    /// Returns true if AuditQueryExecutionStatusResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditQueryExecutionStatusResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditQueryExecutionStatusResponse other)
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
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                ServiceName == other.ServiceName ||
                ServiceName != null &&
                ServiceName.Equals(other.ServiceName)
            ) &&
            (
                Filters == other.Filters ||
                Filters != null &&
                Filters.SequenceEqual(other.Filters)
            ) &&
            (
                Sort == other.Sort ||
                Sort != null &&
                Sort.SequenceEqual(other.Sort)
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (ServiceName != null)
            {
                hash = hash * 59 + ServiceName.GetHashCode();
            }

            if (Filters != null)
            {
                hash = hash * 59 + Filters.GetHashCode();
            }

            if (Sort != null)
            {
                hash = hash * 59 + Sort.GetHashCode();
            }

            return hash;
        }
    }
}
