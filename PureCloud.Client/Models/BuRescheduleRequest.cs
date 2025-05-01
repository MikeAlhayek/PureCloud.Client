using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuRescheduleRequest
/// </summary>
[DataContract]
public partial class BuRescheduleRequest : IEquatable<BuRescheduleRequest>
{
    /// <summary>
    /// Overrides the default BU level activity smoothing type for this reschedule run
    /// </summary>
    /// <value>Overrides the default BU level activity smoothing type for this reschedule run</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActivitySmoothingTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Reduceconcurrentactivitiesacrossbu for "ReduceConcurrentActivitiesAcrossBu"
        /// </summary>
        [EnumMember(Value = "ReduceConcurrentActivitiesAcrossBu")]
        Reduceconcurrentactivitiesacrossbu,

        /// <summary>
        /// Enum Reduceconcurrentactivitiesacrossmu for "ReduceConcurrentActivitiesAcrossMu"
        /// </summary>
        [EnumMember(Value = "ReduceConcurrentActivitiesAcrossMu")]
        Reduceconcurrentactivitiesacrossmu,

        /// <summary>
        /// Enum Consistentservicelevel for "ConsistentServiceLevel"
        /// </summary>
        [EnumMember(Value = "ConsistentServiceLevel")]
        Consistentservicelevel
    }
    /// <summary>
    /// Overrides the default BU level activity smoothing type for this reschedule run
    /// </summary>
    /// <value>Overrides the default BU level activity smoothing type for this reschedule run</value>
    [DataMember(Name = "activitySmoothingType", EmitDefaultValue = false)]
    public ActivitySmoothingTypeEnum? ActivitySmoothingType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BuRescheduleRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuRescheduleRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuRescheduleRequest" /> class.
    /// </summary>
    /// <param name="StartDate">The start of the range to reschedule.  Defaults to the beginning of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndDate">The end of the range to reschedule.  Defaults the the end of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AgentIds">The IDs of the agents to consider for rescheduling.  Omit to consider all agents in the specified management units.Agents not in the specified management units will be ignored.</param>
    /// <param name="ActivityCodeIds">The IDs of the activity codes to consider for rescheduling.  Omit to consider all activity codes.</param>
    /// <param name="ManagementUnitIds">The IDs of the management units to reschedule (required).</param>
    /// <param name="DoNotChangeWeeklyPaidTime">Instructs the scheduler whether it is allowed to change weekly paid time (required).</param>
    /// <param name="DoNotChangeDailyPaidTime">Instructs the scheduler whether it is allowed to change daily paid time (required).</param>
    /// <param name="DoNotChangeShiftStartTimes">Instructs the scheduler whether it is allowed to change shift start times (required).</param>
    /// <param name="DoNotChangeManuallyEditedShifts">Instructs the scheduler whether it is allowed to change manually edited shifts (required).</param>
    /// <param name="ActivitySmoothingType">Overrides the default BU level activity smoothing type for this reschedule run.</param>
    /// <param name="InduceScheduleVariability">Overrides the default BU level induce schedule variability setting for this reschedule run.</param>
    public BuRescheduleRequest(DateTime? StartDate = null, DateTime? EndDate = null, List<string> AgentIds = null, List<string> ActivityCodeIds = null, List<string> ManagementUnitIds = null, bool? DoNotChangeWeeklyPaidTime = null, bool? DoNotChangeDailyPaidTime = null, bool? DoNotChangeShiftStartTimes = null, bool? DoNotChangeManuallyEditedShifts = null, ActivitySmoothingTypeEnum? ActivitySmoothingType = null, bool? InduceScheduleVariability = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.AgentIds = AgentIds;
        this.ActivityCodeIds = ActivityCodeIds;
        this.ManagementUnitIds = ManagementUnitIds;
        this.DoNotChangeWeeklyPaidTime = DoNotChangeWeeklyPaidTime;
        this.DoNotChangeDailyPaidTime = DoNotChangeDailyPaidTime;
        this.DoNotChangeShiftStartTimes = DoNotChangeShiftStartTimes;
        this.DoNotChangeManuallyEditedShifts = DoNotChangeManuallyEditedShifts;
        this.ActivitySmoothingType = ActivitySmoothingType;
        this.InduceScheduleVariability = InduceScheduleVariability;

    }



    /// <summary>
    /// The start of the range to reschedule.  Defaults to the beginning of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start of the range to reschedule.  Defaults to the beginning of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The end of the range to reschedule.  Defaults the the end of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end of the range to reschedule.  Defaults the the end of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// The IDs of the agents to consider for rescheduling.  Omit to consider all agents in the specified management units.Agents not in the specified management units will be ignored
    /// </summary>
    /// <value>The IDs of the agents to consider for rescheduling.  Omit to consider all agents in the specified management units.Agents not in the specified management units will be ignored</value>
    [DataMember(Name = "agentIds", EmitDefaultValue = false)]
    public List<string> AgentIds { get; set; }



    /// <summary>
    /// The IDs of the activity codes to consider for rescheduling.  Omit to consider all activity codes
    /// </summary>
    /// <value>The IDs of the activity codes to consider for rescheduling.  Omit to consider all activity codes</value>
    [DataMember(Name = "activityCodeIds", EmitDefaultValue = false)]
    public List<string> ActivityCodeIds { get; set; }



    /// <summary>
    /// The IDs of the management units to reschedule
    /// </summary>
    /// <value>The IDs of the management units to reschedule</value>
    [DataMember(Name = "managementUnitIds", EmitDefaultValue = false)]
    public List<string> ManagementUnitIds { get; set; }



    /// <summary>
    /// Instructs the scheduler whether it is allowed to change weekly paid time
    /// </summary>
    /// <value>Instructs the scheduler whether it is allowed to change weekly paid time</value>
    [DataMember(Name = "doNotChangeWeeklyPaidTime", EmitDefaultValue = false)]
    public bool? DoNotChangeWeeklyPaidTime { get; set; }



    /// <summary>
    /// Instructs the scheduler whether it is allowed to change daily paid time
    /// </summary>
    /// <value>Instructs the scheduler whether it is allowed to change daily paid time</value>
    [DataMember(Name = "doNotChangeDailyPaidTime", EmitDefaultValue = false)]
    public bool? DoNotChangeDailyPaidTime { get; set; }



    /// <summary>
    /// Instructs the scheduler whether it is allowed to change shift start times
    /// </summary>
    /// <value>Instructs the scheduler whether it is allowed to change shift start times</value>
    [DataMember(Name = "doNotChangeShiftStartTimes", EmitDefaultValue = false)]
    public bool? DoNotChangeShiftStartTimes { get; set; }



    /// <summary>
    /// Instructs the scheduler whether it is allowed to change manually edited shifts
    /// </summary>
    /// <value>Instructs the scheduler whether it is allowed to change manually edited shifts</value>
    [DataMember(Name = "doNotChangeManuallyEditedShifts", EmitDefaultValue = false)]
    public bool? DoNotChangeManuallyEditedShifts { get; set; }





    /// <summary>
    /// Overrides the default BU level induce schedule variability setting for this reschedule run
    /// </summary>
    /// <value>Overrides the default BU level induce schedule variability setting for this reschedule run</value>
    [DataMember(Name = "induceScheduleVariability", EmitDefaultValue = false)]
    public bool? InduceScheduleVariability { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuRescheduleRequest {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
        sb.Append("  ActivityCodeIds: ").Append(ActivityCodeIds).Append("\n");
        sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
        sb.Append("  DoNotChangeWeeklyPaidTime: ").Append(DoNotChangeWeeklyPaidTime).Append("\n");
        sb.Append("  DoNotChangeDailyPaidTime: ").Append(DoNotChangeDailyPaidTime).Append("\n");
        sb.Append("  DoNotChangeShiftStartTimes: ").Append(DoNotChangeShiftStartTimes).Append("\n");
        sb.Append("  DoNotChangeManuallyEditedShifts: ").Append(DoNotChangeManuallyEditedShifts).Append("\n");
        sb.Append("  ActivitySmoothingType: ").Append(ActivitySmoothingType).Append("\n");
        sb.Append("  InduceScheduleVariability: ").Append(InduceScheduleVariability).Append("\n");
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
        return Equals(obj as BuRescheduleRequest);
    }

    /// <summary>
    /// Returns true if BuRescheduleRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuRescheduleRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuRescheduleRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                AgentIds == other.AgentIds ||
                AgentIds != null &&
                AgentIds.SequenceEqual(other.AgentIds)
            ) &&
            (
                ActivityCodeIds == other.ActivityCodeIds ||
                ActivityCodeIds != null &&
                ActivityCodeIds.SequenceEqual(other.ActivityCodeIds)
            ) &&
            (
                ManagementUnitIds == other.ManagementUnitIds ||
                ManagementUnitIds != null &&
                ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
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
            ) &&
            (
                ActivitySmoothingType == other.ActivitySmoothingType ||
                ActivitySmoothingType != null &&
                ActivitySmoothingType.Equals(other.ActivitySmoothingType)
            ) &&
            (
                InduceScheduleVariability == other.InduceScheduleVariability ||
                InduceScheduleVariability != null &&
                InduceScheduleVariability.Equals(other.InduceScheduleVariability)
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
            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (AgentIds != null)
            {
                hash = hash * 59 + AgentIds.GetHashCode();
            }

            if (ActivityCodeIds != null)
            {
                hash = hash * 59 + ActivityCodeIds.GetHashCode();
            }

            if (ManagementUnitIds != null)
            {
                hash = hash * 59 + ManagementUnitIds.GetHashCode();
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

            if (ActivitySmoothingType != null)
            {
                hash = hash * 59 + ActivitySmoothingType.GetHashCode();
            }

            if (InduceScheduleVariability != null)
            {
                hash = hash * 59 + InduceScheduleVariability.GetHashCode();
            }

            return hash;
        }
    }
}
