using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateAdminTimeOffRequest
/// </summary>

public partial class CreateAdminTimeOffRequest : IEquatable<CreateAdminTimeOffRequest>
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
        Approved
    }
    /// <summary>
    /// The status of this time off request
    /// </summary>
    /// <value>The status of this time off request</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateAdminTimeOffRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateAdminTimeOffRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateAdminTimeOffRequest" /> class.
    /// </summary>
    /// <param name="Status">The status of this time off request (required).</param>
    /// <param name="Users">A set of IDs for users to associate with this time off request (required).</param>
    /// <param name="ActivityCodeId">The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category (required).</param>
    /// <param name="Notes">Notes about the time off request.</param>
    /// <param name="FullDayManagementUnitDates">A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone..</param>
    /// <param name="PartialDayStartDateTimes">A set of start date-times in ISO-8601 format for partial day requests..</param>
    /// <param name="DailyDurationMinutes">The daily duration of this time off request in minutes (required).</param>
    /// <param name="DurationMinutes">Daily durations for each day of this time off request in minutes.</param>
    /// <param name="PayableMinutes">Payable minutes for each day of this time off request.</param>
    /// <param name="Paid">Whether this is a paid time off request.</param>
    public CreateAdminTimeOffRequest(StatusEnum? Status = null, List<UserReference> Users = null, string ActivityCodeId = null, string Notes = null, List<string> FullDayManagementUnitDates = null, List<DateTime?> PartialDayStartDateTimes = null, int? DailyDurationMinutes = null, List<int?> DurationMinutes = null, List<int?> PayableMinutes = null, bool? Paid = null)
    {
        this.Status = Status;
        this.Users = Users;
        this.ActivityCodeId = ActivityCodeId;
        this.Notes = Notes;
        this.FullDayManagementUnitDates = FullDayManagementUnitDates;
        this.PartialDayStartDateTimes = PartialDayStartDateTimes;
        this.DailyDurationMinutes = DailyDurationMinutes;
        this.DurationMinutes = DurationMinutes;
        this.PayableMinutes = PayableMinutes;
        this.Paid = Paid;

    }





    /// <summary>
    /// A set of IDs for users to associate with this time off request
    /// </summary>
    /// <value>A set of IDs for users to associate with this time off request</value>
    [JsonPropertyName("users")]
    public List<UserReference> Users { get; set; }



    /// <summary>
    /// The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category
    /// </summary>
    /// <value>The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Notes about the time off request
    /// </summary>
    /// <value>Notes about the time off request</value>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }



    /// <summary>
    /// A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.
    /// </summary>
    /// <value>A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.</value>
    [JsonPropertyName("fullDayManagementUnitDates")]
    public List<string> FullDayManagementUnitDates { get; set; }



    /// <summary>
    /// A set of start date-times in ISO-8601 format for partial day requests.
    /// </summary>
    /// <value>A set of start date-times in ISO-8601 format for partial day requests.</value>
    [JsonPropertyName("partialDayStartDateTimes")]
    public List<DateTime?> PartialDayStartDateTimes { get; set; }



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
    /// Whether this is a paid time off request
    /// </summary>
    /// <value>Whether this is a paid time off request</value>
    [JsonPropertyName("paid")]
    public bool? Paid { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateAdminTimeOffRequest {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Users: ").Append(Users).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  FullDayManagementUnitDates: ").Append(FullDayManagementUnitDates).Append("\n");
        sb.Append("  PartialDayStartDateTimes: ").Append(PartialDayStartDateTimes).Append("\n");
        sb.Append("  DailyDurationMinutes: ").Append(DailyDurationMinutes).Append("\n");
        sb.Append("  DurationMinutes: ").Append(DurationMinutes).Append("\n");
        sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
        sb.Append("  Paid: ").Append(Paid).Append("\n");
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
        return Equals(obj as CreateAdminTimeOffRequest);
    }

    /// <summary>
    /// Returns true if CreateAdminTimeOffRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateAdminTimeOffRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateAdminTimeOffRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Users == other.Users ||
                Users != null &&
                Users.SequenceEqual(other.Users)
            ) &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                FullDayManagementUnitDates == other.FullDayManagementUnitDates ||
                FullDayManagementUnitDates != null &&
                FullDayManagementUnitDates.SequenceEqual(other.FullDayManagementUnitDates)
            ) &&
            (
                PartialDayStartDateTimes == other.PartialDayStartDateTimes ||
                PartialDayStartDateTimes != null &&
                PartialDayStartDateTimes.SequenceEqual(other.PartialDayStartDateTimes)
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
                Paid == other.Paid ||
                Paid != null &&
                Paid.Equals(other.Paid)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Users != null)
            {
                hash = hash * 59 + Users.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (FullDayManagementUnitDates != null)
            {
                hash = hash * 59 + FullDayManagementUnitDates.GetHashCode();
            }

            if (PartialDayStartDateTimes != null)
            {
                hash = hash * 59 + PartialDayStartDateTimes.GetHashCode();
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

            if (Paid != null)
            {
                hash = hash * 59 + Paid.GetHashCode();
            }

            return hash;
        }
    }
}
