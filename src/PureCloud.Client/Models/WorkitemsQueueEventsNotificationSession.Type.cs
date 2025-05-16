using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WorkitemsQueueEventsNotificationSessionTypeEnum
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
    /// Enum Agent for "Agent"
    /// </summary>
    [EnumMember(Value = "Agent")]
    Agent,

    /// <summary>
    /// Enum Queueassignment for "QueueAssignment"
    /// </summary>
    [EnumMember(Value = "QueueAssignment")]
    Queueassignment,

    /// <summary>
    /// Enum Directassignment for "DirectAssignment"
    /// </summary>
    [EnumMember(Value = "DirectAssignment")]
    Directassignment,

    /// <summary>
    /// Enum Agentcomplete for "AgentComplete"
    /// </summary>
    [EnumMember(Value = "AgentComplete")]
    Agentcomplete
}
