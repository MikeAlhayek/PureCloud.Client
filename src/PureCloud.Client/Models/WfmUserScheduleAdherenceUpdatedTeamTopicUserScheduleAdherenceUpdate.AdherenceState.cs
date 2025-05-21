using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets AdherenceState
/// </summary>

public enum WfmUserScheduleAdherenceUpdatedTeamTopicUserScheduleAdherenceUpdateAdherenceStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Inadherence for "InAdherence"
    /// </summary>
    [EnumMember(Value = "InAdherence")]
    Inadherence,

    /// <summary>
    /// Enum Outofadherence for "OutOfAdherence"
    /// </summary>
    [EnumMember(Value = "OutOfAdherence")]
    Outofadherence,

    /// <summary>
    /// Enum Unscheduled for "Unscheduled"
    /// </summary>
    [EnumMember(Value = "Unscheduled")]
    Unscheduled,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Ignored for "Ignored"
    /// </summary>
    [EnumMember(Value = "Ignored")]
    Ignored,

    /// <summary>
    /// Enum Explained for "Explained"
    /// </summary>
    [EnumMember(Value = "Explained")]
    Explained
}
