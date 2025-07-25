using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Indicates the suggested next action. If appropriate, the matching output event object includes additional information.
/// </summary>
public enum TextBotFlowTurnResponseNextActionType
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
    /// Enum Disconnect for "Disconnect"
    /// </summary>
    [EnumMember(Value = "Disconnect")]
    Disconnect,

    /// <summary>
    /// Enum Waitforinput for "WaitForInput"
    /// </summary>
    [EnumMember(Value = "WaitForInput")]
    Waitforinput,

    /// <summary>
    /// Enum Exit for "Exit"
    /// </summary>
    [EnumMember(Value = "Exit")]
    Exit
}