using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AsyncQueryStatusStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Queued for "QUEUED"
    /// </summary>
    [EnumMember(Value = "QUEUED")]
    Queued,

    /// <summary>
    /// Enum Pending for "PENDING"
    /// </summary>
    [EnumMember(Value = "PENDING")]
    Pending,

    /// <summary>
    /// Enum Failed for "FAILED"
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed,

    /// <summary>
    /// Enum Cancelled for "CANCELLED"
    /// </summary>
    [EnumMember(Value = "CANCELLED")]
    Cancelled,

    /// <summary>
    /// Enum Fulfilled for "FULFILLED"
    /// </summary>
    [EnumMember(Value = "FULFILLED")]
    Fulfilled,

    /// <summary>
    /// Enum Expired for "EXPIRED"
    /// </summary>
    [EnumMember(Value = "EXPIRED")]
    Expired
}
