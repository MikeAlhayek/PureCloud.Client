using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffRequestResponse
/// </summary>
[DataContract]
public partial class TimeOffRequestResponse : IEquatable<TimeOffRequestResponse>
{
    /// <summary>
    /// The status of this time off request
    /// </summary>
    /// <value>The status of this time off request</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The substatus of this time off request
    /// </summary>
    /// <value>The substatus of this time off request</value>
    [DataMember(Name = "substatus", EmitDefaultValue = false)]
    public SubstatusEnum? Substatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffRequestResponse" /> class.
    /// </summary>
    /// <param name="User">The user associated with this time off request.</param>
    /// <param name="IsFullDayRequest">Whether this is a full day request (false means partial day).</param>
    /// <param name="MarkedAsRead">Whether this request has been marked as read by the agent.</param>
    /// <param name="ActivityCodeId">The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category.</param>
    /// <param name="Paid">Whether this is a paid time off request.</param>
    /// <param name="Status">The status of this time off request.</param>
    /// <param name="Substatus">The substatus of this time off request.</param>
    /// <param name="PartialDayStartDateTimes">A set of start date-times in ISO-8601 format for partial day requests. Will be not empty if isFullDayRequest &#x3D;&#x3D; false.</param>
    /// <param name="FullDayManagementUnitDates">A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone. Will be not empty if isFullDayRequest &#x3D;&#x3D; true.</param>
    /// <param name="DailyDurationMinutes">The daily duration of this time off request in minutes.</param>
    /// <param name="DurationMinutes">Daily durations for each day of this time off request in minutes.</param>
    /// <param name="PayableMinutes">Payable minutes for each day of this time off request.</param>
    /// <param name="Notes">Notes about the time off request.</param>
    /// <param name="SubmittedBy">The user who submitted this time off request. The id may be &#39;System&#39; if it was an automated process.</param>
    /// <param name="SubmittedDate">The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ReviewedBy">The user who reviewed this time off request. The id may be &#39;System&#39; if it was an automated process.</param>
    /// <param name="ReviewedDate">The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedBy">The user who last modified this TimeOffRequestResponse.</param>
    /// <param name="ModifiedDate">The timestamp when this request was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SyncVersion">The sync version of this time off request for which the scheduled activity is associated.</param>
    /// <param name="Metadata">The version metadata of the time off request.</param>
    public TimeOffRequestResponse(UserReference User = null, bool? IsFullDayRequest = null, bool? MarkedAsRead = null, string ActivityCodeId = null, bool? Paid = null, StatusEnum? Status = null, SubstatusEnum? Substatus = null, List<DateTime?> PartialDayStartDateTimes = null, List<string> FullDayManagementUnitDates = null, int? DailyDurationMinutes = null, List<int?> DurationMinutes = null, List<int?> PayableMinutes = null, string Notes = null, UserReference SubmittedBy = null, DateTime? SubmittedDate = null, UserReference ReviewedBy = null, DateTime? ReviewedDate = null, UserReference ModifiedBy = null, DateTime? ModifiedDate = null, int? SyncVersion = null, WfmVersionedEntityMetadata Metadata = null)
    {
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
        this.ModifiedBy = ModifiedBy;
        this.ModifiedDate = ModifiedDate;
        this.SyncVersion = SyncVersion;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The user associated with this time off request
    /// </summary>
    /// <value>The user associated with this time off request</value>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public UserReference User { get; set; }



    /// <summary>
    /// Whether this is a full day request (false means partial day)
    /// </summary>
    /// <value>Whether this is a full day request (false means partial day)</value>
    [DataMember(Name = "isFullDayRequest", EmitDefaultValue = false)]
    public bool? IsFullDayRequest { get; set; }



    /// <summary>
    /// Whether this request has been marked as read by the agent
    /// </summary>
    /// <value>Whether this request has been marked as read by the agent</value>
    [DataMember(Name = "markedAsRead", EmitDefaultValue = false)]
    public bool? MarkedAsRead { get; set; }



    /// <summary>
    /// The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category
    /// </summary>
    /// <value>The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category</value>
    [DataMember(Name = "activityCodeId", EmitDefaultValue = false)]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Whether this is a paid time off request
    /// </summary>
    /// <value>Whether this is a paid time off request</value>
    [DataMember(Name = "paid", EmitDefaultValue = false)]
    public bool? Paid { get; set; }







    /// <summary>
    /// A set of start date-times in ISO-8601 format for partial day requests. Will be not empty if isFullDayRequest &#x3D;&#x3D; false
    /// </summary>
    /// <value>A set of start date-times in ISO-8601 format for partial day requests. Will be not empty if isFullDayRequest &#x3D;&#x3D; false</value>
    [DataMember(Name = "partialDayStartDateTimes", EmitDefaultValue = false)]
    public List<DateTime?> PartialDayStartDateTimes { get; set; }



    /// <summary>
    /// A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone. Will be not empty if isFullDayRequest &#x3D;&#x3D; true
    /// </summary>
    /// <value>A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone. Will be not empty if isFullDayRequest &#x3D;&#x3D; true</value>
    [DataMember(Name = "fullDayManagementUnitDates", EmitDefaultValue = false)]
    public List<string> FullDayManagementUnitDates { get; set; }



    /// <summary>
    /// The daily duration of this time off request in minutes
    /// </summary>
    /// <value>The daily duration of this time off request in minutes</value>
    [DataMember(Name = "dailyDurationMinutes", EmitDefaultValue = false)]
    public int? DailyDurationMinutes { get; set; }



    /// <summary>
    /// Daily durations for each day of this time off request in minutes
    /// </summary>
    /// <value>Daily durations for each day of this time off request in minutes</value>
    [DataMember(Name = "durationMinutes", EmitDefaultValue = false)]
    public List<int?> DurationMinutes { get; set; }



    /// <summary>
    /// Payable minutes for each day of this time off request
    /// </summary>
    /// <value>Payable minutes for each day of this time off request</value>
    [DataMember(Name = "payableMinutes", EmitDefaultValue = false)]
    public List<int?> PayableMinutes { get; set; }



    /// <summary>
    /// Notes about the time off request
    /// </summary>
    /// <value>Notes about the time off request</value>
    [DataMember(Name = "notes", EmitDefaultValue = false)]
    public string Notes { get; set; }



    /// <summary>
    /// The user who submitted this time off request. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The user who submitted this time off request. The id may be &#39;System&#39; if it was an automated process</value>
    [DataMember(Name = "submittedBy", EmitDefaultValue = false)]
    public UserReference SubmittedBy { get; set; }



    /// <summary>
    /// The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "submittedDate", EmitDefaultValue = false)]
    public DateTime? SubmittedDate { get; set; }



    /// <summary>
    /// The user who reviewed this time off request. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The user who reviewed this time off request. The id may be &#39;System&#39; if it was an automated process</value>
    [DataMember(Name = "reviewedBy", EmitDefaultValue = false)]
    public UserReference ReviewedBy { get; set; }



    /// <summary>
    /// The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "reviewedDate", EmitDefaultValue = false)]
    public DateTime? ReviewedDate { get; set; }



    /// <summary>
    /// The user who last modified this TimeOffRequestResponse
    /// </summary>
    /// <value>The user who last modified this TimeOffRequestResponse</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The timestamp when this request was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this request was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// The sync version of this time off request for which the scheduled activity is associated
    /// </summary>
    /// <value>The sync version of this time off request for which the scheduled activity is associated</value>
    [DataMember(Name = "syncVersion", EmitDefaultValue = false)]
    public int? SyncVersion { get; set; }



    /// <summary>
    /// The version metadata of the time off request
    /// </summary>
    /// <value>The version metadata of the time off request</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }



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
        sb.Append("class TimeOffRequestResponse {\n");

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
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return this.Equals(obj as TimeOffRequestResponse);
    }

