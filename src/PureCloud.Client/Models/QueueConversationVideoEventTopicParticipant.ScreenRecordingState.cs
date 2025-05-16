using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum QueueConversationVideoEventTopicParticipantScreenRecordingStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Requested for "requested"
    /// </summary>
    [EnumMember(Value = "requested")]
    Requested,

    /// <summary>
    /// Enum Active for "active"
    /// </summary>
    [EnumMember(Value = "active")]
    Active,

    /// <summary>
    /// Enum Paused for "paused"
    /// </summary>
    [EnumMember(Value = "paused")]
    Paused,

    /// <summary>
    /// Enum Stopped for "stopped"
    /// </summary>
    [EnumMember(Value = "stopped")]
    Stopped,

    /// <summary>
    /// Enum Error for "error"
    /// </summary>
    [EnumMember(Value = "error")]
    Error,

    /// <summary>
    /// Enum Timeout for "timeout"
    /// </summary>
    [EnumMember(Value = "timeout")]
    Timeout
}
