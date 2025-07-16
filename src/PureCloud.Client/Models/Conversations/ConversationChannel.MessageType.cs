using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Message type for messaging conversations.
/// </summary>
/// <value>Message type for messaging conversations.</value>

public enum ConversationChannelMessageTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Sms for "Sms"
    /// </summary>
    [EnumMember(Value = "Sms")]
    Sms,

    /// <summary>
    /// Enum Twitter for "Twitter"
    /// </summary>
    [EnumMember(Value = "Twitter")]
    Twitter,

    /// <summary>
    /// Enum Facebook for "Facebook"
    /// </summary>
    [EnumMember(Value = "Facebook")]
    Facebook,

    /// <summary>
    /// Enum Line for "Line"
    /// </summary>
    [EnumMember(Value = "Line")]
    Line,

    /// <summary>
    /// Enum Whatsapp for "WhatsApp"
    /// </summary>
    [EnumMember(Value = "WhatsApp")]
    Whatsapp,

    /// <summary>
    /// Enum Webmessaging for "WebMessaging"
    /// </summary>
    [EnumMember(Value = "WebMessaging")]
    Webmessaging,

    /// <summary>
    /// Enum Open for "Open"
    /// </summary>
    [EnumMember(Value = "Open")]
    Open,

    /// <summary>
    /// Enum Instagram for "Instagram"
    /// </summary>
    [EnumMember(Value = "Instagram")]
    Instagram
}
