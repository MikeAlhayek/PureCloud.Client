using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The session media type
/// </summary>
/// <value>The session media type</value>

public enum FlowMetricsTopicFlowMetricRecordMediaType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Callback for "callback"
    /// </summary>
    [EnumMember(Value = "callback")]
    Callback,

    /// <summary>
    /// Enum Chat for "chat"
    /// </summary>
    [EnumMember(Value = "chat")]
    Chat,

    /// <summary>
    /// Enum Cobrowse for "cobrowse"
    /// </summary>
    [EnumMember(Value = "cobrowse")]
    Cobrowse,

    /// <summary>
    /// Enum Email for "email"
    /// </summary>
    [EnumMember(Value = "email")]
    Email,

    /// <summary>
    /// Enum Internalmessage for "internalmessage"
    /// </summary>
    [EnumMember(Value = "internalmessage")]
    Internalmessage,

    /// <summary>
    /// Enum Message for "message"
    /// </summary>
    [EnumMember(Value = "message")]
    Message,

    /// <summary>
    /// Enum Screenshare for "screenshare"
    /// </summary>
    [EnumMember(Value = "screenshare")]
    Screenshare,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Enum Video for "video"
    /// </summary>
    [EnumMember(Value = "video")]
    Video,

    /// <summary>
    /// Enum Voice for "voice"
    /// </summary>
    [EnumMember(Value = "voice")]
    Voice
}
