using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics.
/// </summary>
public enum PostTextRequestMessagingPlatformType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Phone for "Phone"
    /// </summary>
    [EnumMember(Value = "Phone")]
    Phone,

    /// <summary>
    /// Enum Sms for "SMS"
    /// </summary>
    [EnumMember(Value = "SMS")]
    Sms,

    /// <summary>
    /// Enum Genesyswebwidget for "GenesysWebWidget"
    /// </summary>
    [EnumMember(Value = "GenesysWebWidget")]
    Genesyswebwidget,

    /// <summary>
    /// Enum Facebookmessenger for "FacebookMessenger"
    /// </summary>
    [EnumMember(Value = "FacebookMessenger")]
    Facebookmessenger,

    /// <summary>
    /// Enum Wechat for "WeChat"
    /// </summary>
    [EnumMember(Value = "WeChat")]
    Wechat,

    /// <summary>
    /// Enum Whatsapp for "Whatsapp"
    /// </summary>
    [EnumMember(Value = "Whatsapp")]
    Whatsapp,

    /// <summary>
    /// Enum Applebusinesschat for "AppleBusinessChat"
    /// </summary>
    [EnumMember(Value = "AppleBusinessChat")]
    Applebusinesschat,

    /// <summary>
    /// Enum Apple for "Apple"
    /// </summary>
    [EnumMember(Value = "Apple")]
    Apple,

    /// <summary>
    /// Enum Telegram for "Telegram"
    /// </summary>
    [EnumMember(Value = "Telegram")]
    Telegram,

    /// <summary>
    /// Enum Slack for "Slack"
    /// </summary>
    [EnumMember(Value = "Slack")]
    Slack,

    /// <summary>
    /// Enum Signal for "Signal"
    /// </summary>
    [EnumMember(Value = "Signal")]
    Signal,

    /// <summary>
    /// Enum Line for "Line"
    /// </summary>
    [EnumMember(Value = "Line")]
    Line,

    /// <summary>
    /// Enum Discord for "Discord"
    /// </summary>
    [EnumMember(Value = "Discord")]
    Discord,

    /// <summary>
    /// Enum Twitterdirectmessage for "TwitterDirectMessage"
    /// </summary>
    [EnumMember(Value = "TwitterDirectMessage")]
    Twitterdirectmessage,

    /// <summary>
    /// Enum Open for "Open"
    /// </summary>
    [EnumMember(Value = "Open")]
    Open,

    /// <summary>
    /// Enum Instagram for "Instagram"
    /// </summary>
    [EnumMember(Value = "Instagram")]
    Instagram,

    /// <summary>
    /// Enum Other for "Other"
    /// </summary>
    [EnumMember(Value = "Other")]
    Other,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}