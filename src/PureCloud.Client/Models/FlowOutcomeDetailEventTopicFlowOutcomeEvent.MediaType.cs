using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowOutcomeDetailEventTopicFlowOutcomeEventMediaTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum Voice for "VOICE"
    /// </summary>
    [EnumMember(Value = "VOICE")]
    Voice,

    /// <summary>
    /// Enum Chat for "CHAT"
    /// </summary>
    [EnumMember(Value = "CHAT")]
    Chat,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    [EnumMember(Value = "EMAIL")]
    Email,

    /// <summary>
    /// Enum Callback for "CALLBACK"
    /// </summary>
    [EnumMember(Value = "CALLBACK")]
    Callback,

    /// <summary>
    /// Enum Cobrowse for "COBROWSE"
    /// </summary>
    [EnumMember(Value = "COBROWSE")]
    Cobrowse,

    /// <summary>
    /// Enum Video for "VIDEO"
    /// </summary>
    [EnumMember(Value = "VIDEO")]
    Video,

    /// <summary>
    /// Enum Screenshare for "SCREENSHARE"
    /// </summary>
    [EnumMember(Value = "SCREENSHARE")]
    Screenshare,

    /// <summary>
    /// Enum Message for "MESSAGE"
    /// </summary>
    [EnumMember(Value = "MESSAGE")]
    Message,

    /// <summary>
    /// Enum Internalmessage for "INTERNALMESSAGE"
    /// </summary>
    [EnumMember(Value = "INTERNALMESSAGE")]
    Internalmessage
}
