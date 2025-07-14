using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EmailCommunicationEndedEventDisconnectTypeEnum
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
    /// Enum Self for "Self"
    /// </summary>
    [EnumMember(Value = "Self")]
    Self,

    /// <summary>
    /// Enum Peer for "Peer"
    /// </summary>
    [EnumMember(Value = "Peer")]
    Peer,

    /// <summary>
    /// Enum System for "System"
    /// </summary>
    [EnumMember(Value = "System")]
    System,

    /// <summary>
    /// Enum Error for "Error"
    /// </summary>
    [EnumMember(Value = "Error")]
    Error,

    /// <summary>
    /// Enum Spam for "Spam"
    /// </summary>
    [EnumMember(Value = "Spam")]
    Spam,

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
    /// Enum Transferuser for "TransferUser"
    /// </summary>
    [EnumMember(Value = "TransferUser")]
    Transferuser
}
