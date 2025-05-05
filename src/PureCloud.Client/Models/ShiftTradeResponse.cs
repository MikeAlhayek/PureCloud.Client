using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ShiftTradeResponse
/// </summary>

public partial class ShiftTradeResponse : IEquatable<ShiftTradeResponse>
{
    /// <summary>
    /// The state of this shift trade
    /// </summary>
    /// <value>The state of this shift trade</value>
    
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
    /// The state of this shift trade
    /// </summary>
    /// <value>The state of this shift trade</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftTradeResponse" /> class.
    /// </summary>
    /// <param name="Id">The ID of this shift trade.</param>
    /// <param name="WeekDate">The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="Schedule">A reference to the associated schedule.</param>
    /// <param name="State">The state of this shift trade.</param>
    /// <param name="InitiatingUser">The user who initiated this trade.</param>
    /// <param name="InitiatingShiftId">The ID of the shift offered for trade by the initiating user.</param>
    /// <param name="InitiatingShiftStart">The start date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="InitiatingShiftEnd">The end date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ReceivingUser">The user matching the trade, or if the state is not &#39;Matched&#39;, the user to whom the trade request was sent.</param>
    /// <param name="ReceivingShiftId">The ID of the shift being exchanged for the initiating shift, null if the receiving user is picking up a shift.</param>
    /// <param name="ReceivingShiftStart">The start date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ReceivingShiftEnd">The end date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Expiration">When this shift trade offer will expire if not matched or approved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="OneSided">Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return).</param>
    /// <param name="AcceptableIntervals">Time frames when the initiating user is willing to accept trades. Empty means giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    /// <param name="ReviewedBy">The user who reviewed this shift trade. The id may be &#39;System&#39; if it was an automated process.</param>
    /// <param name="ReviewedDate">The timestamp when this shift trade was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Metadata">Version data for this trade.</param>
    public ShiftTradeResponse(string Id = null, string WeekDate = null, BuScheduleReferenceForMuRoute Schedule = null, StateEnum? State = null, UserReference InitiatingUser = null, string InitiatingShiftId = null, DateTime? InitiatingShiftStart = null, DateTime? InitiatingShiftEnd = null, UserReference ReceivingUser = null, string ReceivingShiftId = null, DateTime? ReceivingShiftStart = null, DateTime? ReceivingShiftEnd = null, DateTime? Expiration = null, bool? OneSided = null, List<string> AcceptableIntervals = null, UserReference ReviewedBy = null, DateTime? ReviewedDate = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Id = Id;
        this.WeekDate = WeekDate;
        this.Schedule = Schedule;
        this.State = State;
        this.InitiatingUser = InitiatingUser;
        this.InitiatingShiftId = InitiatingShiftId;
        this.InitiatingShiftStart = InitiatingShiftStart;
        this.InitiatingShiftEnd = InitiatingShiftEnd;
        this.ReceivingUser = ReceivingUser;
        this.ReceivingShiftId = ReceivingShiftId;
        this.ReceivingShiftStart = ReceivingShiftStart;
        this.ReceivingShiftEnd = ReceivingShiftEnd;
        this.Expiration = Expiration;
        this.OneSided = OneSided;
        this.AcceptableIntervals = AcceptableIntervals;
        this.ReviewedBy = ReviewedBy;
        this.ReviewedDate = ReviewedDate;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The ID of this shift trade
    /// </summary>
    /// <value>The ID of this shift trade</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekDate")]
    public string WeekDate { get; set; }



    /// <summary>
    /// A reference to the associated schedule
    /// </summary>
    /// <value>A reference to the associated schedule</value>
    [JsonPropertyName("schedule")]
    public BuScheduleReferenceForMuRoute Schedule { get; set; }





    /// <summary>
    /// The user who initiated this trade
    /// </summary>
    /// <value>The user who initiated this trade</value>
    [JsonPropertyName("initiatingUser")]
    public UserReference InitiatingUser { get; set; }



    /// <summary>
    /// The ID of the shift offered for trade by the initiating user
    /// </summary>
    /// <value>The ID of the shift offered for trade by the initiating user</value>
    [JsonPropertyName("initiatingShiftId")]
    public string InitiatingShiftId { get; set; }



    /// <summary>
    /// The start date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("initiatingShiftStart")]
    public DateTime? InitiatingShiftStart { get; set; }



    /// <summary>
    /// The end date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("initiatingShiftEnd")]
    public DateTime? InitiatingShiftEnd { get; set; }



    /// <summary>
    /// The user matching the trade, or if the state is not &#39;Matched&#39;, the user to whom the trade request was sent
    /// </summary>
    /// <value>The user matching the trade, or if the state is not &#39;Matched&#39;, the user to whom the trade request was sent</value>
    [JsonPropertyName("receivingUser")]
    public UserReference ReceivingUser { get; set; }



    /// <summary>
    /// The ID of the shift being exchanged for the initiating shift, null if the receiving user is picking up a shift
    /// </summary>
    /// <value>The ID of the shift being exchanged for the initiating shift, null if the receiving user is picking up a shift</value>
    [JsonPropertyName("receivingShiftId")]
    public string ReceivingShiftId { get; set; }



    /// <summary>
    /// The start date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("receivingShiftStart")]
    public DateTime? ReceivingShiftStart { get; set; }



    /// <summary>
    /// The end date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("receivingShiftEnd")]
    public DateTime? ReceivingShiftEnd { get; set; }



    /// <summary>
    /// When this shift trade offer will expire if not matched or approved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When this shift trade offer will expire if not matched or approved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("expiration")]
    public DateTime? Expiration { get; set; }



    /// <summary>
    /// Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return)
    /// </summary>
    /// <value>Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return)</value>
    [JsonPropertyName("oneSided")]
    public bool? OneSided { get; set; }



    /// <summary>
    /// Time frames when the initiating user is willing to accept trades. Empty means giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Time frames when the initiating user is willing to accept trades. Empty means giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("acceptableIntervals")]
    public List<string> AcceptableIntervals { get; set; }



    /// <summary>
    /// The user who reviewed this shift trade. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The user who reviewed this shift trade. The id may be &#39;System&#39; if it was an automated process</value>
    [JsonPropertyName("reviewedBy")]
    public UserReference ReviewedBy { get; set; }



    /// <summary>
    /// The timestamp when this shift trade was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this shift trade was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("reviewedDate")]
    public DateTime? ReviewedDate { get; set; }



    /// <summary>
    /// Version data for this trade
    /// </summary>
    /// <value>Version data for this trade</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShiftTradeResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitiatingUser: ").Append(InitiatingUser).Append("\n");
        sb.Append("  InitiatingShiftId: ").Append(InitiatingShiftId).Append("\n");
        sb.Append("  InitiatingShiftStart: ").Append(InitiatingShiftStart).Append("\n");
        sb.Append("  InitiatingShiftEnd: ").Append(InitiatingShiftEnd).Append("\n");
        sb.Append("  ReceivingUser: ").Append(ReceivingUser).Append("\n");
        sb.Append("  ReceivingShiftId: ").Append(ReceivingShiftId).Append("\n");
        sb.Append("  ReceivingShiftStart: ").Append(ReceivingShiftStart).Append("\n");
        sb.Append("  ReceivingShiftEnd: ").Append(ReceivingShiftEnd).Append("\n");
        sb.Append("  Expiration: ").Append(Expiration).Append("\n");
        sb.Append("  OneSided: ").Append(OneSided).Append("\n");
        sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
        sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
        sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
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
        return Equals(obj as ShiftTradeResponse);
    }

