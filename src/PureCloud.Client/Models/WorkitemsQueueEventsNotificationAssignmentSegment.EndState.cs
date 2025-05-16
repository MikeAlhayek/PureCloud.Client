using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets EndState
/// </summary>

public enum WorkitemsQueueEventsNotificationAssignmentSegmentEndStateEnum
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
    /// Enum Idle for "Idle"
    /// </summary>
    [EnumMember(Value = "Idle")]
    Idle,

    /// <summary>
    /// Enum Acdstarted for "AcdStarted"
    /// </summary>
    [EnumMember(Value = "AcdStarted")]
    Acdstarted,

    /// <summary>
    /// Enum Alerting for "Alerting"
    /// </summary>
    [EnumMember(Value = "Alerting")]
    Alerting,

    /// <summary>
    /// Enum Alerttimeout for "AlertTimeout"
    /// </summary>
    [EnumMember(Value = "AlertTimeout")]
    Alerttimeout,

    /// <summary>
    /// Enum Declined for "Declined"
    /// </summary>
    [EnumMember(Value = "Declined")]
    Declined,

    /// <summary>
    /// Enum Connected for "Connected"
    /// </summary>
    [EnumMember(Value = "Connected")]
    Connected,

    /// <summary>
    /// Enum Disconnected for "Disconnected"
    /// </summary>
    [EnumMember(Value = "Disconnected")]
    Disconnected,

    /// <summary>
    /// Enum Parked for "Parked"
    /// </summary>
    [EnumMember(Value = "Parked")]
    Parked,

    /// <summary>
    /// Enum Held for "Held"
    /// </summary>
    [EnumMember(Value = "Held")]
    Held,

    /// <summary>
    /// Enum Acdcancelled for "AcdCancelled"
    /// </summary>
    [EnumMember(Value = "AcdCancelled")]
    Acdcancelled,

    /// <summary>
    /// Enum Terminated for "Terminated"
    /// </summary>
    [EnumMember(Value = "Terminated")]
    Terminated,

    /// <summary>
    /// Enum Acdexpired for "AcdExpired"
    /// </summary>
    [EnumMember(Value = "AcdExpired")]
    Acdexpired
}
