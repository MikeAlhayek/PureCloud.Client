using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowEndDetailEventTopicFlowEndEventDisconnectTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum Endpoint for "ENDPOINT"
    /// </summary>
    [EnumMember(Value = "ENDPOINT")]
    Endpoint,

    /// <summary>
    /// Enum Client for "CLIENT"
    /// </summary>
    [EnumMember(Value = "CLIENT")]
    Client,

    /// <summary>
    /// Enum System for "SYSTEM"
    /// </summary>
    [EnumMember(Value = "SYSTEM")]
    System,

    /// <summary>
    /// Enum Transfer for "TRANSFER"
    /// </summary>
    [EnumMember(Value = "TRANSFER")]
    Transfer,

    /// <summary>
    /// Enum Error for "ERROR"
    /// </summary>
    [EnumMember(Value = "ERROR")]
    Error,

    /// <summary>
    /// Enum Peer for "PEER"
    /// </summary>
    [EnumMember(Value = "PEER")]
    Peer,

    /// <summary>
    /// Enum Other for "OTHER"
    /// </summary>
    [EnumMember(Value = "OTHER")]
    Other,

    /// <summary>
    /// Enum Spam for "SPAM"
    /// </summary>
    [EnumMember(Value = "SPAM")]
    Spam,

    /// <summary>
    /// Enum Timeout for "TIMEOUT"
    /// </summary>
    [EnumMember(Value = "TIMEOUT")]
    Timeout,

    /// <summary>
    /// Enum TransportFailure for "TRANSPORT_FAILURE"
    /// </summary>
    [EnumMember(Value = "TRANSPORT_FAILURE")]
    TransportFailure,

    /// <summary>
    /// Enum ConferenceTransfer for "CONFERENCE_TRANSFER"
    /// </summary>
    [EnumMember(Value = "CONFERENCE_TRANSFER")]
    ConferenceTransfer,

    /// <summary>
    /// Enum ConsultTransfer for "CONSULT_TRANSFER"
    /// </summary>
    [EnumMember(Value = "CONSULT_TRANSFER")]
    ConsultTransfer,

    /// <summary>
    /// Enum ForwardTransfer for "FORWARD_TRANSFER"
    /// </summary>
    [EnumMember(Value = "FORWARD_TRANSFER")]
    ForwardTransfer,

    /// <summary>
    /// Enum NoAnswerTransfer for "NO_ANSWER_TRANSFER"
    /// </summary>
    [EnumMember(Value = "NO_ANSWER_TRANSFER")]
    NoAnswerTransfer,

    /// <summary>
    /// Enum NotAvailableTransfer for "NOT_AVAILABLE_TRANSFER"
    /// </summary>
    [EnumMember(Value = "NOT_AVAILABLE_TRANSFER")]
    NotAvailableTransfer,

    /// <summary>
    /// Enum Uncallable for "UNCALLABLE"
    /// </summary>
    [EnumMember(Value = "UNCALLABLE")]
    Uncallable,

    /// <summary>
    /// Enum DndEndpoint for "DND_ENDPOINT"
    /// </summary>
    [EnumMember(Value = "DND_ENDPOINT")]
    DndEndpoint,

    /// <summary>
    /// Enum DndTransfer for "DND_TRANSFER"
    /// </summary>
    [EnumMember(Value = "DND_TRANSFER")]
    DndTransfer
}
