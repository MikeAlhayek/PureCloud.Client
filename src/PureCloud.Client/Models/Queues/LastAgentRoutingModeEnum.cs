using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Queues;

/// <summary>
/// The Last Agent Routing Mode for the queue.
/// </summary>
/// <value>The Last Agent Routing Mode for the queue.</value>

public enum LastAgentRoutingModeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Disabled for "Disabled"
    /// </summary>
    [EnumMember(Value = "Disabled")]
    Disabled,

    /// <summary>
    /// Enum Queuemembersonly for "QueueMembersOnly"
    /// </summary>
    [EnumMember(Value = "QueueMembersOnly")]
    Queuemembersonly,

    /// <summary>
    /// Enum Anyagent for "AnyAgent"
    /// </summary>
    [EnumMember(Value = "AnyAgent")]
    Anyagent
}
