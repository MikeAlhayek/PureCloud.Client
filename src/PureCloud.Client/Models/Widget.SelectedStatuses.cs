using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets SelectedStatuses
/// </summary>

public enum WidgetSelectedStatusesEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Available for "Available"
    /// </summary>
    [EnumMember(Value = "Available")]
    Available,

    /// <summary>
    /// Enum Away for "Away"
    /// </summary>
    [EnumMember(Value = "Away")]
    Away,

    /// <summary>
    /// Enum Busy for "Busy"
    /// </summary>
    [EnumMember(Value = "Busy")]
    Busy,

    /// <summary>
    /// Enum Break for "Break"
    /// </summary>
    [EnumMember(Value = "Break")]
    Break,

    /// <summary>
    /// Enum Meeting for "Meeting"
    /// </summary>
    [EnumMember(Value = "Meeting")]
    Meeting,

    /// <summary>
    /// Enum Training for "Training"
    /// </summary>
    [EnumMember(Value = "Training")]
    Training,

    /// <summary>
    /// Enum Meal for "Meal"
    /// </summary>
    [EnumMember(Value = "Meal")]
    Meal,

    /// <summary>
    /// Enum Systemaway for "SystemAway"
    /// </summary>
    [EnumMember(Value = "SystemAway")]
    Systemaway,

    /// <summary>
    /// Enum Onqueue for "OnQueue"
    /// </summary>
    [EnumMember(Value = "OnQueue")]
    Onqueue,

    /// <summary>
    /// Enum Interacting for "Interacting"
    /// </summary>
    [EnumMember(Value = "Interacting")]
    Interacting,

    /// <summary>
    /// Enum Notresponding for "NotResponding"
    /// </summary>
    [EnumMember(Value = "NotResponding")]
    Notresponding,

    /// <summary>
    /// Enum Idle for "Idle"
    /// </summary>
    [EnumMember(Value = "Idle")]
    Idle,

    /// <summary>
    /// Enum Communicating for "Communicating"
    /// </summary>
    [EnumMember(Value = "Communicating")]
    Communicating,

    /// <summary>
    /// Enum Offqueue for "OffQueue"
    /// </summary>
    [EnumMember(Value = "OffQueue")]
    Offqueue,

    /// <summary>
    /// Enum Online for "Online"
    /// </summary>
    [EnumMember(Value = "Online")]
    Online,

    /// <summary>
    /// Enum Offline for "Offline"
    /// </summary>
    [EnumMember(Value = "Offline")]
    Offline
}
