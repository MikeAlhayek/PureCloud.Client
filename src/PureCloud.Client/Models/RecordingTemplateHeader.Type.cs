using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum RecordingTemplateHeaderTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Text for "Text"
    /// </summary>
    [EnumMember(Value = "Text")]
    Text,

    /// <summary>
    /// Enum Media for "Media"
    /// </summary>
    [EnumMember(Value = "Media")]
    Media
}
