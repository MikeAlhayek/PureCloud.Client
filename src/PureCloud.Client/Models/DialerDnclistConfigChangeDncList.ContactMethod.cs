using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets ContactMethod
/// </summary>

public enum DialerDnclistConfigChangeDncListContactMethodEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    [EnumMember(Value = "EMAIL")]
    Email,

    /// <summary>
    /// Enum Phone for "PHONE"
    /// </summary>
    [EnumMember(Value = "PHONE")]
    Phone
}