    /// <summary>
    /// Returns true if TimeOffRequestResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffRequestResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffRequestResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.User == other.User ||
                this.User != null &&
                this.User.Equals(other.User)
            ) &&
            (
                this.IsFullDayRequest == other.IsFullDayRequest ||
                this.IsFullDayRequest != null &&
                this.IsFullDayRequest.Equals(other.IsFullDayRequest)
            ) &&
            (
                this.MarkedAsRead == other.MarkedAsRead ||
                this.MarkedAsRead != null &&
                this.MarkedAsRead.Equals(other.MarkedAsRead)
            ) &&
            (
                this.ActivityCodeId == other.ActivityCodeId ||
                this.ActivityCodeId != null &&
                this.ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                this.Paid == other.Paid ||
                this.Paid != null &&
                this.Paid.Equals(other.Paid)
            ) &&
            (
                this.Status == other.Status ||
                this.Status != null &&
                this.Status.Equals(other.Status)
            ) &&
            (
                this.Substatus == other.Substatus ||
                this.Substatus != null &&
                this.Substatus.Equals(other.Substatus)
            ) &&
            (
                this.PartialDayStartDateTimes == other.PartialDayStartDateTimes ||
                this.PartialDayStartDateTimes != null &&
                this.PartialDayStartDateTimes.SequenceEqual(other.PartialDayStartDateTimes)
            ) &&
            (
                this.FullDayManagementUnitDates == other.FullDayManagementUnitDates ||
                this.FullDayManagementUnitDates != null &&
                this.FullDayManagementUnitDates.SequenceEqual(other.FullDayManagementUnitDates)
            ) &&
            (
                this.DailyDurationMinutes == other.DailyDurationMinutes ||
                this.DailyDurationMinutes != null &&
                this.DailyDurationMinutes.Equals(other.DailyDurationMinutes)
            ) &&
            (
                this.DurationMinutes == other.DurationMinutes ||
                this.DurationMinutes != null &&
                this.DurationMinutes.SequenceEqual(other.DurationMinutes)
            ) &&
            (
                this.PayableMinutes == other.PayableMinutes ||
                this.PayableMinutes != null &&
                this.PayableMinutes.SequenceEqual(other.PayableMinutes)
            ) &&
            (
                this.Notes == other.Notes ||
                this.Notes != null &&
                this.Notes.Equals(other.Notes)
            ) &&
            (
                this.SubmittedBy == other.SubmittedBy ||
                this.SubmittedBy != null &&
                this.SubmittedBy.Equals(other.SubmittedBy)
            ) &&
            (
                this.SubmittedDate == other.SubmittedDate ||
                this.SubmittedDate != null &&
                this.SubmittedDate.Equals(other.SubmittedDate)
            ) &&
            (
                this.ReviewedBy == other.ReviewedBy ||
                this.ReviewedBy != null &&
                this.ReviewedBy.Equals(other.ReviewedBy)
            ) &&
            (
                this.ReviewedDate == other.ReviewedDate ||
                this.ReviewedDate != null &&
                this.ReviewedDate.Equals(other.ReviewedDate)
            ) &&
            (
                this.ModifiedBy == other.ModifiedBy ||
                this.ModifiedBy != null &&
                this.ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                this.ModifiedDate == other.ModifiedDate ||
                this.ModifiedDate != null &&
                this.ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                this.SyncVersion == other.SyncVersion ||
                this.SyncVersion != null &&
                this.SyncVersion.Equals(other.SyncVersion)
            ) &&
            (
                this.Metadata == other.Metadata ||
                this.Metadata != null &&
                this.Metadata.Equals(other.Metadata)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.User != null)
            {
                hash = hash * 59 + this.User.GetHashCode();
            }

            if (this.IsFullDayRequest != null)
            {
                hash = hash * 59 + this.IsFullDayRequest.GetHashCode();
            }

            if (this.MarkedAsRead != null)
            {
                hash = hash * 59 + this.MarkedAsRead.GetHashCode();
            }

            if (this.ActivityCodeId != null)
            {
                hash = hash * 59 + this.ActivityCodeId.GetHashCode();
            }

            if (this.Paid != null)
            {
                hash = hash * 59 + this.Paid.GetHashCode();
            }

            if (this.Status != null)
            {
                hash = hash * 59 + this.Status.GetHashCode();
            }

            if (this.Substatus != null)
            {
                hash = hash * 59 + this.Substatus.GetHashCode();
            }

            if (this.PartialDayStartDateTimes != null)
            {
                hash = hash * 59 + this.PartialDayStartDateTimes.GetHashCode();
            }

            if (this.FullDayManagementUnitDates != null)
            {
                hash = hash * 59 + this.FullDayManagementUnitDates.GetHashCode();
            }

            if (this.DailyDurationMinutes != null)
            {
                hash = hash * 59 + this.DailyDurationMinutes.GetHashCode();
            }

            if (this.DurationMinutes != null)
            {
                hash = hash * 59 + this.DurationMinutes.GetHashCode();
            }

            if (this.PayableMinutes != null)
            {
                hash = hash * 59 + this.PayableMinutes.GetHashCode();
            }

            if (this.Notes != null)
            {
                hash = hash * 59 + this.Notes.GetHashCode();
            }

            if (this.SubmittedBy != null)
            {
                hash = hash * 59 + this.SubmittedBy.GetHashCode();
            }

            if (this.SubmittedDate != null)
            {
                hash = hash * 59 + this.SubmittedDate.GetHashCode();
            }

            if (this.ReviewedBy != null)
            {
                hash = hash * 59 + this.ReviewedBy.GetHashCode();
            }

            if (this.ReviewedDate != null)
            {
                hash = hash * 59 + this.ReviewedDate.GetHashCode();
            }

            if (this.ModifiedBy != null)
            {
                hash = hash * 59 + this.ModifiedBy.GetHashCode();
            }

            if (this.ModifiedDate != null)
            {
                hash = hash * 59 + this.ModifiedDate.GetHashCode();
            }

            if (this.SyncVersion != null)
            {
                hash = hash * 59 + this.SyncVersion.GetHashCode();
            }

            if (this.Metadata != null)
            {
                hash = hash * 59 + this.Metadata.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
