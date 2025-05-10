using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
/// </summary>
/// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>

public enum ConversationChatDisconnectType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Endpoint for "endpoint"
    /// </summary>
    [EnumMember(Value = "endpoint")]
    Endpoint,

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
    /// Enum Transfer for "transfer"
    /// </summary>
    [EnumMember(Value = "transfer")]
    Transfer,

    /// <summary>
    /// Enum Transferconference for "transfer.conference"
    /// </summary>
    [EnumMember(Value = "transfer.conference")]
    Transferconference,

    /// <summary>
    /// Enum Transferconsult for "transfer.consult"
    /// </summary>
    [EnumMember(Value = "transfer.consult")]
    Transferconsult,

    /// <summary>
    /// Enum Transferforward for "transfer.forward"
    /// </summary>
    [EnumMember(Value = "transfer.forward")]
    Transferforward,

    /// <summary>
    /// Enum Error for "error"
    /// </summary>
    [EnumMember(Value = "error")]
    Error,

    /// <summary>
    /// Enum Peer for "peer"
    /// </summary>
    [EnumMember(Value = "peer")]
    Peer,

    /// <summary>
    /// Enum Other for "other"
    /// </summary>
    [EnumMember(Value = "other")]
    Other,

    /// <summary>
    /// Enum Uncallable for "uncallable"
    /// </summary>
    [EnumMember(Value = "uncallable")]
    Uncallable,

    /// <summary>
    /// Enum Timeout for "timeout"
    /// </summary>
    [EnumMember(Value = "timeout")]
    Timeout
}
