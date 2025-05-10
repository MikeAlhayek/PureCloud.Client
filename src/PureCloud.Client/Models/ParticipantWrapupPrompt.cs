using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// This field controls how the UI prompts the agent for a wrapup.
/// </summary>
/// <value>This field controls how the UI prompts the agent for a wrapup.</value>

public enum ParticipantWrapupPrompt
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Mandatory for "mandatory"
    /// </summary>
    [EnumMember(Value = "mandatory")]
    Mandatory,

    /// <summary>
    /// Enum Optional for "optional"
    /// </summary>
    [EnumMember(Value = "optional")]
    Optional,

    /// <summary>
    /// Enum Agentrequested for "agentRequested"
    /// </summary>
    [EnumMember(Value = "agentRequested")]
    Agentrequested,

    /// <summary>
    /// Enum Timeout for "timeout"
    /// </summary>
    [EnumMember(Value = "timeout")]
    Timeout,

    /// <summary>
    /// Enum Forcedtimeout for "forcedTimeout"
    /// </summary>
    [EnumMember(Value = "forcedTimeout")]
    Forcedtimeout
}
