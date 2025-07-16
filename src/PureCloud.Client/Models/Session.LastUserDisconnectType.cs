using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Disconnect reason for the last user connected to the conversation.
/// </summary>
/// <value>Disconnect reason for the last user connected to the conversation.</value>

public enum SessionLastUserDisconnectTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Endpoint for "Endpoint"
    /// </summary>
    [EnumMember(Value = "Endpoint")]
    Endpoint,

    /// <summary>
    /// Enum Client for "Client"
    /// </summary>
    [EnumMember(Value = "Client")]
    Client,

    /// <summary>
    /// Enum System for "System"
    /// </summary>
    [EnumMember(Value = "System")]
    System,

    /// <summary>
    /// Enum Transfer for "Transfer"
    /// </summary>
    [EnumMember(Value = "Transfer")]
    Transfer,

    /// <summary>
    /// Enum Error for "Error"
    /// </summary>
    [EnumMember(Value = "Error")]
    Error,

    /// <summary>
    /// Enum Peer for "Peer"
    /// </summary>
    [EnumMember(Value = "Peer")]
    Peer,

    /// <summary>
    /// Enum Other for "Other"
    /// </summary>
    [EnumMember(Value = "Other")]
    Other,

    /// <summary>
    /// Enum Spam for "Spam"
    /// </summary>
    [EnumMember(Value = "Spam")]
    Spam,

    /// <summary>
    /// Enum Timeout for "Timeout"
    /// </summary>
    [EnumMember(Value = "Timeout")]
    Timeout,

    /// <summary>
    /// Enum Transportfailure for "TransportFailure"
    /// </summary>
    [EnumMember(Value = "TransportFailure")]
    Transportfailure,

    /// <summary>
    /// Enum Conferencetransfer for "ConferenceTransfer"
    /// </summary>
    [EnumMember(Value = "ConferenceTransfer")]
    Conferencetransfer,

    /// <summary>
    /// Enum Consulttransfer for "ConsultTransfer"
    /// </summary>
    [EnumMember(Value = "ConsultTransfer")]
    Consulttransfer,

    /// <summary>
    /// Enum Forwardtransfer for "ForwardTransfer"
    /// </summary>
    [EnumMember(Value = "ForwardTransfer")]
    Forwardtransfer,

    /// <summary>
    /// Enum Noanswertransfer for "NoAnswerTransfer"
    /// </summary>
    [EnumMember(Value = "NoAnswerTransfer")]
    Noanswertransfer,

    /// <summary>
    /// Enum Notavailabletransfer for "NotAvailableTransfer"
    /// </summary>
    [EnumMember(Value = "NotAvailableTransfer")]
    Notavailabletransfer,

    /// <summary>
    /// Enum Uncallable for "Uncallable"
    /// </summary>
    [EnumMember(Value = "Uncallable")]
    Uncallable,

    /// <summary>
    /// Enum Donotdisturbendpoint for "DoNotDisturbEndpoint"
    /// </summary>
    [EnumMember(Value = "DoNotDisturbEndpoint")]
    Donotdisturbendpoint,

    /// <summary>
    /// Enum Donotdisturbtransfer for "DoNotDisturbTransfer"
    /// </summary>
    [EnumMember(Value = "DoNotDisturbTransfer")]
    Donotdisturbtransfer
}
