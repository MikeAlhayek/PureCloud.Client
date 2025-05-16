using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdateStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum None for "NONE"
    /// </summary>
    [EnumMember(Value = "NONE")]
    None,

    /// <summary>
    /// Enum Init for "INIT"
    /// </summary>
    [EnumMember(Value = "INIT")]
    Init,

    /// <summary>
    /// Enum InProgress for "IN_PROGRESS"
    /// </summary>
    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,

    /// <summary>
    /// Enum Expired for "EXPIRED"
    /// </summary>
    [EnumMember(Value = "EXPIRED")]
    Expired,

    /// <summary>
    /// Enum Exception for "EXCEPTION"
    /// </summary>
    [EnumMember(Value = "EXCEPTION")]
    Exception,

    /// <summary>
    /// Enum Aborted for "ABORTED"
    /// </summary>
    [EnumMember(Value = "ABORTED")]
    Aborted,

    /// <summary>
    /// Enum Failed for "FAILED"
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed,

    /// <summary>
    /// Enum Succeeded for "SUCCEEDED"
    /// </summary>
    [EnumMember(Value = "SUCCEEDED")]
    Succeeded,

    /// <summary>
    /// Enum Delete for "DELETE"
    /// </summary>
    [EnumMember(Value = "DELETE")]
    Delete
}
