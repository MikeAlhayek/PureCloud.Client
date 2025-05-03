using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleHistoryDeletedChange
/// </summary>

public partial class BuAgentScheduleHistoryDeletedChange : IEquatable<BuAgentScheduleHistoryDeletedChange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleHistoryDeletedChange" /> class.
    /// </summary>
    /// <param name="ShiftIds">The IDs of deleted shifts.</param>
    /// <param name="FullDayTimeOffMarkerDates">The dates of any deleted full day time off markers.</param>
    /// <param name="AgentSchedule">Whether the entire agent schedule was deleted.</param>
    public BuAgentScheduleHistoryDeletedChange(List<string> ShiftIds = null, List<string> FullDayTimeOffMarkerDates = null, bool? AgentSchedule = null)
    {
        this.ShiftIds = ShiftIds;
        this.FullDayTimeOffMarkerDates = FullDayTimeOffMarkerDates;
        this.AgentSchedule = AgentSchedule;

    }



    /// <summary>
    /// The IDs of deleted shifts
    /// </summary>
    /// <value>The IDs of deleted shifts</value>
    [JsonPropertyName("shiftIds")]
    public List<string> ShiftIds { get; set; }



    /// <summary>
    /// The dates of any deleted full day time off markers
    /// </summary>
    /// <value>The dates of any deleted full day time off markers</value>
    [JsonPropertyName("fullDayTimeOffMarkerDates")]
    public List<string> FullDayTimeOffMarkerDates { get; set; }



    /// <summary>
    /// Whether the entire agent schedule was deleted
    /// </summary>
    /// <value>Whether the entire agent schedule was deleted</value>
    [JsonPropertyName("agentSchedule")]
    public bool? AgentSchedule { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleHistoryDeletedChange {\n");

        sb.Append("  ShiftIds: ").Append(ShiftIds).Append("\n");
        sb.Append("  FullDayTimeOffMarkerDates: ").Append(FullDayTimeOffMarkerDates).Append("\n");
        sb.Append("  AgentSchedule: ").Append(AgentSchedule).Append("\n");
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
        return Equals(obj as BuAgentScheduleHistoryDeletedChange);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleHistoryDeletedChange instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleHistoryDeletedChange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleHistoryDeletedChange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ShiftIds == other.ShiftIds ||
                ShiftIds != null &&
                ShiftIds.SequenceEqual(other.ShiftIds)
            ) &&
            (
                FullDayTimeOffMarkerDates == other.FullDayTimeOffMarkerDates ||
                FullDayTimeOffMarkerDates != null &&
                FullDayTimeOffMarkerDates.SequenceEqual(other.FullDayTimeOffMarkerDates)
            ) &&
            (
                AgentSchedule == other.AgentSchedule ||
                AgentSchedule != null &&
                AgentSchedule.Equals(other.AgentSchedule)
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
            if (ShiftIds != null)
            {
                hash = hash * 59 + ShiftIds.GetHashCode();
            }

            if (FullDayTimeOffMarkerDates != null)
            {
                hash = hash * 59 + FullDayTimeOffMarkerDates.GetHashCode();
            }

            if (AgentSchedule != null)
            {
                hash = hash * 59 + AgentSchedule.GetHashCode();
            }

            return hash;
        }
    }
}
