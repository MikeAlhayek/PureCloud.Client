using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ReschedulingOptionsRunResponse
/// </summary>
[DataContract]
public partial class ReschedulingOptionsRunResponse : IEquatable<ReschedulingOptionsRunResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReschedulingOptionsRunResponse" /> class.
    /// </summary>
    /// <param name="ExistingSchedule">The existing schedule to which this reschedule run applies.</param>
    /// <param name="StartDate">The start date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndDate">The end date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ManagementUnits">Per-management unit rescheduling options.</param>
    /// <param name="AgentCount">The number of agents to be considered in the reschedule.</param>
    /// <param name="ActivityCodeIds">The IDs of the activity codes being considered for reschedule.</param>
    /// <param name="DoNotChangeWeeklyPaidTime">Whether weekly paid time is allowed to be changed.</param>
    /// <param name="DoNotChangeDailyPaidTime">Whether daily paid time is allowed to be changed.</param>
    /// <param name="DoNotChangeShiftStartTimes">Whether shift start times are allowed to be changed.</param>
    /// <param name="DoNotChangeManuallyEditedShifts">Whether manually edited shifts are allowed to be changed.</param>
    public ReschedulingOptionsRunResponse(BuScheduleReference ExistingSchedule = null, DateTime? StartDate = null, DateTime? EndDate = null, List<ReschedulingManagementUnitResponse> ManagementUnits = null, int? AgentCount = null, List<string> ActivityCodeIds = null, bool? DoNotChangeWeeklyPaidTime = null, bool? DoNotChangeDailyPaidTime = null, bool? DoNotChangeShiftStartTimes = null, bool? DoNotChangeManuallyEditedShifts = null)
    {
        this.ExistingSchedule = ExistingSchedule;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.ManagementUnits = ManagementUnits;
        this.AgentCount = AgentCount;
        this.ActivityCodeIds = ActivityCodeIds;
        this.DoNotChangeWeeklyPaidTime = DoNotChangeWeeklyPaidTime;
        this.DoNotChangeDailyPaidTime = DoNotChangeDailyPaidTime;
        this.DoNotChangeShiftStartTimes = DoNotChangeShiftStartTimes;
        this.DoNotChangeManuallyEditedShifts = DoNotChangeManuallyEditedShifts;

    }



    /// <summary>
    /// The existing schedule to which this reschedule run applies
    /// </summary>
    /// <value>The existing schedule to which this reschedule run applies</value>
    [DataMember(Name = "existingSchedule", EmitDefaultValue = false)]
    public BuScheduleReference ExistingSchedule { get; set; }



    /// <summary>
    /// The start date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The end date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// Per-management unit rescheduling options
    /// </summary>
    /// <value>Per-management unit rescheduling options</value>
    [DataMember(Name = "managementUnits", EmitDefaultValue = false)]
    public List<ReschedulingManagementUnitResponse> ManagementUnits { get; set; }



    /// <summary>
    /// The number of agents to be considered in the reschedule
    /// </summary>
    /// <value>The number of agents to be considered in the reschedule</value>
    [DataMember(Name = "agentCount", EmitDefaultValue = false)]
    public int? AgentCount { get; set; }



    /// <summary>
    /// The IDs of the activity codes being considered for reschedule
    /// </summary>
    /// <value>The IDs of the activity codes being considered for reschedule</value>
    [DataMember(Name = "activityCodeIds", EmitDefaultValue = false)]
    public List<string> ActivityCodeIds { get; set; }



    /// <summary>
    /// Whether weekly paid time is allowed to be changed
    /// </summary>
    /// <value>Whether weekly paid time is allowed to be changed</value>
    [DataMember(Name = "doNotChangeWeeklyPaidTime", EmitDefaultValue = false)]
    public bool? DoNotChangeWeeklyPaidTime { get; set; }



    /// <summary>
    /// Whether daily paid time is allowed to be changed
    /// </summary>
    /// <value>Whether daily paid time is allowed to be changed</value>
    [DataMember(Name = "doNotChangeDailyPaidTime", EmitDefaultValue = false)]
    public bool? DoNotChangeDailyPaidTime { get; set; }



    /// <summary>
    /// Whether shift start times are allowed to be changed
    /// </summary>
    /// <value>Whether shift start times are allowed to be changed</value>
    [DataMember(Name = "doNotChangeShiftStartTimes", EmitDefaultValue = false)]
    public bool? DoNotChangeShiftStartTimes { get; set; }



    /// <summary>
    /// Whether manually edited shifts are allowed to be changed
    /// </summary>
    /// <value>Whether manually edited shifts are allowed to be changed</value>
    [DataMember(Name = "doNotChangeManuallyEditedShifts", EmitDefaultValue = false)]
    public bool? DoNotChangeManuallyEditedShifts { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReschedulingOptionsRunResponse {\n");

        sb.Append("  ExistingSchedule: ").Append(ExistingSchedule).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
        sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
        sb.Append("  ActivityCodeIds: ").Append(ActivityCodeIds).Append("\n");
        sb.Append("  DoNotChangeWeeklyPaidTime: ").Append(DoNotChangeWeeklyPaidTime).Append("\n");
        sb.Append("  DoNotChangeDailyPaidTime: ").Append(DoNotChangeDailyPaidTime).Append("\n");
        sb.Append("  DoNotChangeShiftStartTimes: ").Append(DoNotChangeShiftStartTimes).Append("\n");
        sb.Append("  DoNotChangeManuallyEditedShifts: ").Append(DoNotChangeManuallyEditedShifts).Append("\n");
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
        return Equals(obj as ReschedulingOptionsRunResponse);
    }

    /// <summary>
    /// Returns true if ReschedulingOptionsRunResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ReschedulingOptionsRunResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReschedulingOptionsRunResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ExistingSchedule == other.ExistingSchedule ||
                ExistingSchedule != null &&
                ExistingSchedule.Equals(other.ExistingSchedule)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                ManagementUnits == other.ManagementUnits ||
                ManagementUnits != null &&
                ManagementUnits.SequenceEqual(other.ManagementUnits)
            ) &&
            (
                AgentCount == other.AgentCount ||
                AgentCount != null &&
                AgentCount.Equals(other.AgentCount)
            ) &&
            (
                ActivityCodeIds == other.ActivityCodeIds ||
                ActivityCodeIds != null &&
                ActivityCodeIds.SequenceEqual(other.ActivityCodeIds)
            ) &&
            (
                DoNotChangeWeeklyPaidTime == other.DoNotChangeWeeklyPaidTime ||
                DoNotChangeWeeklyPaidTime != null &&
                DoNotChangeWeeklyPaidTime.Equals(other.DoNotChangeWeeklyPaidTime)
            ) &&
            (
                DoNotChangeDailyPaidTime == other.DoNotChangeDailyPaidTime ||
                DoNotChangeDailyPaidTime != null &&
                DoNotChangeDailyPaidTime.Equals(other.DoNotChangeDailyPaidTime)
            ) &&
            (
                DoNotChangeShiftStartTimes == other.DoNotChangeShiftStartTimes ||
                DoNotChangeShiftStartTimes != null &&
                DoNotChangeShiftStartTimes.Equals(other.DoNotChangeShiftStartTimes)
            ) &&
            (
                DoNotChangeManuallyEditedShifts == other.DoNotChangeManuallyEditedShifts ||
                DoNotChangeManuallyEditedShifts != null &&
                DoNotChangeManuallyEditedShifts.Equals(other.DoNotChangeManuallyEditedShifts)
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
            if (ExistingSchedule != null)
            {
                hash = hash * 59 + ExistingSchedule.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (ManagementUnits != null)
            {
                hash = hash * 59 + ManagementUnits.GetHashCode();
            }

            if (AgentCount != null)
            {
                hash = hash * 59 + AgentCount.GetHashCode();
            }

            if (ActivityCodeIds != null)
            {
                hash = hash * 59 + ActivityCodeIds.GetHashCode();
            }

            if (DoNotChangeWeeklyPaidTime != null)
            {
                hash = hash * 59 + DoNotChangeWeeklyPaidTime.GetHashCode();
            }

            if (DoNotChangeDailyPaidTime != null)
            {
                hash = hash * 59 + DoNotChangeDailyPaidTime.GetHashCode();
            }

            if (DoNotChangeShiftStartTimes != null)
            {
                hash = hash * 59 + DoNotChangeShiftStartTimes.GetHashCode();
            }

            if (DoNotChangeManuallyEditedShifts != null)
            {
                hash = hash * 59 + DoNotChangeManuallyEditedShifts.GetHashCode();
            }

            return hash;
        }
    }
}
