using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Bot channels enumeration.
/// </summary>
public enum PostTextRequestBotChannels
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

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
    /// Enum Messaging for "Messaging"
    /// </summary>
    [EnumMember(Value = "Messaging")]
    Messaging,

    /// <summary>
    /// Enum Webchat for "Webchat"
    /// </summary>
    [EnumMember(Value = "Webchat")]
    Webchat
}