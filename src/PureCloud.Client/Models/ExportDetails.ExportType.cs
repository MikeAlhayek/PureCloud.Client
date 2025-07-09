using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ExportDetailsExportTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Architect for "Architect"
    /// </summary>
    [EnumMember(Value = "Architect")]
    Architect,

    /// <summary>
    /// Enum Yaml for "Yaml"
    /// </summary>
    [EnumMember(Value = "Yaml")]
    Yaml
}
