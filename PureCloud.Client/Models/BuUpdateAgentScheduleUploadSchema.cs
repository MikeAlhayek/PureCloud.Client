using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuUpdateAgentScheduleUploadSchema
/// </summary>
[DataContract]
public partial class BuUpdateAgentScheduleUploadSchema : IEquatable<BuUpdateAgentScheduleUploadSchema>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuUpdateAgentScheduleUploadSchema" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuUpdateAgentScheduleUploadSchema() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuUpdateAgentScheduleUploadSchema" /> class.
    /// </summary>
    /// <param name="UserId">The ID of the user to whom this agent schedule applies (required).</param>
    /// <param name="WorkPlanId">The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek.</param>
    /// <param name="WorkPlanIdsPerWeek">The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId.</param>
    /// <param name="Shifts">The shift definitions for this agent schedule.</param>
    /// <param name="FullDayTimeOffMarkers">Any full day time off markers that apply to this agent schedule.</param>
    /// <param name="Metadata">Version metadata for this agent schedule. Required if updating or deleting an existing agent schedule, otherwise should be omitted.</param>
    /// <param name="Delete">Whether to delete this agent&#39;s schedule. Defaults to false if not set.</param>
    public BuUpdateAgentScheduleUploadSchema(string UserId = null, ValueWrapperString WorkPlanId = null, ListWrapperString WorkPlanIdsPerWeek = null, List<BuUpdateAgentScheduleShift> Shifts = null, List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers = null, WfmVersionedEntityMetadata Metadata = null, bool? Delete = null)
    {
        this.UserId = UserId;
        this.WorkPlanId = WorkPlanId;
        this.WorkPlanIdsPerWeek = WorkPlanIdsPerWeek;
        this.Shifts = Shifts;
        this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
        this.Metadata = Metadata;
        this.Delete = Delete;

    }



    /// <summary>
    /// The ID of the user to whom this agent schedule applies
    /// </summary>
    /// <value>The ID of the user to whom this agent schedule applies</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek
    /// </summary>
    /// <value>The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek</value>
    [DataMember(Name = "workPlanId", EmitDefaultValue = false)]
    public ValueWrapperString WorkPlanId { get; set; }



    /// <summary>
    /// The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId
    /// </summary>
    /// <value>The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId</value>
    [DataMember(Name = "workPlanIdsPerWeek", EmitDefaultValue = false)]
    public ListWrapperString WorkPlanIdsPerWeek { get; set; }



    /// <summary>
    /// The shift definitions for this agent schedule
    /// </summary>
    /// <value>The shift definitions for this agent schedule</value>
    [DataMember(Name = "shifts", EmitDefaultValue = false)]
    public List<BuUpdateAgentScheduleShift> Shifts { get; set; }



    /// <summary>
    /// Any full day time off markers that apply to this agent schedule
    /// </summary>
    /// <value>Any full day time off markers that apply to this agent schedule</value>
    [DataMember(Name = "fullDayTimeOffMarkers", EmitDefaultValue = false)]
    public List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }



    /// <summary>
    /// Version metadata for this agent schedule. Required if updating or deleting an existing agent schedule, otherwise should be omitted
    /// </summary>
    /// <value>Version metadata for this agent schedule. Required if updating or deleting an existing agent schedule, otherwise should be omitted</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }



    /// <summary>
    /// Whether to delete this agent&#39;s schedule. Defaults to false if not set
    /// </summary>
    /// <value>Whether to delete this agent&#39;s schedule. Defaults to false if not set</value>
    [DataMember(Name = "delete", EmitDefaultValue = false)]
    public bool? Delete { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuUpdateAgentScheduleUploadSchema {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
        sb.Append("  WorkPlanIdsPerWeek: ").Append(WorkPlanIdsPerWeek).Append("\n");
        sb.Append("  Shifts: ").Append(Shifts).Append("\n");
        sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  Delete: ").Append(Delete).Append("\n");
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
        return Equals(obj as BuUpdateAgentScheduleUploadSchema);
    }

    /// <summary>
    /// Returns true if BuUpdateAgentScheduleUploadSchema instances are equal
    /// </summary>
    /// <param name="other">Instance of BuUpdateAgentScheduleUploadSchema to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuUpdateAgentScheduleUploadSchema other)
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
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                Delete == other.Delete ||
                Delete != null &&
                Delete.Equals(other.Delete)
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

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (Delete != null)
            {
                hash = hash * 59 + Delete.GetHashCode();
            }

            return hash;
        }
    }
}
