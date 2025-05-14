using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerRulesetConfigChangeRuleCategoryEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Precall for "DIALER_PRECALL"
    /// </summary>
    [EnumMember(Value = "DIALER_PRECALL")]
    Precall,

    /// <summary>
    /// Enum Wrapup for "DIALER_WRAPUP"
    /// </summary>
    [EnumMember(Value = "DIALER_WRAPUP")]
    Wrapup
}
