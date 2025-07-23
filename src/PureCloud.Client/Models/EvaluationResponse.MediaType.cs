namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets MediaType
/// </summary>
public enum EvaluationResponseMediaType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Call for "CALL"
    /// </summary>
    Call,

    /// <summary>
    /// Enum Callback for "CALLBACK"
    /// </summary>
    Callback,

    /// <summary>
    /// Enum Chat for "CHAT"
    /// </summary>
    Chat,

    /// <summary>
    /// Enum Cobrowse for "COBROWSE"
    /// </summary>
    Cobrowse,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    Email,

    /// <summary>
    /// Enum Message for "MESSAGE"
    /// </summary>
    Message,

    /// <summary>
    /// Enum InternalMessage for "INTERNAL_MESSAGE"
    /// </summary>
    InternalMessage,

    /// <summary>
    /// Enum SocialExpression for "SOCIAL_EXPRESSION"
    /// </summary>
    SocialExpression,

    /// <summary>
    /// Enum Video for "VIDEO"
    /// </summary>
    Video,

    /// <summary>
    /// Enum Screenshare for "SCREENSHARE"
    /// </summary>
    Screenshare
}