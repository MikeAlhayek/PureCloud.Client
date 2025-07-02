using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AgentStateSegmentTypeCountSegmentTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Alert for "alert"
    /// </summary>
    [EnumMember(Value = "alert")]
    Alert,

    /// <summary>
    /// Enum Barging for "barging"
    /// </summary>
    [EnumMember(Value = "barging")]
    Barging,

    /// <summary>
    /// Enum Callback for "callback"
    /// </summary>
    [EnumMember(Value = "callback")]
    Callback,

    /// <summary>
    /// Enum Coaching for "coaching"
    /// </summary>
    [EnumMember(Value = "coaching")]
    Coaching,

    /// <summary>
    /// Enum Contacting for "contacting"
    /// </summary>
    [EnumMember(Value = "contacting")]
    Contacting,

    /// <summary>
    /// Enum Converting for "converting"
    /// </summary>
    [EnumMember(Value = "converting")]
    Converting,

    /// <summary>
    /// Enum Delay for "delay"
    /// </summary>
    [EnumMember(Value = "delay")]
    Delay,

    /// <summary>
    /// Enum Dialing for "dialing"
    /// </summary>
    [EnumMember(Value = "dialing")]
    Dialing,

    /// <summary>
    /// Enum Hold for "hold"
    /// </summary>
    [EnumMember(Value = "hold")]
    Hold,

    /// <summary>
    /// Enum Interact for "interact"
    /// </summary>
    [EnumMember(Value = "interact")]
    Interact,

    /// <summary>
    /// Enum Ivr for "ivr"
    /// </summary>
    [EnumMember(Value = "ivr")]
    Ivr,

    /// <summary>
    /// Enum Monitoring for "monitoring"
    /// </summary>
    [EnumMember(Value = "monitoring")]
    Monitoring,

    /// <summary>
    /// Enum Parked for "parked"
    /// </summary>
    [EnumMember(Value = "parked")]
    Parked,

    /// <summary>
    /// Enum Scheduled for "scheduled"
    /// </summary>
    [EnumMember(Value = "scheduled")]
    Scheduled,

    /// <summary>
    /// Enum Sharing for "sharing"
    /// </summary>
    [EnumMember(Value = "sharing")]
    Sharing,

    /// <summary>
    /// Enum System for "system"
    /// </summary>
    [EnumMember(Value = "system")]
    System,

    /// <summary>
    /// Enum Transmitting for "transmitting"
    /// </summary>
    [EnumMember(Value = "transmitting")]
    Transmitting,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Enum Uploading for "uploading"
    /// </summary>
    [EnumMember(Value = "uploading")]
    Uploading,

    /// <summary>
    /// Enum Voicemail for "voicemail"
    /// </summary>
    [EnumMember(Value = "voicemail")]
    Voicemail,

    /// <summary>
    /// Enum Wrapup for "wrapup"
    /// </summary>
    [EnumMember(Value = "wrapup")]
    Wrapup
}
