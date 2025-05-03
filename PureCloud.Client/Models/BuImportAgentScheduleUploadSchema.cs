using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuImportAgentScheduleUploadSchema
/// </summary>

public partial class BuImportAgentScheduleUploadSchema : IEquatable<BuImportAgentScheduleUploadSchema>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuImportAgentScheduleUploadSchema" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuImportAgentScheduleUploadSchema() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuImportAgentScheduleUploadSchema" /> class.
    /// </summary>
    /// <param name="UserId">The ID of the user to whom this agent schedule applies (required).</param>
    /// <param name="WorkPlanId">The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek.</param>
    /// <param name="WorkPlanIdsPerWeek">The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId.</param>
    /// <param name="Shifts">The shift definitions for this agent schedule.</param>
    /// <param name="FullDayTimeOffMarkers">Any full day time off markers that apply to this agent schedule.</param>
    public BuImportAgentScheduleUploadSchema(string UserId = null, ValueWrapperString WorkPlanId = null, ListWrapperString WorkPlanIdsPerWeek = null, List<BuAgentScheduleShiftRequest> Shifts = null, List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers = null)
    {
        this.UserId = UserId;
        this.WorkPlanId = WorkPlanId;
        this.WorkPlanIdsPerWeek = WorkPlanIdsPerWeek;
        this.Shifts = Shifts;
        this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;

    }



    /// <summary>
    /// The ID of the user to whom this agent schedule applies
    /// </summary>
    /// <value>The ID of the user to whom this agent schedule applies</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek
    /// </summary>
    /// <value>The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek</value>
    [JsonPropertyName("workPlanId")]
    public ValueWrapperString WorkPlanId { get; set; }



    /// <summary>
    /// The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId
    /// </summary>
    /// <value>The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId</value>
    [JsonPropertyName("workPlanIdsPerWeek")]
    public ListWrapperString WorkPlanIdsPerWeek { get; set; }



    /// <summary>
    /// The shift definitions for this agent schedule
    /// </summary>
    /// <value>The shift definitions for this agent schedule</value>
    [JsonPropertyName("shifts")]
    public List<BuAgentScheduleShiftRequest> Shifts { get; set; }



    /// <summary>
    /// Any full day time off markers that apply to this agent schedule
    /// </summary>
    /// <value>Any full day time off markers that apply to this agent schedule</value>
    [JsonPropertyName("fullDayTimeOffMarkers")]
    public List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuImportAgentScheduleUploadSchema {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
        sb.Append("  WorkPlanIdsPerWeek: ").Append(WorkPlanIdsPerWeek).Append("\n");
        sb.Append("  Shifts: ").Append(Shifts).Append("\n");
        sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
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
        return Equals(obj as BuImportAgentScheduleUploadSchema);
    }

    /// <summary>
    /// Returns true if BuImportAgentScheduleUploadSchema instances are equal
    /// </summary>
    /// <param name="other">Instance of BuImportAgentScheduleUploadSchema to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuImportAgentScheduleUploadSchema other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                WorkPlanId == other.WorkPlanId ||
                WorkPlanId != null &&
                WorkPlanId.Equals(other.WorkPlanId)
            ) &&
            (
                WorkPlanIdsPerWeek == other.WorkPlanIdsPerWeek ||
                WorkPlanIdsPerWeek != null &&
                WorkPlanIdsPerWeek.Equals(other.WorkPlanIdsPerWeek)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (WorkPlanId != null)
            {
                hash = hash * 59 + WorkPlanId.GetHashCode();
            }

            if (WorkPlanIdsPerWeek != null)
            {
                hash = hash * 59 + WorkPlanIdsPerWeek.GetHashCode();
            }

            if (Shifts != null)
            {
                hash = hash * 59 + Shifts.GetHashCode();
            }

            if (FullDayTimeOffMarkers != null)
            {
                hash = hash * 59 + FullDayTimeOffMarkers.GetHashCode();
            }

            return hash;
        }
    }
}
