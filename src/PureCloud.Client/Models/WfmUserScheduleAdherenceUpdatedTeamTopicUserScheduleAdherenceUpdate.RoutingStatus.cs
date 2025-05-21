using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmUserScheduleAdherenceUpdatedTeamTopicUserScheduleAdherenceUpdateRoutingStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Empty for "__EMPTY__"
    /// </summary>
    [EnumMember(Value = "__EMPTY__")]
    Empty,

    /// <summary>
    /// Enum OffQueue for "OFF_QUEUE"
    /// </summary>
    [EnumMember(Value = "OFF_QUEUE")]
    OffQueue,

    /// <summary>
    /// Enum Idle for "IDLE"
    /// </summary>
    [EnumMember(Value = "IDLE")]
    Idle,

    /// <summary>
    /// Enum Interacting for "INTERACTING"
    /// </summary>
    [EnumMember(Value = "INTERACTING")]
    Interacting,

    /// <summary>
    /// Enum NotResponding for "NOT_RESPONDING"
    /// </summary>
    [EnumMember(Value = "NOT_RESPONDING")]
    NotResponding,

    /// <summary>
    /// Enum Communicating for "COMMUNICATING"
    /// </summary>
    [EnumMember(Value = "COMMUNICATING")]
    Communicating,

    /// <summary>
    /// Enum Offline for "OFFLINE"
    /// </summary>
    [EnumMember(Value = "OFFLINE")]
    Offline
}
