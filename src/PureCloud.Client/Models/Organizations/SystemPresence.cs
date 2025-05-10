using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Organizations;

public enum SystemPresence
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
    /// Enum Offline for "Offline"
    /// </summary>
    [EnumMember(Value = "Offline")]
    Offline,

    /// <summary>
    /// Enum Idle for "Idle"
    /// </summary>
    [EnumMember(Value = "Idle")]
    Idle,

    /// <summary>
    /// Enum Onqueue for "OnQueue"
    /// </summary>
    [EnumMember(Value = "OnQueue")]
    Onqueue,

    /// <summary>
    /// Enum Meal for "Meal"
    /// </summary>
    [EnumMember(Value = "Meal")]
    Meal,

    /// <summary>
    /// Enum Training for "Training"
    /// </summary>
    [EnumMember(Value = "Training")]
    Training,

    /// <summary>
    /// Enum Meeting for "Meeting"
    /// </summary>
    [EnumMember(Value = "Meeting")]
    Meeting,

    /// <summary>
    /// Enum Break for "Break"
    /// </summary>
    [EnumMember(Value = "Break")]
    Break
}
