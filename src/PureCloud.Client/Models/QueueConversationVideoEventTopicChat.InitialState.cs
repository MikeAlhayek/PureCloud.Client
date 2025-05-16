using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets InitialState
/// </summary>

public enum QueueConversationVideoEventTopicChatInitialStateEnum
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
    /// Enum Dialing for "dialing"
    /// </summary>
    [EnumMember(Value = "dialing")]
    Dialing,

    /// <summary>
    /// Enum Contacting for "contacting"
    /// </summary>
    [EnumMember(Value = "contacting")]
    Contacting,

    /// <summary>
    /// Enum Offering for "offering"
    /// </summary>
    [EnumMember(Value = "offering")]
    Offering,

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
    /// Enum Terminated for "terminated"
    /// </summary>
    [EnumMember(Value = "terminated")]
    Terminated,

    /// <summary>
    /// Enum None for "none"
    /// </summary>
    [EnumMember(Value = "none")]
    None
}
