using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SchedulerMessageTypeSeverity
/// </summary>

public partial class SchedulerMessageTypeSeverity : IEquatable<SchedulerMessageTypeSeverity>
{
    /// <summary>
    /// The type of the message
    /// </summary>
    /// <value>The type of the message</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Agentnotfound for "AgentNotFound"
        /// </summary>
        [EnumMember(Value = "AgentNotFound")]
        Agentnotfound,

        /// <summary>
        /// Enum Agentnotinselectedmanagementunit for "AgentNotInSelectedManagementUnit"
        /// </summary>
        [EnumMember(Value = "AgentNotInSelectedManagementUnit")]
        Agentnotinselectedmanagementunit,

        /// <summary>
        /// Enum Agentnotlicensed for "AgentNotLicensed"
        /// </summary>
        [EnumMember(Value = "AgentNotLicensed")]
        Agentnotlicensed,

        /// <summary>
        /// Enum Agentwithoutworkplan for "AgentWithoutWorkPlan"
        /// </summary>
        [EnumMember(Value = "AgentWithoutWorkPlan")]
        Agentwithoutworkplan,

        /// <summary>
        /// Enum Workplannotenabled for "WorkPlanNotEnabled"
        /// </summary>
        [EnumMember(Value = "WorkPlanNotEnabled")]
        Workplannotenabled,

        /// <summary>
        /// Enum Workplannotfound for "WorkPlanNotFound"
        /// </summary>
        [EnumMember(Value = "WorkPlanNotFound")]
        Workplannotfound,

        /// <summary>
        /// Enum Agentwithoutcapability for "AgentWithoutCapability"
        /// </summary>
        [EnumMember(Value = "AgentWithoutCapability")]
        Agentwithoutcapability,

        /// <summary>
        /// Enum Noneeddays for "NoNeedDays"
        /// </summary>
        [EnumMember(Value = "NoNeedDays")]
        Noneeddays,

        /// <summary>
        /// Enum Unabletoproduceagentschedule for "UnableToProduceAgentSchedule"
        /// </summary>
        [EnumMember(Value = "UnableToProduceAgentSchedule")]
        Unabletoproduceagentschedule,

        /// <summary>
        /// Enum Unabletoschedulemaxconsecutiveworkingdaysfromagenthistory for "UnableToScheduleMaxConsecutiveWorkingDaysFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMaxConsecutiveWorkingDaysFromAgentHistory")]
        Unabletoschedulemaxconsecutiveworkingdaysfromagenthistory,

        /// <summary>
        /// Enum Unabletoschedulemaxconsecutiveworkingweekendsfromagenthistory for "UnableToScheduleMaxConsecutiveWorkingWeekendsFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMaxConsecutiveWorkingWeekendsFromAgentHistory")]
        Unabletoschedulemaxconsecutiveworkingweekendsfromagenthistory,

        /// <summary>
        /// Enum Unabletoschedulemaxweeklypaidtimefromtimeoff for "UnableToScheduleMaxWeeklyPaidTimeFromTimeOff"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMaxWeeklyPaidTimeFromTimeOff")]
        Unabletoschedulemaxweeklypaidtimefromtimeoff,

        /// <summary>
        /// Enum Unabletoschedulemaxworkdaypaidtimefromtimeoff for "UnableToScheduleMaxWorkDayPaidTimeFromTimeOff"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMaxWorkDayPaidTimeFromTimeOff")]
        Unabletoschedulemaxworkdaypaidtimefromtimeoff,

        /// <summary>
        /// Enum Unabletoscheduleminintershifttimefromagenthistory for "UnableToScheduleMinIntershiftTimeFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinIntershiftTimeFromAgentHistory")]
        Unabletoscheduleminintershifttimefromagenthistory,

        /// <summary>
        /// Enum Unabletoscheduleminintershifttimefromdst for "UnableToScheduleMinIntershiftTimeFromDst"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinIntershiftTimeFromDst")]
        Unabletoscheduleminintershifttimefromdst,

        /// <summary>
        /// Enum Unabletoscheduleminshiftstartdistancefromagenthistory for "UnableToScheduleMinShiftStartDistanceFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinShiftStartDistanceFromAgentHistory")]
        Unabletoscheduleminshiftstartdistancefromagenthistory,

        /// <summary>
        /// Enum Unabletoscheduleminshiftstartdistancefromdst for "UnableToScheduleMinShiftStartDistanceFromDst"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinShiftStartDistanceFromDst")]
        Unabletoscheduleminshiftstartdistancefromdst,

