using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowRuntimeExecutionStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum Running for "RUNNING"
    /// </summary>
    [EnumMember(Value = "RUNNING")]
    Running,

    /// <summary>
    /// Enum Error for "ERROR"
    /// </summary>
    [EnumMember(Value = "ERROR")]
    Error,

    /// <summary>
    /// Enum Terminated for "TERMINATED"
    /// </summary>
    [EnumMember(Value = "TERMINATED")]
    Terminated,

    /// <summary>
    /// Enum Completed for "COMPLETED"
    /// </summary>
    [EnumMember(Value = "COMPLETED")]
    Completed,

    /// <summary>
    /// Enum Failed for "FAILED"
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed
}
