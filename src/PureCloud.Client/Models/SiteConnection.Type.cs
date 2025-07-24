using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum SiteConnectionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Direct for "Direct"
    /// </summary>
    [EnumMember(Value = "Direct")]
    Direct,

    /// <summary>
    /// Enum Indirect for "Indirect"
    /// </summary>
    [EnumMember(Value = "Indirect")]
    Indirect,

    /// <summary>
    /// Enum Cloudproxy for "CloudProxy"
    /// </summary>
    [EnumMember(Value = "CloudProxy")]
    Cloudproxy
}
