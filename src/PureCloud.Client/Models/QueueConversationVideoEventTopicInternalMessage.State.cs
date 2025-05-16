using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum QueueConversationVideoEventTopicInternalMessageStateEnum
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
    Disconnected
}
