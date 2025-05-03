using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleHistoryResponse
/// </summary>

public partial class BuAgentScheduleHistoryResponse : IEquatable<BuAgentScheduleHistoryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleHistoryResponse" /> class.
    /// </summary>
    /// <param name="PriorPublishedSchedules">The list of previously published schedules.</param>
    /// <param name="BasePublishedSchedule">The originally published agent schedules.</param>
    /// <param name="DroppedChanges">The changes dropped from the schedule history. This will happen if the schedule history is too large.</param>
    /// <param name="Changes">The list of changes for the schedule history.</param>
    public BuAgentScheduleHistoryResponse(List<BuScheduleReference> PriorPublishedSchedules = null, BuAgentScheduleHistoryChange BasePublishedSchedule = null, List<BuAgentScheduleHistoryDroppedChange> DroppedChanges = null, List<BuAgentScheduleHistoryChange> Changes = null)
    {
        this.PriorPublishedSchedules = PriorPublishedSchedules;
        this.BasePublishedSchedule = BasePublishedSchedule;
        this.DroppedChanges = DroppedChanges;
        this.Changes = Changes;

    }



    /// <summary>
    /// The list of previously published schedules
    /// </summary>
    /// <value>The list of previously published schedules</value>
    [JsonPropertyName("priorPublishedSchedules")]
    public List<BuScheduleReference> PriorPublishedSchedules { get; set; }



    /// <summary>
    /// The originally published agent schedules
    /// </summary>
    /// <value>The originally published agent schedules</value>
    [JsonPropertyName("basePublishedSchedule")]
    public BuAgentScheduleHistoryChange BasePublishedSchedule { get; set; }



    /// <summary>
    /// The changes dropped from the schedule history. This will happen if the schedule history is too large
    /// </summary>
    /// <value>The changes dropped from the schedule history. This will happen if the schedule history is too large</value>
    [JsonPropertyName("droppedChanges")]
    public List<BuAgentScheduleHistoryDroppedChange> DroppedChanges { get; set; }



    /// <summary>
    /// The list of changes for the schedule history
    /// </summary>
    /// <value>The list of changes for the schedule history</value>
    [JsonPropertyName("changes")]
    public List<BuAgentScheduleHistoryChange> Changes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleHistoryResponse {\n");

        sb.Append("  PriorPublishedSchedules: ").Append(PriorPublishedSchedules).Append("\n");
        sb.Append("  BasePublishedSchedule: ").Append(BasePublishedSchedule).Append("\n");
        sb.Append("  DroppedChanges: ").Append(DroppedChanges).Append("\n");
        sb.Append("  Changes: ").Append(Changes).Append("\n");
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
        return Equals(obj as BuAgentScheduleHistoryResponse);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleHistoryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleHistoryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleHistoryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PriorPublishedSchedules == other.PriorPublishedSchedules ||
                PriorPublishedSchedules != null &&
                PriorPublishedSchedules.SequenceEqual(other.PriorPublishedSchedules)
            ) &&
            (
                BasePublishedSchedule == other.BasePublishedSchedule ||
                BasePublishedSchedule != null &&
                BasePublishedSchedule.Equals(other.BasePublishedSchedule)
            ) &&
            (
                DroppedChanges == other.DroppedChanges ||
                DroppedChanges != null &&
                DroppedChanges.SequenceEqual(other.DroppedChanges)
            ) &&
            (
                Changes == other.Changes ||
                Changes != null &&
                Changes.SequenceEqual(other.Changes)
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
            if (PriorPublishedSchedules != null)
            {
                hash = hash * 59 + PriorPublishedSchedules.GetHashCode();
            }

            if (BasePublishedSchedule != null)
            {
                hash = hash * 59 + BasePublishedSchedule.GetHashCode();
            }

            if (DroppedChanges != null)
            {
                hash = hash * 59 + DroppedChanges.GetHashCode();
            }

            if (Changes != null)
            {
                hash = hash * 59 + Changes.GetHashCode();
            }

            return hash;
        }
    }
}
