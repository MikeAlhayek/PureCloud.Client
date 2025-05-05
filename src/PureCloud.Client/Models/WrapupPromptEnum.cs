using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WrapupPromptEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Mandatory for "MANDATORY"
    /// </summary>
    [EnumMember(Value = "MANDATORY")]
    Mandatory,

    /// <summary>
    /// Enum Optional for "OPTIONAL"
    /// </summary>
    [EnumMember(Value = "OPTIONAL")]
    Optional,

    /// <summary>
    /// Enum MandatoryTimeout for "MANDATORY_TIMEOUT"
    /// </summary>
    [EnumMember(Value = "MANDATORY_TIMEOUT")]
    MandatoryTimeout,

    /// <summary>
    /// Enum MandatoryForcedTimeout for "MANDATORY_FORCED_TIMEOUT"
    /// </summary>
    [EnumMember(Value = "MANDATORY_FORCED_TIMEOUT")]
    MandatoryForcedTimeout,

    /// <summary>
    /// Enum AgentRequested for "AGENT_REQUESTED"
    /// </summary>
    [EnumMember(Value = "AGENT_REQUESTED")]
    AgentRequested
}
