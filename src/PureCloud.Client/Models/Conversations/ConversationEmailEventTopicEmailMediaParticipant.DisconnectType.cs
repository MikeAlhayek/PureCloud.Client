using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets DisconnectType
/// </summary>

public enum ConversationEmailEventTopicEmailMediaParticipantDisconnectTypeEnum
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
    /// Enum Endpointdnd for "endpoint.dnd"
    /// </summary>
    [EnumMember(Value = "endpoint.dnd")]
    Endpointdnd,

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
    /// Enum Timeout for "timeout"
    /// </summary>
    [EnumMember(Value = "timeout")]
    Timeout,

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
    /// Enum Transfernoanswer for "transfer.noanswer"
    /// </summary>
    [EnumMember(Value = "transfer.noanswer")]
    Transfernoanswer,

    /// <summary>
    /// Enum Transfernotavailable for "transfer.notavailable"
    /// </summary>
    [EnumMember(Value = "transfer.notavailable")]
    Transfernotavailable,

    /// <summary>
    /// Enum Transferdnd for "transfer.dnd"
    /// </summary>
    [EnumMember(Value = "transfer.dnd")]
    Transferdnd,

    /// <summary>
    /// Enum Transportfailure for "transport.failure"
    /// </summary>
    [EnumMember(Value = "transport.failure")]
    Transportfailure,

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
    /// Enum Spam for "spam"
    /// </summary>
    [EnumMember(Value = "spam")]
    Spam,

    /// <summary>
    /// Enum Uncallable for "uncallable"
    /// </summary>
    [EnumMember(Value = "uncallable")]
    Uncallable
}
