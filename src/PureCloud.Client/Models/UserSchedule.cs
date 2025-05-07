using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserSchedule
/// </summary>

public partial class UserSchedule : IEquatable<UserSchedule>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UserSchedule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserSchedule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserSchedule" /> class.
    /// </summary>
    /// <param name="Shifts">The shifts that belong to this schedule.</param>
    /// <param name="FullDayTimeOffMarkers">Markers to indicate a full day time off request, relative to the management unit time zone.</param>
    /// <param name="Delete">If marked true for updating an existing user schedule, it will be deleted.</param>
    /// <param name="Metadata">Version metadata for this schedule (required).</param>
    public UserSchedule(List<UserScheduleShift> Shifts = null, List<UserScheduleFullDayTimeOffMarker> FullDayTimeOffMarkers = null, bool? Delete = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Shifts = Shifts;
        this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
        this.Delete = Delete;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The shifts that belong to this schedule
    /// </summary>
    /// <value>The shifts that belong to this schedule</value>
    [JsonPropertyName("shifts")]
    public List<UserScheduleShift> Shifts { get; set; }



    /// <summary>
    /// Markers to indicate a full day time off request, relative to the management unit time zone
    /// </summary>
    /// <value>Markers to indicate a full day time off request, relative to the management unit time zone</value>
    [JsonPropertyName("fullDayTimeOffMarkers")]
    public List<UserScheduleFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }



    /// <summary>
    /// If marked true for updating an existing user schedule, it will be deleted
    /// </summary>
    /// <value>If marked true for updating an existing user schedule, it will be deleted</value>
    [JsonPropertyName("delete")]
    public bool? Delete { get; set; }



    /// <summary>
    /// Version metadata for this schedule
    /// </summary>
    /// <value>Version metadata for this schedule</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }



    /// <summary>
    /// ID of the work plan associated with the user during schedule creation
    /// </summary>
    /// <value>ID of the work plan associated with the user during schedule creation</value>
    [JsonPropertyName("workPlanId")]
    public string WorkPlanId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserSchedule {\n");

        sb.Append("  Shifts: ").Append(Shifts).Append("\n");
        sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
        sb.Append("  Delete: ").Append(Delete).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
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
        return Equals(obj as UserSchedule);
    }

    /// <summary>
    /// Returns true if UserSchedule instances are equal
    /// </summary>
    /// <param name="other">Instance of UserSchedule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserSchedule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Delete == other.Delete ||
                Delete != null &&
                Delete.Equals(other.Delete)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                WorkPlanId == other.WorkPlanId ||
                WorkPlanId != null &&
                WorkPlanId.Equals(other.WorkPlanId)
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
            if (Shifts != null)
            {
                hash = hash * 59 + Shifts.GetHashCode();
            }

            if (FullDayTimeOffMarkers != null)
            {
                hash = hash * 59 + FullDayTimeOffMarkers.GetHashCode();
            }

            if (Delete != null)
            {
                hash = hash * 59 + Delete.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (WorkPlanId != null)
            {
                hash = hash * 59 + WorkPlanId.GetHashCode();
            }

            return hash;
        }
    }
}
