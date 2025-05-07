using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkJob
/// </summary>

public partial class BulkJob : IEquatable<BulkJob>
{
    /// <summary>
    /// The bulk job state.
    /// </summary>
    /// <value>The bulk job state.</value>
    
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
        /// Enum Idle for "Idle"
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle,

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
        Cancelled,

        /// <summary>
        /// Enum Terminated for "Terminated"
        /// </summary>
        [EnumMember(Value = "Terminated")]
        Terminated
    }
    /// <summary>
    /// The bulk job action. This determines what the bulk job does, for example, terminate workitems.
    /// </summary>
    /// <value>The bulk job action. This determines what the bulk job does, for example, terminate workitems.</value>
    
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Terminateworkitems for "TerminateWorkitems"
        /// </summary>
        [EnumMember(Value = "TerminateWorkitems")]
        Terminateworkitems,

        /// <summary>
        /// Enum Addworkitems for "AddWorkitems"
        /// </summary>
        [EnumMember(Value = "AddWorkitems")]
        Addworkitems
    }
    /// <summary>
    /// The bulk job state.
    /// </summary>
    /// <value>The bulk job state.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// The bulk job action. This determines what the bulk job does, for example, terminate workitems.
    /// </summary>
    /// <value>The bulk job action. This determines what the bulk job does, for example, terminate workitems.</value>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkJob" /> class.
    /// </summary>
    /// <param name="State">The bulk job state..</param>
    /// <param name="Action">The bulk job action. This determines what the bulk job does, for example, terminate workitems..</param>
    /// <param name="TotalCount">Total count of items to be processed in the bulk job..</param>
    /// <param name="SuccessfulCount">Count of successfully processed items in the bulk job..</param>
    /// <param name="FailedCount">Count of failed processed items in the bulk job..</param>
    /// <param name="DateStarted">The bulk job start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateFinished">The bulk job finished date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">The bulk job modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public BulkJob(StateEnum? State = null, ActionEnum? Action = null, int? TotalCount = null, int? SuccessfulCount = null, int? FailedCount = null, DateTime? DateStarted = null, DateTime? DateFinished = null, DateTime? DateModified = null)
    {
        this.State = State;
        this.Action = Action;
        this.TotalCount = TotalCount;
        this.SuccessfulCount = SuccessfulCount;
        this.FailedCount = FailedCount;
        this.DateStarted = DateStarted;
        this.DateFinished = DateFinished;
        this.DateModified = DateModified;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }







    /// <summary>
    /// Total count of items to be processed in the bulk job.
    /// </summary>
    /// <value>Total count of items to be processed in the bulk job.</value>
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }



    /// <summary>
    /// Count of successfully processed items in the bulk job.
    /// </summary>
    /// <value>Count of successfully processed items in the bulk job.</value>
    [JsonPropertyName("successfulCount")]
    public int? SuccessfulCount { get; set; }



    /// <summary>
    /// Count of failed processed items in the bulk job.
    /// </summary>
    /// <value>Count of failed processed items in the bulk job.</value>
    [JsonPropertyName("failedCount")]
    public int? FailedCount { get; set; }



    /// <summary>
    /// The bulk job start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The bulk job start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStarted")]
    public DateTime? DateStarted { get; set; }



    /// <summary>
    /// The bulk job finished date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The bulk job finished date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateFinished")]
    public DateTime? DateFinished { get; set; }



    /// <summary>
    /// The bulk job modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The bulk job modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkJob {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
        sb.Append("  SuccessfulCount: ").Append(SuccessfulCount).Append("\n");
        sb.Append("  FailedCount: ").Append(FailedCount).Append("\n");
        sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
        sb.Append("  DateFinished: ").Append(DateFinished).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as BulkJob);
    }

    /// <summary>
    /// Returns true if BulkJob instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkJob to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkJob other)
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
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                TotalCount == other.TotalCount ||
                TotalCount != null &&
                TotalCount.Equals(other.TotalCount)
            ) &&
            (
                SuccessfulCount == other.SuccessfulCount ||
                SuccessfulCount != null &&
                SuccessfulCount.Equals(other.SuccessfulCount)
            ) &&
            (
                FailedCount == other.FailedCount ||
                FailedCount != null &&
                FailedCount.Equals(other.FailedCount)
            ) &&
            (
                DateStarted == other.DateStarted ||
                DateStarted != null &&
                DateStarted.Equals(other.DateStarted)
            ) &&
            (
                DateFinished == other.DateFinished ||
                DateFinished != null &&
                DateFinished.Equals(other.DateFinished)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (TotalCount != null)
            {
                hash = hash * 59 + TotalCount.GetHashCode();
            }

            if (SuccessfulCount != null)
            {
                hash = hash * 59 + SuccessfulCount.GetHashCode();
            }

            if (FailedCount != null)
            {
                hash = hash * 59 + FailedCount.GetHashCode();
            }

            if (DateStarted != null)
            {
                hash = hash * 59 + DateStarted.GetHashCode();
            }

            if (DateFinished != null)
            {
                hash = hash * 59 + DateFinished.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
