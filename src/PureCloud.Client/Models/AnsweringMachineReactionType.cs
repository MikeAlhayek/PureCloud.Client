using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The action to take if an answering machine is detected during the outbound call of a customer first callback.
/// </summary>
/// <value>The action to take if an answering machine is detected during the outbound call of a customer first callback.</value>

public enum AnsweringMachineReactionType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Hangup for "HangUp"
    /// </summary>
    [EnumMember(Value = "HangUp")]
    Hangup,

    /// <summary>
    /// Enum Transfertoqueue for "TransferToQueue"
    /// </summary>
    [EnumMember(Value = "TransferToQueue")]
    Transfertoqueue,

    /// <summary>
    /// Enum Transfertoflow for "TransferToFlow"
    /// </summary>
    [EnumMember(Value = "TransferToFlow")]
    Transfertoflow
}
