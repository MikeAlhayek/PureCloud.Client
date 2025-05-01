using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QualityAuditQueryExecutionStatusResponse
/// </summary>
[DataContract]
public partial class QualityAuditQueryExecutionStatusResponse : IEquatable<QualityAuditQueryExecutionStatusResponse>
{
    /// <summary>
    /// Status of the audit query execution request.
    /// </summary>
    /// <value>Status of the audit query execution request.</value>
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
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QualityAuditQueryExecutionStatusResponse" /> class.
    /// </summary>
    /// <param name="Id">Id of the audit query execution request..</param>
    /// <param name="State">Status of the audit query execution request..</param>
    /// <param name="DateStart">Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Interval">Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    /// <param name="Filters">Filters for the audit query..</param>
    /// <param name="Sort">Sort parameter for the audit query..</param>
    public QualityAuditQueryExecutionStatusResponse(string Id = null, StateEnum? State = null, DateTime? DateStart = null, string Interval = null, List<QualityAuditQueryFilter> Filters = null, List<AuditQuerySort> Sort = null)
    {
        this.Id = Id;
        this.State = State;
        this.DateStart = DateStart;
        this.Interval = Interval;
        this.Filters = Filters;
        this.Sort = Sort;

    }



    /// <summary>
    /// Id of the audit query execution request.
    /// </summary>
    /// <value>Id of the audit query execution request.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }





    /// <summary>
    /// Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateStart", EmitDefaultValue = false)]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [DataMember(Name = "interval", EmitDefaultValue = false)]
    public string Interval { get; set; }



    /// <summary>
    /// Filters for the audit query.
    /// </summary>
    /// <value>Filters for the audit query.</value>
    [DataMember(Name = "filters", EmitDefaultValue = false)]
    public List<QualityAuditQueryFilter> Filters { get; set; }



    /// <summary>
    /// Sort parameter for the audit query.
    /// </summary>
    /// <value>Sort parameter for the audit query.</value>
    [DataMember(Name = "sort", EmitDefaultValue = false)]
    public List<AuditQuerySort> Sort { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QualityAuditQueryExecutionStatusResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  Interval: ").Append(Interval).Append("\n");
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
        return Equals(obj as QualityAuditQueryExecutionStatusResponse);
    }

    /// <summary>
    /// Returns true if QualityAuditQueryExecutionStatusResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of QualityAuditQueryExecutionStatusResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QualityAuditQueryExecutionStatusResponse other)
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
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
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

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
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
