using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult
/// </summary>

public partial class WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult : IEquatable<WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    
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
        /// Enum Unmatched for "Unmatched"
        /// </summary>
        [EnumMember(Value = "Unmatched")]
        Unmatched,

        /// <summary>
        /// Enum Matched for "Matched"
        /// </summary>
        [EnumMember(Value = "Matched")]
        Matched,

        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,

        /// <summary>
        /// Enum Denied for "Denied"
        /// </summary>
        [EnumMember(Value = "Denied")]
        Denied,

        /// <summary>
        /// Enum Expired for "Expired"
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled
    }
    /// <summary>
    /// Gets or Sets FailureReason
    /// </summary>
    
    public enum FailureReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Initiatingagentschedulenotfound for "InitiatingAgentScheduleNotFound"
        /// </summary>
        [EnumMember(Value = "InitiatingAgentScheduleNotFound")]
        Initiatingagentschedulenotfound,

        /// <summary>
        /// Enum Initiatingagentshiftnotfound for "InitiatingAgentShiftNotFound"
        /// </summary>
        [EnumMember(Value = "InitiatingAgentShiftNotFound")]
        Initiatingagentshiftnotfound,

        /// <summary>
        /// Enum Receivingagentnotfound for "ReceivingAgentNotFound"
        /// </summary>
        [EnumMember(Value = "ReceivingAgentNotFound")]
        Receivingagentnotfound,

        /// <summary>
        /// Enum Receivingagentschedulenotfound for "ReceivingAgentScheduleNotFound"
        /// </summary>
        [EnumMember(Value = "ReceivingAgentScheduleNotFound")]
        Receivingagentschedulenotfound,

        /// <summary>
        /// Enum Receivingagentshiftnotfound for "ReceivingAgentShiftNotFound"
        /// </summary>
        [EnumMember(Value = "ReceivingAgentShiftNotFound")]
        Receivingagentshiftnotfound,

        /// <summary>
        /// Enum Schedulenotpublished for "ScheduleNotPublished"
        /// </summary>
        [EnumMember(Value = "ScheduleNotPublished")]
        Schedulenotpublished,

        /// <summary>
        /// Enum Transitionnotallowed for "TransitionNotAllowed"
        /// </summary>
        [EnumMember(Value = "TransitionNotAllowed")]
        Transitionnotallowed
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets FailureReason
    /// </summary>
    [JsonPropertyName("failureReason")]
    public FailureReasonEnum? FailureReason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="State">State.</param>
    /// <param name="ReviewedBy">ReviewedBy.</param>
    /// <param name="ReviewedDate">ReviewedDate.</param>
    /// <param name="FailureReason">FailureReason.</param>
    /// <param name="Metadata">Metadata.</param>
    public WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult(string Id = null, StateEnum? State = null, WfmBulkShiftTradeStateUpdateNotificationTopicUserReference ReviewedBy = null, DateTime? ReviewedDate = null, FailureReasonEnum? FailureReason = null, WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata Metadata = null)
    {
        this.Id = Id;
        this.State = State;
        this.ReviewedBy = ReviewedBy;
        this.ReviewedDate = ReviewedDate;
        this.FailureReason = FailureReason;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Gets or Sets ReviewedBy
    /// </summary>
    [JsonPropertyName("reviewedBy")]
    public WfmBulkShiftTradeStateUpdateNotificationTopicUserReference ReviewedBy { get; set; }



    /// <summary>
    /// Gets or Sets ReviewedDate
    /// </summary>
    [JsonPropertyName("reviewedDate")]
    public DateTime? ReviewedDate { get; set; }





    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [JsonPropertyName("metadata")]
    public WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
        sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
        sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult);
    }

    /// <summary>
    /// Returns true if WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult other)
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
                ReviewedBy == other.ReviewedBy ||
                ReviewedBy != null &&
                ReviewedBy.Equals(other.ReviewedBy)
            ) &&
            (
                ReviewedDate == other.ReviewedDate ||
                ReviewedDate != null &&
                ReviewedDate.Equals(other.ReviewedDate)
            ) &&
            (
                FailureReason == other.FailureReason ||
                FailureReason != null &&
                FailureReason.Equals(other.FailureReason)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (ReviewedBy != null)
            {
                hash = hash * 59 + ReviewedBy.GetHashCode();
            }

            if (ReviewedDate != null)
            {
                hash = hash * 59 + ReviewedDate.GetHashCode();
            }

            if (FailureReason != null)
            {
                hash = hash * 59 + FailureReason.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
