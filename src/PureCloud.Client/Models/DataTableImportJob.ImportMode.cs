using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DataTableImportJobImportModeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Replaceall for "ReplaceAll"
    /// </summary>
    [EnumMember(Value = "ReplaceAll")]
    Replaceall,

    /// <summary>
    /// Enum Append for "Append"
    /// </summary>
    [EnumMember(Value = "Append")]
    Append
}
