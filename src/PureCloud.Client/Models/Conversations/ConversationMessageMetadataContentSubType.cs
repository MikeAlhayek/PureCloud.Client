using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Content subtype
/// </summary>
/// <value>Content subtype</value>

public enum ConversationMessageMetadataContentSubType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Image for "Image"
    /// </summary>
    [EnumMember(Value = "Image")]
    Image,

    /// <summary>
    /// Enum Video for "Video"
    /// </summary>
    [EnumMember(Value = "Video")]
    Video,

    /// <summary>
    /// Enum Audio for "Audio"
    /// </summary>
    [EnumMember(Value = "Audio")]
    Audio,

    /// <summary>
    /// Enum File for "File"
    /// </summary>
    [EnumMember(Value = "File")]
    File,

    /// <summary>
    /// Enum Link for "Link"
    /// </summary>
    [EnumMember(Value = "Link")]
    Link,

    /// <summary>
    /// Enum Mention for "Mention"
    /// </summary>
    [EnumMember(Value = "Mention")]
    Mention,

    /// <summary>
    /// Enum Reply for "Reply"
    /// </summary>
    [EnumMember(Value = "Reply")]
    Reply,

    /// <summary>
    /// Enum Button for "Button"
    /// </summary>
    [EnumMember(Value = "Button")]
    Button,

    /// <summary>
    /// Enum Quickreply for "QuickReply"
    /// </summary>
    [EnumMember(Value = "QuickReply")]
    Quickreply,

    /// <summary>
    /// Enum Postback for "Postback"
    /// </summary>
    [EnumMember(Value = "Postback")]
    Postback,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
