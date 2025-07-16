using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ConversationChannelTypeEnum
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
    /// Enum Call for "Call"
    /// </summary>
    [EnumMember(Value = "Call")]
    Call,

    /// <summary>
    /// Enum Callback for "Callback"
    /// </summary>
    [EnumMember(Value = "Callback")]
    Callback,

    /// <summary>
    /// Enum Email for "Email"
    /// </summary>
    [EnumMember(Value = "Email")]
    Email,

    /// <summary>
    /// Enum Genericobject for "GenericObject"
    /// </summary>
    [EnumMember(Value = "GenericObject")]
    Genericobject,

    /// <summary>
    /// Enum Messaging for "Messaging"
    /// </summary>
    [EnumMember(Value = "Messaging")]
    Messaging,

    /// <summary>
    /// Enum Social for "Social"
    /// </summary>
    [EnumMember(Value = "Social")]
    Social,

    /// <summary>
    /// Enum Webchat for "Webchat"
    /// </summary>
    [EnumMember(Value = "Webchat")]
    Webchat,

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
