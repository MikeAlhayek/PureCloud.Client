using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlternativeShiftTradeResponse
/// </summary>

public partial class AlternativeShiftTradeResponse : IEquatable<AlternativeShiftTradeResponse>
{
    /// <summary>
    /// The state of this alternative shift trade
    /// </summary>
    /// <value>The state of this alternative shift trade</value>
    
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
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled,

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
        /// Enum Submitted for "Submitted"
        /// </summary>
        [EnumMember(Value = "Submitted")]
        Submitted,

        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved
    }
    /// <summary>
    /// The processing status of this alternative shift trade
    /// </summary>
    /// <value>The processing status of this alternative shift trade</value>
    
    public enum ProcessingStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Waitingforscheduleupdate for "WaitingForScheduleUpdate"
        /// </summary>
        [EnumMember(Value = "WaitingForScheduleUpdate")]
        Waitingforscheduleupdate,

        /// <summary>
        /// Enum Scheduleupdating for "ScheduleUpdating"
        /// </summary>
        [EnumMember(Value = "ScheduleUpdating")]
        Scheduleupdating,

        /// <summary>
        /// Enum Scheduleupdated for "ScheduleUpdated"
        /// </summary>
        [EnumMember(Value = "ScheduleUpdated")]
        Scheduleupdated,

        /// <summary>
        /// Enum Waitingforreview for "WaitingForReview"
        /// </summary>
        [EnumMember(Value = "WaitingForReview")]
        Waitingforreview,

        /// <summary>
        /// Enum Reviewing for "Reviewing"
        /// </summary>
        [EnumMember(Value = "Reviewing")]
        Reviewing
    }
    /// <summary>
    /// Gets or Sets Violations
    /// </summary>
    
    public enum ViolationsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Servicegoalsnotmet for "ServiceGoalsNotMet"
        /// </summary>
        [EnumMember(Value = "ServiceGoalsNotMet")]
        Servicegoalsnotmet
    }
    /// <summary>
    /// The state of this alternative shift trade
    /// </summary>
    /// <value>The state of this alternative shift trade</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// The processing status of this alternative shift trade
    /// </summary>
    /// <value>The processing status of this alternative shift trade</value>
    [JsonPropertyName("processingStatus")]
    public ProcessingStatusEnum? ProcessingStatus { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftTradeResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlternativeShiftTradeResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftTradeResponse" /> class.
    /// </summary>
    /// <param name="ShiftOfferJobId">The job ID of the alternative shift offer listing, from which the trade was chosen (required).</param>
    /// <param name="ExistingShifts">The existing shifts from the offer, may be empty (required).</param>
    /// <param name="OfferedShifts">The offered shifts from the offer, may be empty (required).</param>
    /// <param name="Schedule">The existing schedule information associated with the trade (required).</param>
    /// <param name="ManagementUnit">The management unit of this alternative shift trade request (required).</param>
    /// <param name="User">The user who submitted the trade request (required).</param>
    /// <param name="WeekDate">The start week date of the associated schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="ExpirationDate">The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration.</param>
    /// <param name="State">The state of this alternative shift trade (required).</param>
    /// <param name="ProcessingStatus">The processing status of this alternative shift trade.</param>
    /// <param name="SystemDateReviewed">The timestamp of when the trade request was reviewed by the system in ISO-8601 format.</param>
    /// <param name="AdminDateReviewed">The timestamp of when the trade request was reviewed by an admin in ISO-8601 format.</param>
    /// <param name="AdminReviewedBy">The admin who reviewed this alternative shift trade after system denial.</param>
    /// <param name="Violations">A list of trade match violations (required).</param>
    /// <param name="Metadata">Version metadata for this alternative shift trade (required).</param>
    public AlternativeShiftTradeResponse(string ShiftOfferJobId = null, List<AlternativeShiftAgentScheduledShift> ExistingShifts = null, List<AlternativeShiftAgentScheduledShift> OfferedShifts = null, AlternativeShiftScheduleLookup Schedule = null, ManagementUnitReference ManagementUnit = null, UserReference User = null, string WeekDate = null, DateTime? ExpirationDate = null, StateEnum? State = null, ProcessingStatusEnum? ProcessingStatus = null, DateTime? SystemDateReviewed = null, DateTime? AdminDateReviewed = null, UserReference AdminReviewedBy = null, List<ViolationsEnum> Violations = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.ShiftOfferJobId = ShiftOfferJobId;
        this.ExistingShifts = ExistingShifts;
        this.OfferedShifts = OfferedShifts;
        this.Schedule = Schedule;
        this.ManagementUnit = ManagementUnit;
        this.User = User;
        this.WeekDate = WeekDate;
        this.ExpirationDate = ExpirationDate;
        this.State = State;
        this.ProcessingStatus = ProcessingStatus;
        this.SystemDateReviewed = SystemDateReviewed;
        this.AdminDateReviewed = AdminDateReviewed;
        this.AdminReviewedBy = AdminReviewedBy;
        this.Violations = Violations;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The job ID of the alternative shift offer listing, from which the trade was chosen
    /// </summary>
    /// <value>The job ID of the alternative shift offer listing, from which the trade was chosen</value>
    [JsonPropertyName("shiftOfferJobId")]
    public string ShiftOfferJobId { get; set; }



    /// <summary>
    /// The existing shifts from the offer, may be empty
    /// </summary>
    /// <value>The existing shifts from the offer, may be empty</value>
    [JsonPropertyName("existingShifts")]
    public List<AlternativeShiftAgentScheduledShift> ExistingShifts { get; set; }



    /// <summary>
    /// The offered shifts from the offer, may be empty
    /// </summary>
    /// <value>The offered shifts from the offer, may be empty</value>
    [JsonPropertyName("offeredShifts")]
    public List<AlternativeShiftAgentScheduledShift> OfferedShifts { get; set; }



    /// <summary>
    /// The existing schedule information associated with the trade
    /// </summary>
    /// <value>The existing schedule information associated with the trade</value>
    [JsonPropertyName("schedule")]
    public AlternativeShiftScheduleLookup Schedule { get; set; }



    /// <summary>
    /// The management unit of this alternative shift trade request
    /// </summary>
    /// <value>The management unit of this alternative shift trade request</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// The user who submitted the trade request
    /// </summary>
    /// <value>The user who submitted the trade request</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The start week date of the associated schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start week date of the associated schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekDate")]
    public string WeekDate { get; set; }



    /// <summary>
    /// The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration
    /// </summary>
    /// <value>The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration</value>
    [JsonPropertyName("expirationDate")]
    public DateTime? ExpirationDate { get; set; }







    /// <summary>
    /// The timestamp of when the trade request was reviewed by the system in ISO-8601 format
    /// </summary>
    /// <value>The timestamp of when the trade request was reviewed by the system in ISO-8601 format</value>
    [JsonPropertyName("systemDateReviewed")]
    public DateTime? SystemDateReviewed { get; set; }



    /// <summary>
    /// The timestamp of when the trade request was reviewed by an admin in ISO-8601 format
    /// </summary>
    /// <value>The timestamp of when the trade request was reviewed by an admin in ISO-8601 format</value>
    [JsonPropertyName("adminDateReviewed")]
    public DateTime? AdminDateReviewed { get; set; }



    /// <summary>
    /// The admin who reviewed this alternative shift trade after system denial
    /// </summary>
    /// <value>The admin who reviewed this alternative shift trade after system denial</value>
    [JsonPropertyName("adminReviewedBy")]
    public UserReference AdminReviewedBy { get; set; }



    /// <summary>
    /// A list of trade match violations
    /// </summary>
    /// <value>A list of trade match violations</value>
    [JsonPropertyName("violations")]
    public List<ViolationsEnum> Violations { get; set; }



    /// <summary>
    /// Version metadata for this alternative shift trade
    /// </summary>
    /// <value>Version metadata for this alternative shift trade</value>
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
        sb.Append("class AlternativeShiftTradeResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ShiftOfferJobId: ").Append(ShiftOfferJobId).Append("\n");
        sb.Append("  ExistingShifts: ").Append(ExistingShifts).Append("\n");
        sb.Append("  OfferedShifts: ").Append(OfferedShifts).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  ProcessingStatus: ").Append(ProcessingStatus).Append("\n");
        sb.Append("  SystemDateReviewed: ").Append(SystemDateReviewed).Append("\n");
        sb.Append("  AdminDateReviewed: ").Append(AdminDateReviewed).Append("\n");
        sb.Append("  AdminReviewedBy: ").Append(AdminReviewedBy).Append("\n");
        sb.Append("  Violations: ").Append(Violations).Append("\n");
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
        return Equals(obj as AlternativeShiftTradeResponse);
    }

    /// <summary>
    /// Returns true if AlternativeShiftTradeResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AlternativeShiftTradeResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlternativeShiftTradeResponse other)
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
                ShiftOfferJobId == other.ShiftOfferJobId ||
                ShiftOfferJobId != null &&
                ShiftOfferJobId.Equals(other.ShiftOfferJobId)
            ) &&
            (
                ExistingShifts == other.ExistingShifts ||
                ExistingShifts != null &&
                ExistingShifts.SequenceEqual(other.ExistingShifts)
            ) &&
            (
                OfferedShifts == other.OfferedShifts ||
                OfferedShifts != null &&
                OfferedShifts.SequenceEqual(other.OfferedShifts)
            ) &&
            (
                Schedule == other.Schedule ||
                Schedule != null &&
                Schedule.Equals(other.Schedule)
            ) &&
            (
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
            ) &&
            (
                ExpirationDate == other.ExpirationDate ||
                ExpirationDate != null &&
                ExpirationDate.Equals(other.ExpirationDate)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                ProcessingStatus == other.ProcessingStatus ||
                ProcessingStatus != null &&
                ProcessingStatus.Equals(other.ProcessingStatus)
            ) &&
            (
                SystemDateReviewed == other.SystemDateReviewed ||
                SystemDateReviewed != null &&
                SystemDateReviewed.Equals(other.SystemDateReviewed)
            ) &&
            (
                AdminDateReviewed == other.AdminDateReviewed ||
                AdminDateReviewed != null &&
                AdminDateReviewed.Equals(other.AdminDateReviewed)
            ) &&
            (
                AdminReviewedBy == other.AdminReviewedBy ||
                AdminReviewedBy != null &&
                AdminReviewedBy.Equals(other.AdminReviewedBy)
            ) &&
            (
                Violations == other.Violations ||
                Violations != null &&
                Violations.SequenceEqual(other.Violations)
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

            if (ShiftOfferJobId != null)
            {
                hash = hash * 59 + ShiftOfferJobId.GetHashCode();
            }

            if (ExistingShifts != null)
            {
                hash = hash * 59 + ExistingShifts.GetHashCode();
            }

            if (OfferedShifts != null)
            {
                hash = hash * 59 + OfferedShifts.GetHashCode();
            }

            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (ExpirationDate != null)
            {
                hash = hash * 59 + ExpirationDate.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (ProcessingStatus != null)
            {
                hash = hash * 59 + ProcessingStatus.GetHashCode();
            }

            if (SystemDateReviewed != null)
            {
                hash = hash * 59 + SystemDateReviewed.GetHashCode();
            }

            if (AdminDateReviewed != null)
            {
                hash = hash * 59 + AdminDateReviewed.GetHashCode();
            }

            if (AdminReviewedBy != null)
            {
                hash = hash * 59 + AdminReviewedBy.GetHashCode();
            }

            if (Violations != null)
            {
                hash = hash * 59 + Violations.GetHashCode();
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
