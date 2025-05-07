using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets MessageType
/// </summary>

public enum CustomerEndDetailEventTopicCustomerEndEventMessageTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum Sms for "SMS"
    /// </summary>
    [EnumMember(Value = "SMS")]
    Sms,

    /// <summary>
    /// Enum Twitter for "TWITTER"
    /// </summary>
    [EnumMember(Value = "TWITTER")]
    Twitter,

    /// <summary>
    /// Enum Facebook for "FACEBOOK"
    /// </summary>
    [EnumMember(Value = "FACEBOOK")]
    Facebook,

    /// <summary>
    /// Enum Line for "LINE"
    /// </summary>
    [EnumMember(Value = "LINE")]
    Line,

    /// <summary>
    /// Enum Whatsapp for "WHATSAPP"
    /// </summary>
    [EnumMember(Value = "WHATSAPP")]
    Whatsapp,

    /// <summary>
    /// Enum Webmessaging for "WEBMESSAGING"
    /// </summary>
    [EnumMember(Value = "WEBMESSAGING")]
    Webmessaging,

    /// <summary>
    /// Enum Open for "OPEN"
    /// </summary>
    [EnumMember(Value = "OPEN")]
    Open,

    /// <summary>
    /// Enum Instagram for "INSTAGRAM"
    /// </summary>
    [EnumMember(Value = "INSTAGRAM")]
    Instagram,

    /// <summary>
    /// Enum Apple for "APPLE"
    /// </summary>
    [EnumMember(Value = "APPLE")]
    Apple
}
