using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets MediaType
/// </summary>

public enum EvaluationMediaType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Call for "CALL"
    /// </summary>
    [EnumMember(Value = "CALL")]
    Call,

    /// <summary>
    /// Enum Callback for "CALLBACK"
    /// </summary>
    [EnumMember(Value = "CALLBACK")]
    Callback,

    /// <summary>
    /// Enum Chat for "CHAT"
    /// </summary>
    [EnumMember(Value = "CHAT")]
    Chat,

    /// <summary>
    /// Enum Cobrowse for "COBROWSE"
    /// </summary>
    [EnumMember(Value = "COBROWSE")]
    Cobrowse,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    [EnumMember(Value = "EMAIL")]
    Email,

    /// <summary>
    /// Enum Message for "MESSAGE"
    /// </summary>
    [EnumMember(Value = "MESSAGE")]
    Message,

    /// <summary>
    /// Enum InternalMessage for "INTERNAL_MESSAGE"
    /// </summary>
    [EnumMember(Value = "INTERNAL_MESSAGE")]
    InternalMessage,

    /// <summary>
    /// Enum SocialExpression for "SOCIAL_EXPRESSION"
    /// </summary>
    [EnumMember(Value = "SOCIAL_EXPRESSION")]
    SocialExpression,

    /// <summary>
    /// Enum Video for "VIDEO"
    /// </summary>
    [EnumMember(Value = "VIDEO")]
    Video,

    /// <summary>
    /// Enum Screenshare for "SCREENSHARE"
    /// </summary>
    [EnumMember(Value = "SCREENSHARE")]
    Screenshare
}
