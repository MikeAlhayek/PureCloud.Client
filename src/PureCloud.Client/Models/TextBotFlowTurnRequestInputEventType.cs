using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Indicates the type of input event being requested. If appropriate, fill out the matching user input object details on this request.
/// </summary>
public enum TextBotFlowTurnRequestInputEventType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Noop for "NoOp"
    /// </summary>
    [EnumMember(Value = "NoOp")]
    Noop,

    /// <summary>
    /// Enum Userinput for "UserInput"
    /// </summary>
    [EnumMember(Value = "UserInput")]
    Userinput,

    /// <summary>
    /// Enum Error for "Error"
    /// </summary>
    [EnumMember(Value = "Error")]
    Error,

    /// <summary>
    /// Enum Nomatch for "NoMatch"
    /// </summary>
    [EnumMember(Value = "NoMatch")]
    Nomatch,

    /// <summary>
    /// Enum Noinput for "NoInput"
    /// </summary>
    [EnumMember(Value = "NoInput")]
    Noinput,

    /// <summary>
    /// Enum Userdisconnect for "UserDisconnect"
    /// </summary>
    [EnumMember(Value = "UserDisconnect")]
    Userdisconnect,

    /// <summary>
    /// Enum Clientsessionexpired for "ClientSessionExpired"
    /// </summary>
    [EnumMember(Value = "ClientSessionExpired")]
    Clientsessionexpired
}