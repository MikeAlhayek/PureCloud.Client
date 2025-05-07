using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ConversationSummaryTopicVirtualAgentsTriggerSourceSourceTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum AgentAssistant for "AGENT_ASSISTANT"
    /// </summary>
    [EnumMember(Value = "AGENT_ASSISTANT")]
    AgentAssistant,

    /// <summary>
    /// Enum Program for "PROGRAM"
    /// </summary>
    [EnumMember(Value = "PROGRAM")]
    Program,

    /// <summary>
    /// Enum Flow for "FLOW"
    /// </summary>
    [EnumMember(Value = "FLOW")]
    Flow,

    /// <summary>
    /// Enum Copilot for "COPILOT"
    /// </summary>
    [EnumMember(Value = "COPILOT")]
    Copilot
}
