using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmBuScheduleRunTopicSchedulerMessageSeverityCountSeverityEnum
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
