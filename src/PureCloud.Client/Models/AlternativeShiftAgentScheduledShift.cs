using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlternativeShiftAgentScheduledShift
/// </summary>

public partial class AlternativeShiftAgentScheduledShift : IEquatable<AlternativeShiftAgentScheduledShift>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftAgentScheduledShift" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlternativeShiftAgentScheduledShift() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftAgentScheduledShift" /> class.
    /// </summary>
    /// <param name="DayIndex">The number of days since start of schedule (required).</param>
    /// <param name="ReferenceKey">A key generated for an offer to help facilitate alternative shift trading (required).</param>
    /// <param name="StartDate">The start date of this shift in ISO-8601 format (required).</param>
    /// <param name="LengthMinutes">The length of this shift in minutes (required).</param>
    /// <param name="Activities">A list of activities in this shift (required).</param>
    public AlternativeShiftAgentScheduledShift(int? DayIndex = null, string ReferenceKey = null, DateTime? StartDate = null, int? LengthMinutes = null, List<BuAgentScheduleActivity> Activities = null)
    {
        this.DayIndex = DayIndex;
        this.ReferenceKey = ReferenceKey;
        this.StartDate = StartDate;
        this.LengthMinutes = LengthMinutes;
        this.Activities = Activities;

    }



    /// <summary>
    /// The number of days since start of schedule
    /// </summary>
    /// <value>The number of days since start of schedule</value>
    [JsonPropertyName("dayIndex")]
    public int? DayIndex { get; set; }



    /// <summary>
    /// A key generated for an offer to help facilitate alternative shift trading
    /// </summary>
    /// <value>A key generated for an offer to help facilitate alternative shift trading</value>
    [JsonPropertyName("referenceKey")]
    public string ReferenceKey { get; set; }



    /// <summary>
    /// The start date of this shift in ISO-8601 format
    /// </summary>
    /// <value>The start date of this shift in ISO-8601 format</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The length of this shift in minutes
    /// </summary>
    /// <value>The length of this shift in minutes</value>
    [JsonPropertyName("lengthMinutes")]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// A list of activities in this shift
    /// </summary>
    /// <value>A list of activities in this shift</value>
    [JsonPropertyName("activities")]
    public List<BuAgentScheduleActivity> Activities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlternativeShiftAgentScheduledShift {\n");

        sb.Append("  DayIndex: ").Append(DayIndex).Append("\n");
        sb.Append("  ReferenceKey: ").Append(ReferenceKey).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Activities: ").Append(Activities).Append("\n");
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
        return Equals(obj as AlternativeShiftAgentScheduledShift);
    }

    /// <summary>
    /// Returns true if AlternativeShiftAgentScheduledShift instances are equal
    /// </summary>
    /// <param name="other">Instance of AlternativeShiftAgentScheduledShift to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlternativeShiftAgentScheduledShift other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DayIndex == other.DayIndex ||
                DayIndex != null &&
                DayIndex.Equals(other.DayIndex)
            ) &&
            (
                ReferenceKey == other.ReferenceKey ||
                ReferenceKey != null &&
                ReferenceKey.Equals(other.ReferenceKey)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                Activities == other.Activities ||
                Activities != null &&
                Activities.SequenceEqual(other.Activities)
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
            if (DayIndex != null)
            {
                hash = hash * 59 + DayIndex.GetHashCode();
            }

            if (ReferenceKey != null)
            {
                hash = hash * 59 + ReferenceKey.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (Activities != null)
            {
                hash = hash * 59 + Activities.GetHashCode();
            }

            return hash;
        }
    }
}