        /// <summary>
        /// Enum Unabletoscheduleminweeklypaidtimefromtimeoff for "UnableToScheduleMinWeeklyPaidTimeFromTimeOff"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinWeeklyPaidTimeFromTimeOff")]
        Unabletoscheduleminweeklypaidtimefromtimeoff,

        /// <summary>
        /// Enum Unabletoscheduleminweeklyworkdaysfromtimeoff for "UnableToScheduleMinWeeklyWorkDaysFromTimeOff"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinWeeklyWorkDaysFromTimeOff")]
        Unabletoscheduleminweeklyworkdaysfromtimeoff,

        /// <summary>
        /// Enum Unabletoscheduleminworkdaypaidtimefromtimeoff for "UnableToScheduleMinWorkDayPaidTimeFromTimeOff"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinWorkDayPaidTimeFromTimeOff")]
        Unabletoscheduleminworkdaypaidtimefromtimeoff,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodmaxdaysofffromagenthistory for "UnableToSchedulePlanningPeriodMaxDaysOffFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMaxDaysOffFromAgentHistory")]
        Unabletoscheduleplanningperiodmaxdaysofffromagenthistory,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodmaxdaysofffromtimeoff for "UnableToSchedulePlanningPeriodMaxDaysOffFromTimeOff"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMaxDaysOffFromTimeOff")]
        Unabletoscheduleplanningperiodmaxdaysofffromtimeoff,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodmaxpaidtimefromagenthistory for "UnableToSchedulePlanningPeriodMaxPaidTimeFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMaxPaidTimeFromAgentHistory")]
        Unabletoscheduleplanningperiodmaxpaidtimefromagenthistory,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodmaxpaidtimefromtimeoff for "UnableToSchedulePlanningPeriodMaxPaidTimeFromTimeOff"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMaxPaidTimeFromTimeOff")]
        Unabletoscheduleplanningperiodmaxpaidtimefromtimeoff,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodmaxworkingweekendsfromagenthistory for "UnableToSchedulePlanningPeriodMaxWorkingWeekendsFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMaxWorkingWeekendsFromAgentHistory")]
        Unabletoscheduleplanningperiodmaxworkingweekendsfromagenthistory,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodmindaysofffromagenthistory for "UnableToSchedulePlanningPeriodMinDaysOffFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMinDaysOffFromAgentHistory")]
        Unabletoscheduleplanningperiodmindaysofffromagenthistory,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodminpaidtimefromagenthistory for "UnableToSchedulePlanningPeriodMinPaidTimeFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMinPaidTimeFromAgentHistory")]
        Unabletoscheduleplanningperiodminpaidtimefromagenthistory,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodminpaidtimefromtimeoff for "UnableToSchedulePlanningPeriodMinPaidTimeFromTimeOff"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMinPaidTimeFromTimeOff")]
        Unabletoscheduleplanningperiodminpaidtimefromtimeoff,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodshiftmaxcountfromagenthistory for "UnableToSchedulePlanningPeriodShiftMaxCountFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodShiftMaxCountFromAgentHistory")]
        Unabletoscheduleplanningperiodshiftmaxcountfromagenthistory,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodshiftmincountfromagenthistory for "UnableToSchedulePlanningPeriodShiftMinCountFromAgentHistory"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodShiftMinCountFromAgentHistory")]
        Unabletoscheduleplanningperiodshiftmincountfromagenthistory,

        /// <summary>
        /// Enum Unabletoscheduleworkdayfromtimeoff for "UnableToScheduleWorkDayFromTimeOff"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleWorkDayFromTimeOff")]
        Unabletoscheduleworkdayfromtimeoff,

        /// <summary>
        /// Enum Unabletoschedulemaxconsecutiveworkingdays for "UnableToScheduleMaxConsecutiveWorkingDays"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMaxConsecutiveWorkingDays")]
        Unabletoschedulemaxconsecutiveworkingdays,

        /// <summary>
        /// Enum Unabletoschedulemaxconsecutiveworkingweekends for "UnableToScheduleMaxConsecutiveWorkingWeekends"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMaxConsecutiveWorkingWeekends")]
        Unabletoschedulemaxconsecutiveworkingweekends,

        /// <summary>
        /// Enum Unabletoschedulemaxweeklypaidtime for "UnableToScheduleMaxWeeklyPaidTime"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMaxWeeklyPaidTime")]
        Unabletoschedulemaxweeklypaidtime,

        /// <summary>
        /// Enum Unabletoschedulemaxweeklyworkdays for "UnableToScheduleMaxWeeklyWorkDays"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMaxWeeklyWorkDays")]
        Unabletoschedulemaxweeklyworkdays,

        /// <summary>
        /// Enum Unabletoschedulemaxworkdaypaidtime for "UnableToScheduleMaxWorkDayPaidTime"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMaxWorkDayPaidTime")]
        Unabletoschedulemaxworkdaypaidtime,

        /// <summary>
        /// Enum Unabletoscheduleminconsecutivenonworkingtimeperweek for "UnableToScheduleMinConsecutiveNonWorkingTimePerWeek"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinConsecutiveNonWorkingTimePerWeek")]
        Unabletoscheduleminconsecutivenonworkingtimeperweek,

        /// <summary>
        /// Enum Unabletoscheduleminintershifttime for "UnableToScheduleMinIntershiftTime"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinIntershiftTime")]
        Unabletoscheduleminintershifttime,

        /// <summary>
        /// Enum Unabletoscheduleminshiftstartdistance for "UnableToScheduleMinShiftStartDistance"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinShiftStartDistance")]
        Unabletoscheduleminshiftstartdistance,

        /// <summary>
        /// Enum Unabletoscheduleminweeklypaidtime for "UnableToScheduleMinWeeklyPaidTime"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinWeeklyPaidTime")]
        Unabletoscheduleminweeklypaidtime,

        /// <summary>
        /// Enum Unabletoscheduleminweeklyworkdays for "UnableToScheduleMinWeeklyWorkDays"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinWeeklyWorkDays")]
        Unabletoscheduleminweeklyworkdays,

        /// <summary>
        /// Enum Unabletoscheduleminworkdaypaidtime for "UnableToScheduleMinWorkDayPaidTime"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleMinWorkDayPaidTime")]
        Unabletoscheduleminworkdaypaidtime,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodmaxdaysoff for "UnableToSchedulePlanningPeriodMaxDaysOff"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMaxDaysOff")]
        Unabletoscheduleplanningperiodmaxdaysoff,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodmaxpaidtime for "UnableToSchedulePlanningPeriodMaxPaidTime"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMaxPaidTime")]
        Unabletoscheduleplanningperiodmaxpaidtime,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodmindaysoff for "UnableToSchedulePlanningPeriodMinDaysOff"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMinDaysOff")]
        Unabletoscheduleplanningperiodmindaysoff,

        /// <summary>
        /// Enum Unabletoscheduleplanningperiodminpaidtime for "UnableToSchedulePlanningPeriodMinPaidTime"
        /// </summary>
        [EnumMember(Value = "UnableToSchedulePlanningPeriodMinPaidTime")]
        Unabletoscheduleplanningperiodminpaidtime,

        /// <summary>
        /// Enum Unabletoscheduleshiftvariance for "UnableToScheduleShiftVariance"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleShiftVariance")]
        Unabletoscheduleshiftvariance,

        /// <summary>
        /// Enum Unabletoscheduleworkday for "UnableToScheduleWorkDay"
        /// </summary>
        [EnumMember(Value = "UnableToScheduleWorkDay")]
        Unabletoscheduleworkday
    }
    /// <summary>
    /// The severity of the message
    /// </summary>
    /// <value>The severity of the message</value>
    
    public enum SeverityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ignore for "Ignore"
        /// </summary>
        [EnumMember(Value = "Ignore")]
        Ignore,

        /// <summary>
        /// Enum Information for "Information"
        /// </summary>
        [EnumMember(Value = "Information")]
        Information,

        /// <summary>
        /// Enum Warning for "Warning"
        /// </summary>
        [EnumMember(Value = "Warning")]
        Warning,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// The type of the message
    /// </summary>
    /// <value>The type of the message</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The severity of the message
    /// </summary>
    /// <value>The severity of the message</value>
    [JsonPropertyName("severity")]
    public SeverityEnum? Severity { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulerMessageTypeSeverity" /> class.
    /// </summary>
    /// <param name="Type">The type of the message.</param>
    /// <param name="Severity">The severity of the message.</param>
    public SchedulerMessageTypeSeverity(TypeEnum? Type = null, SeverityEnum? Severity = null)
    {
        this.Type = Type;
        this.Severity = Severity;

    }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SchedulerMessageTypeSeverity {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Severity: ").Append(Severity).Append("\n");
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
        return Equals(obj as SchedulerMessageTypeSeverity);
    }

    /// <summary>
    /// Returns true if SchedulerMessageTypeSeverity instances are equal
    /// </summary>
    /// <param name="other">Instance of SchedulerMessageTypeSeverity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SchedulerMessageTypeSeverity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Severity == other.Severity ||
                Severity != null &&
                Severity.Equals(other.Severity)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Severity != null)
            {
                hash = hash * 59 + Severity.GetHashCode();
            }

            return hash;
        }
    }
}
