using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The media type of the conversation the metric describes.
/// </summary>
/// <value>The media type of the conversation the metric describes.</value>

public enum CommonRulePredicateMediaTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

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
    /// Enum Message for "Message"
    /// </summary>
    [EnumMember(Value = "Message")]
    Message
}
