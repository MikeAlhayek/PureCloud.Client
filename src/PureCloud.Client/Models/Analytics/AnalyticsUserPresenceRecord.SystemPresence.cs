using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AnalyticsUserPresenceRecordSystemPresenceEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Available for "AVAILABLE"
    /// </summary>
    [EnumMember(Value = "AVAILABLE")]
    Available,

    /// <summary>
    /// Enum Away for "AWAY"
    /// </summary>
    [EnumMember(Value = "AWAY")]
    Away,

    /// <summary>
    /// Enum Busy for "BUSY"
    /// </summary>
    [EnumMember(Value = "BUSY")]
    Busy,

    /// <summary>
    /// Enum Offline for "OFFLINE"
    /// </summary>
    [EnumMember(Value = "OFFLINE")]
    Offline,

    /// <summary>
    /// Enum Idle for "IDLE"
    /// </summary>
    [EnumMember(Value = "IDLE")]
    Idle,

    /// <summary>
    /// Enum OnQueue for "ON_QUEUE"
    /// </summary>
    [EnumMember(Value = "ON_QUEUE")]
    OnQueue,

    /// <summary>
    /// Enum Meal for "MEAL"
    /// </summary>
    [EnumMember(Value = "MEAL")]
    Meal,

    /// <summary>
    /// Enum Training for "TRAINING"
    /// </summary>
    [EnumMember(Value = "TRAINING")]
    Training,

    /// <summary>
    /// Enum Meeting for "MEETING"
    /// </summary>
    [EnumMember(Value = "MEETING")]
    Meeting,

    /// <summary>
    /// Enum Break for "BREAK"
    /// </summary>
    [EnumMember(Value = "BREAK")]
    Break
}
