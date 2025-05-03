using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentPossibleWorkShiftsResponse
/// </summary>

public partial class AgentPossibleWorkShiftsResponse : IEquatable<AgentPossibleWorkShiftsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentPossibleWorkShiftsResponse" /> class.
    /// </summary>
    /// <param name="WeekStartDate">Start date of requested effective work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="Pattern">Each element is the ID of an effective work plan for a specific week.</param>
    /// <param name="WeeklyPossibleWorkShifts">Each element is a weekly effective work plan that can be used for multiple weeks.</param>
    /// <param name="SchedulerIntervalLengthMinutes">Number of minutes in each interval in the intervalScheduleProbabilities.</param>
    /// <param name="TimeZone">The time zone of the business unit.</param>
    public AgentPossibleWorkShiftsResponse(string WeekStartDate = null, List<int?> Pattern = null, List<PossibleWorkShiftsForWeek> WeeklyPossibleWorkShifts = null, int? SchedulerIntervalLengthMinutes = null, string TimeZone = null)
    {
        this.WeekStartDate = WeekStartDate;
        this.Pattern = Pattern;
        this.WeeklyPossibleWorkShifts = WeeklyPossibleWorkShifts;
        this.SchedulerIntervalLengthMinutes = SchedulerIntervalLengthMinutes;
        this.TimeZone = TimeZone;

    }



    /// <summary>
    /// Start date of requested effective work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start date of requested effective work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekStartDate")]
    public string WeekStartDate { get; set; }



    /// <summary>
    /// Each element is the ID of an effective work plan for a specific week
    /// </summary>
    /// <value>Each element is the ID of an effective work plan for a specific week</value>
    [JsonPropertyName("pattern")]
    public List<int?> Pattern { get; set; }



    /// <summary>
    /// Each element is a weekly effective work plan that can be used for multiple weeks
    /// </summary>
    /// <value>Each element is a weekly effective work plan that can be used for multiple weeks</value>
    [JsonPropertyName("weeklyPossibleWorkShifts")]
    public List<PossibleWorkShiftsForWeek> WeeklyPossibleWorkShifts { get; set; }



    /// <summary>
    /// Number of minutes in each interval in the intervalScheduleProbabilities
    /// </summary>
    /// <value>Number of minutes in each interval in the intervalScheduleProbabilities</value>
    [JsonPropertyName("schedulerIntervalLengthMinutes")]
    public int? SchedulerIntervalLengthMinutes { get; set; }



    /// <summary>
    /// The time zone of the business unit
    /// </summary>
    /// <value>The time zone of the business unit</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentPossibleWorkShiftsResponse {\n");

        sb.Append("  WeekStartDate: ").Append(WeekStartDate).Append("\n");
        sb.Append("  Pattern: ").Append(Pattern).Append("\n");
        sb.Append("  WeeklyPossibleWorkShifts: ").Append(WeeklyPossibleWorkShifts).Append("\n");
        sb.Append("  SchedulerIntervalLengthMinutes: ").Append(SchedulerIntervalLengthMinutes).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
        return Equals(obj as AgentPossibleWorkShiftsResponse);
    }

    /// <summary>
    /// Returns true if AgentPossibleWorkShiftsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentPossibleWorkShiftsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentPossibleWorkShiftsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WeekStartDate == other.WeekStartDate ||
                WeekStartDate != null &&
                WeekStartDate.Equals(other.WeekStartDate)
            ) &&
            (
                Pattern == other.Pattern ||
                Pattern != null &&
                Pattern.SequenceEqual(other.Pattern)
            ) &&
            (
                WeeklyPossibleWorkShifts == other.WeeklyPossibleWorkShifts ||
                WeeklyPossibleWorkShifts != null &&
                WeeklyPossibleWorkShifts.SequenceEqual(other.WeeklyPossibleWorkShifts)
            ) &&
            (
                SchedulerIntervalLengthMinutes == other.SchedulerIntervalLengthMinutes ||
                SchedulerIntervalLengthMinutes != null &&
                SchedulerIntervalLengthMinutes.Equals(other.SchedulerIntervalLengthMinutes)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
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
            if (WeekStartDate != null)
            {
                hash = hash * 59 + WeekStartDate.GetHashCode();
            }

            if (Pattern != null)
            {
                hash = hash * 59 + Pattern.GetHashCode();
            }

            if (WeeklyPossibleWorkShifts != null)
            {
                hash = hash * 59 + WeeklyPossibleWorkShifts.GetHashCode();
            }

            if (SchedulerIntervalLengthMinutes != null)
            {
                hash = hash * 59 + SchedulerIntervalLengthMinutes.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            return hash;
        }
    }
}
