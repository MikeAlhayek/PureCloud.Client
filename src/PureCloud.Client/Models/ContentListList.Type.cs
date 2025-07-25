using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContentListListTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Selection for "Selection"
    /// </summary>
    [EnumMember(Value = "Selection")]
    Selection,

    /// <summary>
    /// Enum Vertical for "Vertical"
    /// </summary>
    [EnumMember(Value = "Vertical")]
    Vertical
}
