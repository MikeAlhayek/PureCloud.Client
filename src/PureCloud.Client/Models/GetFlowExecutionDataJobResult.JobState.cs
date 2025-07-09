using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum GetFlowExecutionDataJobResultJobStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Registered for "Registered"
    /// </summary>
    [EnumMember(Value = "Registered")]
    Registered,

    /// <summary>
    /// Enum Running for "Running"
    /// </summary>
    [EnumMember(Value = "Running")]
    Running,

    /// <summary>
    /// Enum Success for "Success"
    /// </summary>
    [EnumMember(Value = "Success")]
    Success,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed
}
