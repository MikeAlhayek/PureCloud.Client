using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneySessionEventsNotificationConversationChannelTypeEnum
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
    /// Enum Voice for "Voice"
    /// </summary>
    [EnumMember(Value = "Voice")]
    Voice,

    /// <summary>
    /// Enum Chat for "Chat"
    /// </summary>
    [EnumMember(Value = "Chat")]
    Chat,

    /// <summary>
    /// Enum Email for "Email"
    /// </summary>
    [EnumMember(Value = "Email")]
    Email,

    /// <summary>
    /// Enum Callback for "Callback"
    /// </summary>
    [EnumMember(Value = "Callback")]
    Callback,

    /// <summary>
    /// Enum Cobrowse for "Cobrowse"
    /// </summary>
    [EnumMember(Value = "Cobrowse")]
    Cobrowse,

    /// <summary>
    /// Enum Video for "Video"
    /// </summary>
    [EnumMember(Value = "Video")]
    Video,

    /// <summary>
    /// Enum Screenshare for "Screenshare"
    /// </summary>
    [EnumMember(Value = "Screenshare")]
    Screenshare,

    /// <summary>
    /// Enum Message for "Message"
    /// </summary>
    [EnumMember(Value = "Message")]
    Message,

    /// <summary>
    /// Enum Internalmessage for "InternalMessage"
    /// </summary>
    [EnumMember(Value = "InternalMessage")]
    Internalmessage
}
