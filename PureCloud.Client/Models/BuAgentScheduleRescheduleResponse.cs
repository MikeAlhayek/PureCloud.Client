using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleRescheduleResponse
/// </summary>

public partial class BuAgentScheduleRescheduleResponse : IEquatable<BuAgentScheduleRescheduleResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleRescheduleResponse" /> class.
    /// </summary>
    /// <param name="User">The user to whom this agent schedule applies.</param>
    /// <param name="Shifts">The shift definitions for this agent schedule.</param>
    /// <param name="FullDayTimeOffMarkers">Full day time off markers which apply to this agent schedule.</param>
    /// <param name="WorkPlan">The work plan for this user.</param>
    /// <param name="WorkPlansPerWeek">The work plans per week for this user from the work plan rotation. Null values in the list denotes that user is not part of any work plan for that week.</param>
    public BuAgentScheduleRescheduleResponse(UserReference User = null, List<BuAgentScheduleShift> Shifts = null, List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers = null, WorkPlanReference WorkPlan = null, List<WorkPlanReference> WorkPlansPerWeek = null)
    {
        this.User = User;
        this.Shifts = Shifts;
        this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
        this.WorkPlan = WorkPlan;
        this.WorkPlansPerWeek = WorkPlansPerWeek;

    }



    /// <summary>
    /// The user to whom this agent schedule applies
    /// </summary>
    /// <value>The user to whom this agent schedule applies</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The shift definitions for this agent schedule
    /// </summary>
    /// <value>The shift definitions for this agent schedule</value>
    [JsonPropertyName("shifts")]
    public List<BuAgentScheduleShift> Shifts { get; set; }



    /// <summary>
    /// Full day time off markers which apply to this agent schedule
    /// </summary>
    /// <value>Full day time off markers which apply to this agent schedule</value>
    [JsonPropertyName("fullDayTimeOffMarkers")]
    public List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }



    /// <summary>
    /// The work plan for this user
    /// </summary>
    /// <value>The work plan for this user</value>
    [JsonPropertyName("workPlan")]
    public WorkPlanReference WorkPlan { get; set; }



    /// <summary>
    /// The work plans per week for this user from the work plan rotation. Null values in the list denotes that user is not part of any work plan for that week
    /// </summary>
    /// <value>The work plans per week for this user from the work plan rotation. Null values in the list denotes that user is not part of any work plan for that week</value>
    [JsonPropertyName("workPlansPerWeek")]
    public List<WorkPlanReference> WorkPlansPerWeek { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleRescheduleResponse {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Shifts: ").Append(Shifts).Append("\n");
        sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
        sb.Append("  WorkPlan: ").Append(WorkPlan).Append("\n");
        sb.Append("  WorkPlansPerWeek: ").Append(WorkPlansPerWeek).Append("\n");
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
        return Equals(obj as BuAgentScheduleRescheduleResponse);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleRescheduleResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleRescheduleResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleRescheduleResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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
                WorkPlan == other.WorkPlan ||
                WorkPlan != null &&
                WorkPlan.Equals(other.WorkPlan)
            ) &&
            (
                WorkPlansPerWeek == other.WorkPlansPerWeek ||
                WorkPlansPerWeek != null &&
                WorkPlansPerWeek.SequenceEqual(other.WorkPlansPerWeek)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Shifts != null)
            {
                hash = hash * 59 + Shifts.GetHashCode();
            }

            if (FullDayTimeOffMarkers != null)
            {
                hash = hash * 59 + FullDayTimeOffMarkers.GetHashCode();
            }

            if (WorkPlan != null)
            {
                hash = hash * 59 + WorkPlan.GetHashCode();
            }

            if (WorkPlansPerWeek != null)
            {
                hash = hash * 59 + WorkPlansPerWeek.GetHashCode();
            }

            return hash;
        }
    }
}
