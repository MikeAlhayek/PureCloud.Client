using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateAgentTimeOffRequest
/// </summary>
[DataContract]
public partial class CreateAgentTimeOffRequest : IEquatable<CreateAgentTimeOffRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateAgentTimeOffRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateAgentTimeOffRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateAgentTimeOffRequest" /> class.
    /// </summary>
    /// <param name="ActivityCodeId">The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category (required).</param>
    /// <param name="Notes">Notes about the time off request.</param>
    /// <param name="FullDayManagementUnitDates">A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone..</param>
    /// <param name="PartialDayStartDateTimes">A set of start date-times in ISO-8601 format for partial day requests..</param>
    /// <param name="DailyDurationMinutes">The daily duration of this time off request in minutes (required).</param>
    /// <param name="DurationMinutes">Daily durations for each day of this time off request in minutes.</param>
    /// <param name="PayableMinutes">Payable minutes for each day of this time off request.</param>
    public CreateAgentTimeOffRequest(string ActivityCodeId = null, string Notes = null, List<string> FullDayManagementUnitDates = null, List<DateTime?> PartialDayStartDateTimes = null, int? DailyDurationMinutes = null, List<int?> DurationMinutes = null, List<int?> PayableMinutes = null)
    {
        this.ActivityCodeId = ActivityCodeId;
        this.Notes = Notes;
        this.FullDayManagementUnitDates = FullDayManagementUnitDates;
        this.PartialDayStartDateTimes = PartialDayStartDateTimes;
        this.DailyDurationMinutes = DailyDurationMinutes;
        this.DurationMinutes = DurationMinutes;
        this.PayableMinutes = PayableMinutes;

    }



    /// <summary>
    /// The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category
    /// </summary>
    /// <value>The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category</value>
    [DataMember(Name = "activityCodeId", EmitDefaultValue = false)]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Notes about the time off request
    /// </summary>
    /// <value>Notes about the time off request</value>
    [DataMember(Name = "notes", EmitDefaultValue = false)]
    public string Notes { get; set; }



    /// <summary>
    /// A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.
    /// </summary>
    /// <value>A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.</value>
    [DataMember(Name = "fullDayManagementUnitDates", EmitDefaultValue = false)]
    public List<string> FullDayManagementUnitDates { get; set; }



    /// <summary>
    /// A set of start date-times in ISO-8601 format for partial day requests.
    /// </summary>
    /// <value>A set of start date-times in ISO-8601 format for partial day requests.</value>
    [DataMember(Name = "partialDayStartDateTimes", EmitDefaultValue = false)]
    public List<DateTime?> PartialDayStartDateTimes { get; set; }



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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateAgentTimeOffRequest {\n");

        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  FullDayManagementUnitDates: ").Append(FullDayManagementUnitDates).Append("\n");
        sb.Append("  PartialDayStartDateTimes: ").Append(PartialDayStartDateTimes).Append("\n");
        sb.Append("  DailyDurationMinutes: ").Append(DailyDurationMinutes).Append("\n");
        sb.Append("  DurationMinutes: ").Append(DurationMinutes).Append("\n");
        sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
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
        return Equals(obj as CreateAgentTimeOffRequest);
    }

    /// <summary>
    /// Returns true if CreateAgentTimeOffRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateAgentTimeOffRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateAgentTimeOffRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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

            return hash;
        }
    }
}
