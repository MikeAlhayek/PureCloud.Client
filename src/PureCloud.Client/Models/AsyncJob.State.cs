using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AsyncJobStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Running for "Running"
    /// </summary>
    [EnumMember(Value = "Running")]
    Running,

    /// <summary>
    /// Enum Completed for "Completed"
    /// </summary>
    [EnumMember(Value = "Completed")]
    Completed,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed,

    /// <summary>
    /// Enum Cancelled for "Cancelled"
    /// </summary>
    [EnumMember(Value = "Cancelled")]
    Cancelled
}
