using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Indicates the type of message platform from which the message originated.
/// </summary>
/// <value>Indicates the type of message platform from which the message originated.</value>

public enum MessageType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Apple for "apple"
    /// </summary>
    [EnumMember(Value = "apple")]
    Apple,

    /// <summary>
    /// Enum Facebook for "facebook"
    /// </summary>
    [EnumMember(Value = "facebook")]
    Facebook,

    /// <summary>
    /// Enum Instagram for "instagram"
    /// </summary>
    [EnumMember(Value = "instagram")]
    Instagram,

    /// <summary>
    /// Enum Kakao for "kakao"
    /// </summary>
    [EnumMember(Value = "kakao")]
    Kakao,

    /// <summary>
    /// Enum Line for "line"
    /// </summary>
    [EnumMember(Value = "line")]
    Line,

    /// <summary>
    /// Enum Open for "open"
    /// </summary>
    [EnumMember(Value = "open")]
    Open,

    /// <summary>
    /// Enum Sms for "sms"
    /// </summary>
    [EnumMember(Value = "sms")]
    Sms,

    /// <summary>
    /// Enum Telegram for "telegram"
    /// </summary>
    [EnumMember(Value = "telegram")]
    Telegram,

    /// <summary>
    /// Enum Twitter for "twitter"
    /// </summary>
    [EnumMember(Value = "twitter")]
    Twitter,

    /// <summary>
    /// Enum Webmessaging for "webmessaging"
    /// </summary>
    [EnumMember(Value = "webmessaging")]
    Webmessaging,

    /// <summary>
    /// Enum Whatsapp for "whatsapp"
    /// </summary>
    [EnumMember(Value = "whatsapp")]
    Whatsapp,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown
}
