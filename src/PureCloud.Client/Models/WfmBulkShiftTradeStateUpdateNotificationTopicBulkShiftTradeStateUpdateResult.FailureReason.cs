using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets FailureReason
/// </summary>

public enum WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResultFailureReasonEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Initiatingagentschedulenotfound for "InitiatingAgentScheduleNotFound"
    /// </summary>
    [EnumMember(Value = "InitiatingAgentScheduleNotFound")]
    Initiatingagentschedulenotfound,

    /// <summary>
    /// Enum Initiatingagentshiftnotfound for "InitiatingAgentShiftNotFound"
    /// </summary>
    [EnumMember(Value = "InitiatingAgentShiftNotFound")]
    Initiatingagentshiftnotfound,

    /// <summary>
    /// Enum Receivingagentnotfound for "ReceivingAgentNotFound"
    /// </summary>
    [EnumMember(Value = "ReceivingAgentNotFound")]
    Receivingagentnotfound,

    /// <summary>
    /// Enum Receivingagentschedulenotfound for "ReceivingAgentScheduleNotFound"
    /// </summary>
    [EnumMember(Value = "ReceivingAgentScheduleNotFound")]
    Receivingagentschedulenotfound,

    /// <summary>
    /// Enum Receivingagentshiftnotfound for "ReceivingAgentShiftNotFound"
    /// </summary>
    [EnumMember(Value = "ReceivingAgentShiftNotFound")]
    Receivingagentshiftnotfound,

    /// <summary>
    /// Enum Schedulenotpublished for "ScheduleNotPublished"
    /// </summary>
    [EnumMember(Value = "ScheduleNotPublished")]
    Schedulenotpublished,

    /// <summary>
    /// Enum Transitionnotallowed for "TransitionNotAllowed"
    /// </summary>
    [EnumMember(Value = "TransitionNotAllowed")]
    Transitionnotallowed
}
