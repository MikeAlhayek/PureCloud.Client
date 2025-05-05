using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CallbackMediaMode
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Agentfirst for "AgentFirst"
    /// </summary>
    [EnumMember(Value = "AgentFirst")]
    Agentfirst,

    /// <summary>
    /// Enum Customerfirst for "CustomerFirst"
    /// </summary>
    [EnumMember(Value = "CustomerFirst")]
    Customerfirst
}
