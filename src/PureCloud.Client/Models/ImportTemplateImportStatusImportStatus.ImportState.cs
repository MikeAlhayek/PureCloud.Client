using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ImportTemplateImportStatusImportStatusImportStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum InProgress for "IN_PROGRESS"
    /// </summary>
    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,

    /// <summary>
    /// Enum Failed for "FAILED"
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed
}
