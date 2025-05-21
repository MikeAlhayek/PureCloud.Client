using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets EventType
/// </summary>

public enum WfmScheduleTopicWfmScheduleNotificationEventTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Update for "Update"
    /// </summary>
    [EnumMember(Value = "Update")]
    Update,

    /// <summary>
    /// Enum Import for "Import"
    /// </summary>
    [EnumMember(Value = "Import")]
    Import,

    /// <summary>
    /// Enum Copy for "Copy"
    /// </summary>
    [EnumMember(Value = "Copy")]
    Copy,

    /// <summary>
    /// Enum Generate for "Generate"
    /// </summary>
    [EnumMember(Value = "Generate")]
    Generate,

    /// <summary>
    /// Enum Reschedule for "Reschedule"
    /// </summary>
    [EnumMember(Value = "Reschedule")]
    Reschedule
}
