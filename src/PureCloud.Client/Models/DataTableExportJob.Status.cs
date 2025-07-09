using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DataTableExportJobStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Processing for "Processing"
    /// </summary>
    [EnumMember(Value = "Processing")]
    Processing,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed,

    /// <summary>
    /// Enum Succeeded for "Succeeded"
    /// </summary>
    [EnumMember(Value = "Succeeded")]
    Succeeded
}
