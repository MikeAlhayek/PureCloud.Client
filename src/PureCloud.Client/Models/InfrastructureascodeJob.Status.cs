using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum InfrastructureascodeJobStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Created for "Created"
    /// </summary>
    [EnumMember(Value = "Created")]
    Created,

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
    /// Enum Complete for "Complete"
    /// </summary>
    [EnumMember(Value = "Complete")]
    Complete,

    /// <summary>
    /// Enum Internalerror for "InternalError"
    /// </summary>
    [EnumMember(Value = "InternalError")]
    Internalerror,

    /// <summary>
    /// Enum Incomplete for "Incomplete"
    /// </summary>
    [EnumMember(Value = "Incomplete")]
    Incomplete,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed,

    /// <summary>
    /// Enum Rollbackfailed for "RollbackFailed"
    /// </summary>
    [EnumMember(Value = "RollbackFailed")]
    Rollbackfailed,

    /// <summary>
    /// Enum Rollbackcomplete for "RollbackComplete"
    /// </summary>
    [EnumMember(Value = "RollbackComplete")]
    Rollbackcomplete
}
