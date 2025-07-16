using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContactsExportStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Running for "RUNNING"
    /// </summary>
    [EnumMember(Value = "RUNNING")]
    Running,

    /// <summary>
    /// Enum Succeeded for "SUCCEEDED"
    /// </summary>
    [EnumMember(Value = "SUCCEEDED")]
    Succeeded,

    /// <summary>
    /// Enum Failed for "FAILED"
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed
}
