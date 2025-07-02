using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets BotResultList
/// </summary>

public enum ViewFilterBotResultListEnum
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
    /// Enum Exitrequestedbyuser for "ExitRequestedByUser"
    /// </summary>
    [EnumMember(Value = "ExitRequestedByUser")]
    Exitrequestedbyuser,

    /// <summary>
    /// Enum Exitrequestedbybot for "ExitRequestedByBot"
    /// </summary>
    [EnumMember(Value = "ExitRequestedByBot")]
    Exitrequestedbybot,

    /// <summary>
    /// Enum Exiterror for "ExitError"
    /// </summary>
    [EnumMember(Value = "ExitError")]
    Exiterror,

    /// <summary>
    /// Enum Exitrecognitionfailure for "ExitRecognitionFailure"
    /// </summary>
    [EnumMember(Value = "ExitRecognitionFailure")]
    Exitrecognitionfailure,

    /// <summary>
    /// Enum Disconnectrequestedbyuser for "DisconnectRequestedByUser"
    /// </summary>
    [EnumMember(Value = "DisconnectRequestedByUser")]
    Disconnectrequestedbyuser,

    /// <summary>
    /// Enum Disconnectrequestedbybot for "DisconnectRequestedByBot"
    /// </summary>
    [EnumMember(Value = "DisconnectRequestedByBot")]
    Disconnectrequestedbybot,

    /// <summary>
    /// Enum Disconnectsessionexpired for "DisconnectSessionExpired"
    /// </summary>
    [EnumMember(Value = "DisconnectSessionExpired")]
    Disconnectsessionexpired,

    /// <summary>
    /// Enum Disconnecterror for "DisconnectError"
    /// </summary>
    [EnumMember(Value = "DisconnectError")]
    Disconnecterror,

    /// <summary>
    /// Enum Disconnectrecognitionfailure for "DisconnectRecognitionFailure"
    /// </summary>
    [EnumMember(Value = "DisconnectRecognitionFailure")]
    Disconnectrecognitionfailure,

    /// <summary>
    /// Enum Transfertoacd for "TransferToACD"
    /// </summary>
    [EnumMember(Value = "TransferToACD")]
    Transfertoacd
}
