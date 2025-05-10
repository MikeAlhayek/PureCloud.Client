using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The initial connection state of this communication.
/// </summary>
/// <value>The initial connection state of this communication.</value>

public enum EmailInitialState
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Alerting for "alerting"
    /// </summary>
    [EnumMember(Value = "alerting")]
    Alerting,

    /// <summary>
    /// Enum Connected for "connected"
    /// </summary>
    [EnumMember(Value = "connected")]
    Connected,

    /// <summary>
    /// Enum Disconnected for "disconnected"
    /// </summary>
    [EnumMember(Value = "disconnected")]
    Disconnected,

    /// <summary>
    /// Enum None for "none"
    /// </summary>
    [EnumMember(Value = "none")]
    None,

    /// <summary>
    /// Enum Parked for "parked"
    /// </summary>
    [EnumMember(Value = "parked")]
    Parked,

    /// <summary>
    /// Enum Transmitting for "transmitting"
    /// </summary>
    [EnumMember(Value = "transmitting")]
    Transmitting
}
