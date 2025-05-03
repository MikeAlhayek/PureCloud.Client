using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffRequest
/// </summary>

public partial class TimeOffRequest : IEquatable<TimeOffRequest>
{
    /// <summary>
    /// The status of this time off request
    /// </summary>
    /// <value>The status of this time off request</value>
    
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
    /// The substatus of this time off request
    /// </summary>
    /// <value>The substatus of this time off request</value>
    
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
        /// Enum Removedfromwaitlist for "RemovedFromWaitlist"
        /// </summary>
        [EnumMember(Value = "RemovedFromWaitlist")]
        Removedfromwaitlist,

        /// <summary>
        /// Enum Waitlisted for "Waitlisted"
        /// </summary>
        [EnumMember(Value = "Waitlisted")]
        Waitlisted,

        /// <summary>
        /// Enum Overlapsrestrictedactivitycode for "OverlapsRestrictedActivityCode"
        /// </summary>
        [EnumMember(Value = "OverlapsRestrictedActivityCode")]
        Overlapsrestrictedactivitycode
    }
    /// <summary>
    /// The status of this time off request
    /// </summary>
    /// <value>The status of this time off request</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The substatus of this time off request
    /// </summary>
    /// <value>The substatus of this time off request</value>
    [JsonPropertyName("substatus")]
    public SubstatusEnum? Substatus { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TimeOffRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffRequest" /> class.
    /// </summary>
    /// <param name="Id">The id of the time off request (required).</param>
    /// <param name="User">The user that the time off request belongs to (required).</param>
    /// <param name="IsFullDayRequest">Whether this is a full day request (false means partial day).</param>
    /// <param name="MarkedAsRead">Whether this request has been marked as read by the agent.</param>
    /// <param name="ActivityCodeId">The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category.</param>
    /// <param name="Paid">Whether this is a paid time off request.</param>
    /// <param name="Status">The status of this time off request.</param>
    /// <param name="Substatus">The substatus of this time off request.</param>
    /// <param name="PartialDayStartDateTimes">A set of start date-times in ISO-8601 format for partial day requests.  Will be not empty if isFullDayRequest &#x3D;&#x3D; false.</param>
    /// <param name="FullDayManagementUnitDates">A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.  Will be not empty if isFullDayRequest &#x3D;&#x3D; true.</param>
    /// <param name="DailyDurationMinutes">The daily duration of this time off request in minutes.</param>
    /// <param name="DurationMinutes">Daily durations for each day of this time off request in minutes.</param>
    /// <param name="PayableMinutes">Payable minutes for each day of this time off request.</param>
    /// <param name="Notes">Notes about the time off request.</param>
    /// <param name="SubmittedBy">The user who submitted this time off request. The id may be &#39;System&#39; if it was an automated process.</param>
    /// <param name="SubmittedDate">The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ReviewedBy">The user who reviewed this time off request. The id may be &#39;System&#39; if it was an automated process.</param>
    /// <param name="ReviewedDate">The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SyncVersion">The sync version of this time off request for which the scheduled activity is associated.</param>
    /// <param name="Metadata">The version metadata of the time off request.</param>
    public TimeOffRequest(string Id = null, UserReference User = null, bool? IsFullDayRequest = null, bool? MarkedAsRead = null, string ActivityCodeId = null, bool? Paid = null, StatusEnum? Status = null, SubstatusEnum? Substatus = null, List<DateTime?> PartialDayStartDateTimes = null, List<string> FullDayManagementUnitDates = null, int? DailyDurationMinutes = null, List<int?> DurationMinutes = null, List<int?> PayableMinutes = null, string Notes = null, UserReference SubmittedBy = null, DateTime? SubmittedDate = null, UserReference ReviewedBy = null, DateTime? ReviewedDate = null, int? SyncVersion = null, WfmVersionedEntityMetadata Metadata = null)
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
        this.SubmittedBy = SubmittedBy;
        this.SubmittedDate = SubmittedDate;
        this.ReviewedBy = ReviewedBy;
        this.ReviewedDate = ReviewedDate;
        this.SyncVersion = SyncVersion;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The id of the time off request
    /// </summary>
    /// <value>The id of the time off request</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The user that the time off request belongs to
    /// </summary>
    /// <value>The user that the time off request belongs to</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// Whether this is a full day request (false means partial day)
    /// </summary>
    /// <value>Whether this is a full day request (false means partial day)</value>
    [JsonPropertyName("isFullDayRequest")]
    public bool? IsFullDayRequest { get; set; }



    /// <summary>
    /// Whether this request has been marked as read by the agent
    /// </summary>
    /// <value>Whether this request has been marked as read by the agent</value>
    [JsonPropertyName("markedAsRead")]
    public bool? MarkedAsRead { get; set; }



    /// <summary>
    /// The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category
    /// </summary>
    /// <value>The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Whether this is a paid time off request
    /// </summary>
    /// <value>Whether this is a paid time off request</value>
    [JsonPropertyName("paid")]
    public bool? Paid { get; set; }







    /// <summary>
    /// A set of start date-times in ISO-8601 format for partial day requests.  Will be not empty if isFullDayRequest &#x3D;&#x3D; false
    /// </summary>
    /// <value>A set of start date-times in ISO-8601 format for partial day requests.  Will be not empty if isFullDayRequest &#x3D;&#x3D; false</value>
    [JsonPropertyName("partialDayStartDateTimes")]
    public List<DateTime?> PartialDayStartDateTimes { get; set; }



    /// <summary>
    /// A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.  Will be not empty if isFullDayRequest &#x3D;&#x3D; true
    /// </summary>
    /// <value>A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.  Will be not empty if isFullDayRequest &#x3D;&#x3D; true</value>
    [JsonPropertyName("fullDayManagementUnitDates")]
    public List<string> FullDayManagementUnitDates { get; set; }



    /// <summary>
    /// The daily duration of this time off request in minutes
    /// </summary>
    /// <value>The daily duration of this time off request in minutes</value>
    [JsonPropertyName("dailyDurationMinutes")]
    public int? DailyDurationMinutes { get; set; }



    /// <summary>
    /// Daily durations for each day of this time off request in minutes
    /// </summary>
    /// <value>Daily durations for each day of this time off request in minutes</value>
    [JsonPropertyName("durationMinutes")]
    public List<int?> DurationMinutes { get; set; }



    /// <summary>
    /// Payable minutes for each day of this time off request
    /// </summary>
    /// <value>Payable minutes for each day of this time off request</value>
    [JsonPropertyName("payableMinutes")]
    public List<int?> PayableMinutes { get; set; }



    /// <summary>
    /// Notes about the time off request
    /// </summary>
    /// <value>Notes about the time off request</value>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }



    /// <summary>
    /// The user who submitted this time off request. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The user who submitted this time off request. The id may be &#39;System&#39; if it was an automated process</value>
    [JsonPropertyName("submittedBy")]
    public UserReference SubmittedBy { get; set; }



    /// <summary>
    /// The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("submittedDate")]
    public DateTime? SubmittedDate { get; set; }



    /// <summary>
    /// The user who reviewed this time off request. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The user who reviewed this time off request. The id may be &#39;System&#39; if it was an automated process</value>
    [JsonPropertyName("reviewedBy")]
    public UserReference ReviewedBy { get; set; }



    /// <summary>
    /// The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("reviewedDate")]
    public DateTime? ReviewedDate { get; set; }



    /// <summary>
    /// The sync version of this time off request for which the scheduled activity is associated
    /// </summary>
    /// <value>The sync version of this time off request for which the scheduled activity is associated</value>
    [JsonPropertyName("syncVersion")]
    public int? SyncVersion { get; set; }



    /// <summary>
    /// The version metadata of the time off request
    /// </summary>
    /// <value>The version metadata of the time off request</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffRequest {\n");

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
        sb.Append("  SubmittedBy: ").Append(SubmittedBy).Append("\n");
        sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
        sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
        sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
        sb.Append("  SyncVersion: ").Append(SyncVersion).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as TimeOffRequest);
    }

    /// <summary>
    /// Returns true if TimeOffRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffRequest other)
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
                SubmittedBy == other.SubmittedBy ||
                SubmittedBy != null &&
                SubmittedBy.Equals(other.SubmittedBy)
            ) &&
            (
                SubmittedDate == other.SubmittedDate ||
                SubmittedDate != null &&
                SubmittedDate.Equals(other.SubmittedDate)
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
                SyncVersion == other.SyncVersion ||
                SyncVersion != null &&
                SyncVersion.Equals(other.SyncVersion)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (SubmittedBy != null)
            {
                hash = hash * 59 + SubmittedBy.GetHashCode();
            }

            if (SubmittedDate != null)
            {
                hash = hash * 59 + SubmittedDate.GetHashCode();
            }

            if (ReviewedBy != null)
            {
                hash = hash * 59 + ReviewedBy.GetHashCode();
            }

            if (ReviewedDate != null)
            {
                hash = hash * 59 + ReviewedDate.GetHashCode();
            }

            if (SyncVersion != null)
            {
                hash = hash * 59 + SyncVersion.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
