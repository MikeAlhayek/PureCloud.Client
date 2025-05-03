using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate
/// </summary>

public partial class WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate : IEquatable<WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Enum Approved for "APPROVED"
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        Approved,

        /// <summary>
        /// Enum Denied for "DENIED"
        /// </summary>
        [EnumMember(Value = "DENIED")]
        Denied,

        /// <summary>
        /// Enum Canceled for "CANCELED"
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        Canceled
    }
    /// <summary>
    /// Gets or Sets Substatus
    /// </summary>
    
    public enum SubstatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Advancetimeelapsed for "AdvanceTimeElapsed"
        /// </summary>
        [EnumMember(Value = "AdvanceTimeElapsed")]
        Advancetimeelapsed,

        /// <summary>
        /// Enum Autoapproved for "AutoApproved"
        /// </summary>
        [EnumMember(Value = "AutoApproved")]
        Autoapproved,

        /// <summary>
        /// Enum Insufficientbalance for "InsufficientBalance"
        /// </summary>
        [EnumMember(Value = "InsufficientBalance")]
        Insufficientbalance,

        /// <summary>
        /// Enum Invaliddailyduration for "InvalidDailyDuration"
        /// </summary>
        [EnumMember(Value = "InvalidDailyDuration")]
        Invaliddailyduration,

        /// <summary>
        /// Enum Outsideshift for "OutsideShift"
        /// </summary>
        [EnumMember(Value = "OutsideShift")]
        Outsideshift,

        /// <summary>
        /// Enum Overlapsrestrictedactivitycode for "OverlapsRestrictedActivityCode"
        /// </summary>
        [EnumMember(Value = "OverlapsRestrictedActivityCode")]
        Overlapsrestrictedactivitycode,

        /// <summary>
        /// Enum Removedfromwaitlist for "RemovedFromWaitlist"
        /// </summary>
        [EnumMember(Value = "RemovedFromWaitlist")]
        Removedfromwaitlist,

        /// <summary>
        /// Enum Waitlisted for "Waitlisted"
        /// </summary>
        [EnumMember(Value = "Waitlisted")]
        Waitlisted
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Gets or Sets Substatus
    /// </summary>
    [JsonPropertyName("substatus")]
    public SubstatusEnum? Substatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="User">User.</param>
    /// <param name="IsFullDayRequest">IsFullDayRequest.</param>
    /// <param name="MarkedAsRead">MarkedAsRead.</param>
    /// <param name="ActivityCodeId">ActivityCodeId.</param>
    /// <param name="Paid">Paid.</param>
    /// <param name="Status">Status.</param>
    /// <param name="Substatus">Substatus.</param>
    /// <param name="PartialDayStartDateTimes">PartialDayStartDateTimes.</param>
    /// <param name="FullDayManagementUnitDates">FullDayManagementUnitDates.</param>
    /// <param name="DailyDurationMinutes">DailyDurationMinutes.</param>
    /// <param name="DurationMinutes">DurationMinutes.</param>
    /// <param name="PayableMinutes">PayableMinutes.</param>
    /// <param name="Notes">Notes.</param>
    /// <param name="ReviewedDate">ReviewedDate.</param>
    /// <param name="ReviewedBy">ReviewedBy.</param>
    /// <param name="SubmittedDate">SubmittedDate.</param>
    /// <param name="SubmittedBy">SubmittedBy.</param>
    /// <param name="ModifiedDate">ModifiedDate.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    public WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate(string Id = null, WfmTimeOffRequestUpdateTopicUserReference User = null, bool? IsFullDayRequest = null, bool? MarkedAsRead = null, string ActivityCodeId = null, bool? Paid = null, StatusEnum? Status = null, SubstatusEnum? Substatus = null, List<string> PartialDayStartDateTimes = null, List<string> FullDayManagementUnitDates = null, long? DailyDurationMinutes = null, List<long?> DurationMinutes = null, List<long?> PayableMinutes = null, string Notes = null, string ReviewedDate = null, string ReviewedBy = null, string SubmittedDate = null, string SubmittedBy = null, string ModifiedDate = null, string ModifiedBy = null)
    {
        this.Id = Id;
        this.User = User;
        this.IsFullDayRequest = IsFullDayRequest;
        this.MarkedAsRead = MarkedAsRead;
        this.ActivityCodeId = ActivityCodeId;
        this.Paid = Paid;
        this.Status = Status;
        this.Substatus = Substatus;
        this.PartialDayStartDateTimes = PartialDayStartDateTimes;
        this.FullDayManagementUnitDates = FullDayManagementUnitDates;
        this.DailyDurationMinutes = DailyDurationMinutes;
        this.DurationMinutes = DurationMinutes;
        this.PayableMinutes = PayableMinutes;
        this.Notes = Notes;
        this.ReviewedDate = ReviewedDate;
        this.ReviewedBy = ReviewedBy;
        this.SubmittedDate = SubmittedDate;
        this.SubmittedBy = SubmittedBy;
        this.ModifiedDate = ModifiedDate;
        this.ModifiedBy = ModifiedBy;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public WfmTimeOffRequestUpdateTopicUserReference User { get; set; }



    /// <summary>
    /// Gets or Sets IsFullDayRequest
    /// </summary>
    [JsonPropertyName("isFullDayRequest")]
    public bool? IsFullDayRequest { get; set; }



    /// <summary>
    /// Gets or Sets MarkedAsRead
    /// </summary>
    [JsonPropertyName("markedAsRead")]
    public bool? MarkedAsRead { get; set; }



    /// <summary>
    /// Gets or Sets ActivityCodeId
    /// </summary>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Gets or Sets Paid
    /// </summary>
    [JsonPropertyName("paid")]
    public bool? Paid { get; set; }







    /// <summary>
    /// Gets or Sets PartialDayStartDateTimes
    /// </summary>
    [JsonPropertyName("partialDayStartDateTimes")]
    public List<string> PartialDayStartDateTimes { get; set; }



    /// <summary>
    /// Gets or Sets FullDayManagementUnitDates
    /// </summary>
    [JsonPropertyName("fullDayManagementUnitDates")]
    public List<string> FullDayManagementUnitDates { get; set; }



    /// <summary>
    /// Gets or Sets DailyDurationMinutes
    /// </summary>
    [JsonPropertyName("dailyDurationMinutes")]
    public long? DailyDurationMinutes { get; set; }



    /// <summary>
    /// Gets or Sets DurationMinutes
    /// </summary>
    [JsonPropertyName("durationMinutes")]
    public List<long?> DurationMinutes { get; set; }



    /// <summary>
    /// Gets or Sets PayableMinutes
    /// </summary>
    [JsonPropertyName("payableMinutes")]
    public List<long?> PayableMinutes { get; set; }



    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }



    /// <summary>
    /// Gets or Sets ReviewedDate
    /// </summary>
    [JsonPropertyName("reviewedDate")]
    public string ReviewedDate { get; set; }



    /// <summary>
    /// Gets or Sets ReviewedBy
    /// </summary>
    [JsonPropertyName("reviewedBy")]
    public string ReviewedBy { get; set; }



    /// <summary>
    /// Gets or Sets SubmittedDate
    /// </summary>
    [JsonPropertyName("submittedDate")]
    public string SubmittedDate { get; set; }



    /// <summary>
    /// Gets or Sets SubmittedBy
    /// </summary>
    [JsonPropertyName("submittedBy")]
    public string SubmittedBy { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    [JsonPropertyName("modifiedDate")]
    public string ModifiedDate { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  IsFullDayRequest: ").Append(IsFullDayRequest).Append("\n");
        sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  Paid: ").Append(Paid).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Substatus: ").Append(Substatus).Append("\n");
        sb.Append("  PartialDayStartDateTimes: ").Append(PartialDayStartDateTimes).Append("\n");
        sb.Append("  FullDayManagementUnitDates: ").Append(FullDayManagementUnitDates).Append("\n");
        sb.Append("  DailyDurationMinutes: ").Append(DailyDurationMinutes).Append("\n");
        sb.Append("  DurationMinutes: ").Append(DurationMinutes).Append("\n");
        sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
        sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
        sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
        sb.Append("  SubmittedBy: ").Append(SubmittedBy).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
        return Equals(obj as WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate);
    }

    /// <summary>
    /// Returns true if WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate other)
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
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                IsFullDayRequest == other.IsFullDayRequest ||
                IsFullDayRequest != null &&
                IsFullDayRequest.Equals(other.IsFullDayRequest)
            ) &&
            (
                MarkedAsRead == other.MarkedAsRead ||
                MarkedAsRead != null &&
                MarkedAsRead.Equals(other.MarkedAsRead)
            ) &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                Paid == other.Paid ||
                Paid != null &&
                Paid.Equals(other.Paid)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Substatus == other.Substatus ||
                Substatus != null &&
                Substatus.Equals(other.Substatus)
            ) &&
            (
                PartialDayStartDateTimes == other.PartialDayStartDateTimes ||
                PartialDayStartDateTimes != null &&
                PartialDayStartDateTimes.SequenceEqual(other.PartialDayStartDateTimes)
            ) &&
            (
                FullDayManagementUnitDates == other.FullDayManagementUnitDates ||
                FullDayManagementUnitDates != null &&
                FullDayManagementUnitDates.SequenceEqual(other.FullDayManagementUnitDates)
            ) &&
            (
                DailyDurationMinutes == other.DailyDurationMinutes ||
                DailyDurationMinutes != null &&
                DailyDurationMinutes.Equals(other.DailyDurationMinutes)
            ) &&
            (
                DurationMinutes == other.DurationMinutes ||
                DurationMinutes != null &&
                DurationMinutes.SequenceEqual(other.DurationMinutes)
            ) &&
            (
                PayableMinutes == other.PayableMinutes ||
                PayableMinutes != null &&
                PayableMinutes.SequenceEqual(other.PayableMinutes)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                ReviewedDate == other.ReviewedDate ||
                ReviewedDate != null &&
                ReviewedDate.Equals(other.ReviewedDate)
            ) &&
            (
                ReviewedBy == other.ReviewedBy ||
                ReviewedBy != null &&
                ReviewedBy.Equals(other.ReviewedBy)
            ) &&
            (
                SubmittedDate == other.SubmittedDate ||
                SubmittedDate != null &&
                SubmittedDate.Equals(other.SubmittedDate)
            ) &&
            (
                SubmittedBy == other.SubmittedBy ||
                SubmittedBy != null &&
                SubmittedBy.Equals(other.SubmittedBy)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
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

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (IsFullDayRequest != null)
            {
                hash = hash * 59 + IsFullDayRequest.GetHashCode();
            }

            if (MarkedAsRead != null)
            {
                hash = hash * 59 + MarkedAsRead.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (Paid != null)
            {
                hash = hash * 59 + Paid.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Substatus != null)
            {
                hash = hash * 59 + Substatus.GetHashCode();
            }

            if (PartialDayStartDateTimes != null)
            {
                hash = hash * 59 + PartialDayStartDateTimes.GetHashCode();
            }

            if (FullDayManagementUnitDates != null)
            {
                hash = hash * 59 + FullDayManagementUnitDates.GetHashCode();
            }

            if (DailyDurationMinutes != null)
            {
                hash = hash * 59 + DailyDurationMinutes.GetHashCode();
            }

            if (DurationMinutes != null)
            {
                hash = hash * 59 + DurationMinutes.GetHashCode();
            }

            if (PayableMinutes != null)
            {
                hash = hash * 59 + PayableMinutes.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (ReviewedDate != null)
            {
                hash = hash * 59 + ReviewedDate.GetHashCode();
            }

            if (ReviewedBy != null)
            {
                hash = hash * 59 + ReviewedBy.GetHashCode();
            }

            if (SubmittedDate != null)
            {
                hash = hash * 59 + SubmittedDate.GetHashCode();
            }

            if (SubmittedBy != null)
            {
                hash = hash * 59 + SubmittedBy.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            return hash;
        }
    }
}
