using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Type of this event element
/// </summary>
/// <value>Type of this event element</value>

public enum ConversationMessageMetadataEventType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Cobrowse for "CoBrowse"
    /// </summary>
    [EnumMember(Value = "CoBrowse")]
    Cobrowse,

    /// <summary>
    /// Enum Typing for "Typing"
    /// </summary>
    [EnumMember(Value = "Typing")]
    Typing,

    /// <summary>
    /// Enum Presence for "Presence"
    /// </summary>
    [EnumMember(Value = "Presence")]
    Presence,

    /// <summary>
    /// Enum Video for "Video"
    /// </summary>
    [EnumMember(Value = "Video")]
    Video,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
