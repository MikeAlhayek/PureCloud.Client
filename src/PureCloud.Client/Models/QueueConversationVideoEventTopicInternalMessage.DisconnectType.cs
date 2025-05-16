using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
/// </summary>
/// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>

public enum QueueConversationVideoEventTopicInternalMessageDisconnectTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Client for "client"
    /// </summary>
    [EnumMember(Value = "client")]
    Client,

    /// <summary>
    /// Enum System for "system"
    /// </summary>
    [EnumMember(Value = "system")]
    System,

    /// <summary>
    /// Enum Peer for "peer"
    /// </summary>
    [EnumMember(Value = "peer")]
    Peer,

    /// <summary>
    /// Enum Transfer for "transfer"
    /// </summary>
    [EnumMember(Value = "transfer")]
    Transfer
}
