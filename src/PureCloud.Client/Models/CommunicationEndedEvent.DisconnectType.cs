using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CommunicationEndedEventDisconnectTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

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
    /// Enum Self for "Self"
    /// </summary>
    [EnumMember(Value = "Self")]
    Self,

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
    /// Enum Transferacd for "TransferACD"
    /// </summary>
    [EnumMember(Value = "TransferACD")]
    Transferacd,

    /// <summary>
    /// Enum Transferconference for "TransferConference"
    /// </summary>
    [EnumMember(Value = "TransferConference")]
    Transferconference,

    /// <summary>
    /// Enum Transferconsult for "TransferConsult"
    /// </summary>
    [EnumMember(Value = "TransferConsult")]
    Transferconsult,

    /// <summary>
    /// Enum Transferuser for "TransferUser"
    /// </summary>
    [EnumMember(Value = "TransferUser")]
    Transferuser
}
