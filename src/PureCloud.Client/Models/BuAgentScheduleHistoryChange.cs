using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleHistoryChange
/// </summary>

public partial class BuAgentScheduleHistoryChange : IEquatable<BuAgentScheduleHistoryChange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleHistoryChange" /> class.
    /// </summary>
    /// <param name="Metadata">The metadata of the change, including who and when the change was made.</param>
    /// <param name="Shifts">The list of changed shifts.</param>
    /// <param name="FullDayTimeOffMarkers">The list of changed full day time off markers.</param>
    /// <param name="Deletes">The deleted shifts, full day time off markers, or the entire agent schedule.</param>
    public BuAgentScheduleHistoryChange(BuAgentScheduleHistoryChangeMetadata Metadata = null, List<BuAgentScheduleShift> Shifts = null, List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers = null, BuAgentScheduleHistoryDeletedChange Deletes = null)
    {
        this.Metadata = Metadata;
        this.Shifts = Shifts;
        this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
        this.Deletes = Deletes;

    }



    /// <summary>
    /// The metadata of the change, including who and when the change was made
    /// </summary>
    /// <value>The metadata of the change, including who and when the change was made</value>
    [JsonPropertyName("metadata")]
    public BuAgentScheduleHistoryChangeMetadata Metadata { get; set; }



    /// <summary>
    /// The list of changed shifts
    /// </summary>
    /// <value>The list of changed shifts</value>
    [JsonPropertyName("shifts")]
    public List<BuAgentScheduleShift> Shifts { get; set; }



    /// <summary>
    /// The list of changed full day time off markers
    /// </summary>
    /// <value>The list of changed full day time off markers</value>
    [JsonPropertyName("fullDayTimeOffMarkers")]
    public List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }



    /// <summary>
    /// The deleted shifts, full day time off markers, or the entire agent schedule
    /// </summary>
    /// <value>The deleted shifts, full day time off markers, or the entire agent schedule</value>
    [JsonPropertyName("deletes")]
    public BuAgentScheduleHistoryDeletedChange Deletes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleHistoryChange {\n");

        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  Shifts: ").Append(Shifts).Append("\n");
        sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
        sb.Append("  Deletes: ").Append(Deletes).Append("\n");
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
        return Equals(obj as BuAgentScheduleHistoryChange);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleHistoryChange instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleHistoryChange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleHistoryChange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                Shifts == other.Shifts ||
                Shifts != null &&
                Shifts.SequenceEqual(other.Shifts)
            ) &&
            (
                FullDayTimeOffMarkers == other.FullDayTimeOffMarkers ||
                FullDayTimeOffMarkers != null &&
                FullDayTimeOffMarkers.SequenceEqual(other.FullDayTimeOffMarkers)
            ) &&
            (
                Deletes == other.Deletes ||
                Deletes != null &&
                Deletes.Equals(other.Deletes)
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
            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (Shifts != null)
            {
                hash = hash * 59 + Shifts.GetHashCode();
            }

            if (FullDayTimeOffMarkers != null)
            {
                hash = hash * 59 + FullDayTimeOffMarkers.GetHashCode();
            }

            if (Deletes != null)
            {
                hash = hash * 59 + Deletes.GetHashCode();
            }

            return hash;
        }
    }
}
