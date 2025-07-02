using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WarningRangeTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Over for "OVER"
    /// </summary>
    [EnumMember(Value = "OVER")]
    Over,

    /// <summary>
    /// Enum Under for "UNDER"
    /// </summary>
    [EnumMember(Value = "UNDER")]
    Under,

    /// <summary>
    /// Enum Between for "BETWEEN"
    /// </summary>
    [EnumMember(Value = "BETWEEN")]
    Between
}