    /// <summary>
    /// Returns true if ShiftTradeResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ShiftTradeResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShiftTradeResponse other)
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
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
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
                InitiatingUser == other.InitiatingUser ||
                InitiatingUser != null &&
                InitiatingUser.Equals(other.InitiatingUser)
            ) &&
            (
                InitiatingShiftId == other.InitiatingShiftId ||
                InitiatingShiftId != null &&
                InitiatingShiftId.Equals(other.InitiatingShiftId)
            ) &&
            (
                InitiatingShiftStart == other.InitiatingShiftStart ||
                InitiatingShiftStart != null &&
                InitiatingShiftStart.Equals(other.InitiatingShiftStart)
            ) &&
            (
                InitiatingShiftEnd == other.InitiatingShiftEnd ||
                InitiatingShiftEnd != null &&
                InitiatingShiftEnd.Equals(other.InitiatingShiftEnd)
            ) &&
            (
                ReceivingUser == other.ReceivingUser ||
                ReceivingUser != null &&
                ReceivingUser.Equals(other.ReceivingUser)
            ) &&
            (
                ReceivingShiftId == other.ReceivingShiftId ||
                ReceivingShiftId != null &&
                ReceivingShiftId.Equals(other.ReceivingShiftId)
            ) &&
            (
                ReceivingShiftStart == other.ReceivingShiftStart ||
                ReceivingShiftStart != null &&
                ReceivingShiftStart.Equals(other.ReceivingShiftStart)
            ) &&
            (
                ReceivingShiftEnd == other.ReceivingShiftEnd ||
                ReceivingShiftEnd != null &&
                ReceivingShiftEnd.Equals(other.ReceivingShiftEnd)
            ) &&
            (
                Expiration == other.Expiration ||
                Expiration != null &&
                Expiration.Equals(other.Expiration)
            ) &&
            (
                OneSided == other.OneSided ||
                OneSided != null &&
                OneSided.Equals(other.OneSided)
            ) &&
            (
                AcceptableIntervals == other.AcceptableIntervals ||
                AcceptableIntervals != null &&
                AcceptableIntervals.SequenceEqual(other.AcceptableIntervals)
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

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (InitiatingUser != null)
            {
                hash = hash * 59 + InitiatingUser.GetHashCode();
            }

            if (InitiatingShiftId != null)
            {
                hash = hash * 59 + InitiatingShiftId.GetHashCode();
            }

            if (InitiatingShiftStart != null)
            {
                hash = hash * 59 + InitiatingShiftStart.GetHashCode();
            }

            if (InitiatingShiftEnd != null)
            {
                hash = hash * 59 + InitiatingShiftEnd.GetHashCode();
            }

            if (ReceivingUser != null)
            {
                hash = hash * 59 + ReceivingUser.GetHashCode();
            }

            if (ReceivingShiftId != null)
            {
                hash = hash * 59 + ReceivingShiftId.GetHashCode();
            }

            if (ReceivingShiftStart != null)
            {
                hash = hash * 59 + ReceivingShiftStart.GetHashCode();
            }

            if (ReceivingShiftEnd != null)
            {
                hash = hash * 59 + ReceivingShiftEnd.GetHashCode();
            }

            if (Expiration != null)
            {
                hash = hash * 59 + Expiration.GetHashCode();
            }

            if (OneSided != null)
            {
                hash = hash * 59 + OneSided.GetHashCode();
            }

            if (AcceptableIntervals != null)
            {
                hash = hash * 59 + AcceptableIntervals.GetHashCode();
            }

            if (ReviewedBy != null)
            {
                hash = hash * 59 + ReviewedBy.GetHashCode();
            }

            if (ReviewedDate != null)
            {
                hash = hash * 59 + ReviewedDate.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
