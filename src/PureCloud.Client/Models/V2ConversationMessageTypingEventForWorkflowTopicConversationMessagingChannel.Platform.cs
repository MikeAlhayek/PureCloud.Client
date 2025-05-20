using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannelPlatformEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

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
    /// Enum Instagram for "Instagram"
    /// </summary>
    [EnumMember(Value = "Instagram")]
    Instagram,

    /// <summary>
    /// Enum Line for "Line"
    /// </summary>
    [EnumMember(Value = "Line")]
    Line,

    /// <summary>
    /// Enum Whatsapp for "Whatsapp"
    /// </summary>
    [EnumMember(Value = "Whatsapp")]
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
    /// Enum Sms for "Sms"
    /// </summary>
    [EnumMember(Value = "Sms")]
    Sms,

    /// <summary>
    /// Enum Apple for "Apple"
    /// </summary>
    [EnumMember(Value = "Apple")]
    Apple
}
