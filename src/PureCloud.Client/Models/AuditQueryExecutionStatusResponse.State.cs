using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AuditQueryExecutionStatusResponseStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Queued for "Queued"
    /// </summary>
    [EnumMember(Value = "Queued")]
    Queued,

    /// <summary>
    /// Enum Running for "Running"
    /// </summary>
    [EnumMember(Value = "Running")]
    Running,

    /// <summary>
    /// Enum Succeeded for "Succeeded"
    /// </summary>
    [EnumMember(Value = "Succeeded")]
    Succeeded,

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
