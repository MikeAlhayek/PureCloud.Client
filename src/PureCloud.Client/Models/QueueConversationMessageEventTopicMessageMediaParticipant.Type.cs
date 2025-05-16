using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Type
/// </summary>

public enum QueueConversationMessageEventTopicMessageMediaParticipantTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Enum Sms for "sms"
    /// </summary>
    [EnumMember(Value = "sms")]
    Sms,

    /// <summary>
    /// Enum Twitter for "twitter"
    /// </summary>
    [EnumMember(Value = "twitter")]
    Twitter,

    /// <summary>
    /// Enum Facebook for "facebook"
    /// </summary>
    [EnumMember(Value = "facebook")]
    Facebook,

    /// <summary>
    /// Enum Line for "line"
    /// </summary>
    [EnumMember(Value = "line")]
    Line,

    /// <summary>
    /// Enum Viber for "viber"
    /// </summary>
    [EnumMember(Value = "viber")]
    Viber,

    /// <summary>
    /// Enum Wechat for "wechat"
    /// </summary>
    [EnumMember(Value = "wechat")]
    Wechat,

    /// <summary>
    /// Enum Whatsapp for "whatsapp"
    /// </summary>
    [EnumMember(Value = "whatsapp")]
    Whatsapp,

    /// <summary>
    /// Enum Telegram for "telegram"
    /// </summary>
    [EnumMember(Value = "telegram")]
    Telegram,

    /// <summary>
    /// Enum Kakao for "kakao"
    /// </summary>
    [EnumMember(Value = "kakao")]
    Kakao,

    /// <summary>
    /// Enum Webmessaging for "webmessaging"
    /// </summary>
    [EnumMember(Value = "webmessaging")]
    Webmessaging,

    /// <summary>
    /// Enum Open for "open"
    /// </summary>
    [EnumMember(Value = "open")]
    Open,

    /// <summary>
    /// Enum Instagram for "instagram"
    /// </summary>
    [EnumMember(Value = "instagram")]
    Instagram,

    /// <summary>
    /// Enum Apple for "apple"
    /// </summary>
    [EnumMember(Value = "apple")]
    Apple
}
