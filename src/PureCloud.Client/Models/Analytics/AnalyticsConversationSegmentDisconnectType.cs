using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Analytics;

/// <summary>
/// The session disconnect type
/// </summary>
/// <value>The session disconnect type</value>

public enum AnalyticsConversationSegmentDisconnectType
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
    /// Enum Conferencetransfer for "conferenceTransfer"
    /// </summary>
    [EnumMember(Value = "conferenceTransfer")]
    Conferencetransfer,

    /// <summary>
    /// Enum Consulttransfer for "consultTransfer"
    /// </summary>
    [EnumMember(Value = "consultTransfer")]
    Consulttransfer,

    /// <summary>
    /// Enum Dndendpoint for "dndEndpoint"
    /// </summary>
    [EnumMember(Value = "dndEndpoint")]
    Dndendpoint,

    /// <summary>
    /// Enum Dndtransfer for "dndTransfer"
    /// </summary>
    [EnumMember(Value = "dndTransfer")]
    Dndtransfer,

    /// <summary>
    /// Enum Endpoint for "endpoint"
    /// </summary>
    [EnumMember(Value = "endpoint")]
    Endpoint,

    /// <summary>
    /// Enum Error for "error"
    /// </summary>
    [EnumMember(Value = "error")]
    Error,

    /// <summary>
    /// Enum Forwardtransfer for "forwardTransfer"
    /// </summary>
    [EnumMember(Value = "forwardTransfer")]
    Forwardtransfer,

    /// <summary>
    /// Enum Noanswertransfer for "noAnswerTransfer"
    /// </summary>
    [EnumMember(Value = "noAnswerTransfer")]
    Noanswertransfer,

    /// <summary>
    /// Enum Notavailabletransfer for "notAvailableTransfer"
    /// </summary>
    [EnumMember(Value = "notAvailableTransfer")]
    Notavailabletransfer,

    /// <summary>
    /// Enum Other for "other"
    /// </summary>
    [EnumMember(Value = "other")]
    Other,

    /// <summary>
    /// Enum Peer for "peer"
    /// </summary>
    [EnumMember(Value = "peer")]
    Peer,

    /// <summary>
    /// Enum Spam for "spam"
    /// </summary>
    [EnumMember(Value = "spam")]
    Spam,

    /// <summary>
    /// Enum System for "system"
    /// </summary>
    [EnumMember(Value = "system")]
    System,

    /// <summary>
    /// Enum Timeout for "timeout"
    /// </summary>
    [EnumMember(Value = "timeout")]
    Timeout,

    /// <summary>
    /// Enum Transfer for "transfer"
    /// </summary>
    [EnumMember(Value = "transfer")]
    Transfer,

    /// <summary>
    /// Enum Transportfailure for "transportFailure"
    /// </summary>
    [EnumMember(Value = "transportFailure")]
    Transportfailure,

    /// <summary>
    /// Enum Uncallable for "uncallable"
    /// </summary>
    [EnumMember(Value = "uncallable")]
    Uncallable
}
