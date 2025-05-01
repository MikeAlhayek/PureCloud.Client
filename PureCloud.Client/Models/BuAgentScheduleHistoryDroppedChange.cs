using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleHistoryDroppedChange
/// </summary>
[DataContract]
public partial class BuAgentScheduleHistoryDroppedChange : IEquatable<BuAgentScheduleHistoryDroppedChange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleHistoryDroppedChange" /> class.
    /// </summary>
    /// <param name="Metadata">The metadata of the change, including who and when the change was made.</param>
    /// <param name="ShiftIds">The IDs of deleted shifts.</param>
    /// <param name="FullDayTimeOffMarkerDates">The dates of any deleted full day time off markers.</param>
    /// <param name="Deletes">The deleted shifts, full day time off markers, or the entire agent schedule.</param>
    public BuAgentScheduleHistoryDroppedChange(BuAgentScheduleHistoryChangeMetadata Metadata = null, List<string> ShiftIds = null, List<string> FullDayTimeOffMarkerDates = null, BuAgentScheduleHistoryDeletedChange Deletes = null)
    {
        this.Metadata = Metadata;
        this.ShiftIds = ShiftIds;
        this.FullDayTimeOffMarkerDates = FullDayTimeOffMarkerDates;
        this.Deletes = Deletes;

    }



    /// <summary>
    /// The metadata of the change, including who and when the change was made
    /// </summary>
    /// <value>The metadata of the change, including who and when the change was made</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public BuAgentScheduleHistoryChangeMetadata Metadata { get; set; }



    /// <summary>
    /// The IDs of deleted shifts
    /// </summary>
    /// <value>The IDs of deleted shifts</value>
    [DataMember(Name = "shiftIds", EmitDefaultValue = false)]
    public List<string> ShiftIds { get; set; }



    /// <summary>
    /// The dates of any deleted full day time off markers
    /// </summary>
    /// <value>The dates of any deleted full day time off markers</value>
    [DataMember(Name = "fullDayTimeOffMarkerDates", EmitDefaultValue = false)]
    public List<string> FullDayTimeOffMarkerDates { get; set; }



    /// <summary>
    /// The deleted shifts, full day time off markers, or the entire agent schedule
    /// </summary>
    /// <value>The deleted shifts, full day time off markers, or the entire agent schedule</value>
    [DataMember(Name = "deletes", EmitDefaultValue = false)]
    public BuAgentScheduleHistoryDeletedChange Deletes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleHistoryDroppedChange {\n");

        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  ShiftIds: ").Append(ShiftIds).Append("\n");
        sb.Append("  FullDayTimeOffMarkerDates: ").Append(FullDayTimeOffMarkerDates).Append("\n");
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
        return Equals(obj as BuAgentScheduleHistoryDroppedChange);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleHistoryDroppedChange instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleHistoryDroppedChange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleHistoryDroppedChange other)
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

            if (ShiftIds != null)
            {
                hash = hash * 59 + ShiftIds.GetHashCode();
            }

            if (FullDayTimeOffMarkerDates != null)
            {
                hash = hash * 59 + FullDayTimeOffMarkerDates.GetHashCode();
            }

            if (Deletes != null)
            {
                hash = hash * 59 + Deletes.GetHashCode();
            }

            return hash;
        }
    }
}
