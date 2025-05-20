using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdateTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Added for "Added"
    /// </summary>
    [EnumMember(Value = "Added")]
    Added,

    /// <summary>
    /// Enum Edited for "Edited"
    /// </summary>
    [EnumMember(Value = "Edited")]
    Edited,

    /// <summary>
    /// Enum Deleted for "Deleted"
    /// </summary>
    [EnumMember(Value = "Deleted")]
    Deleted
}
