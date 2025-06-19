using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CommonRuleBulkUpdateNotificationsRequestTypesToAddEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Sms for "Sms"
    /// </summary>
    [EnumMember(Value = "Sms")]
    Sms,

    /// <summary>
    /// Enum Device for "Device"
    /// </summary>
    [EnumMember(Value = "Device")]
    Device,

    /// <summary>
    /// Enum Email for "Email"
    /// </summary>
    [EnumMember(Value = "Email")]
    Email,

    /// <summary>
    /// Enum Push for "Push"
    /// </summary>
    [EnumMember(Value = "Push")]
    Push
}
