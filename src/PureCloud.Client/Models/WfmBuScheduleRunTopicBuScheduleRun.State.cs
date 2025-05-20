using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmBuScheduleRunTopicBuScheduleRunStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum None for "None"
    /// </summary>
    [EnumMember(Value = "None")]
    None,

    /// <summary>
    /// Enum Queued for "Queued"
    /// </summary>
    [EnumMember(Value = "Queued")]
    Queued,

    /// <summary>
    /// Enum Scheduling for "Scheduling"
    /// </summary>
    [EnumMember(Value = "Scheduling")]
    Scheduling,

    /// <summary>
    /// Enum Canceled for "Canceled"
    /// </summary>
    [EnumMember(Value = "Canceled")]
    Canceled,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed,

    /// <summary>
    /// Enum Complete for "Complete"
    /// </summary>
    [EnumMember(Value = "Complete")]
    Complete
}
