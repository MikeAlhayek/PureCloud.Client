using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Indicates the state of the agent experience recorder.
/// </summary>
/// <value>Indicates the state of the agent experience recorder.</value>

public enum RecordersStateAgentExperienceState
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Active for "ACTIVE"
    /// </summary>
    [EnumMember(Value = "ACTIVE")]
    Active,

    /// <summary>
    /// Enum Paused for "PAUSED"
    /// </summary>
    [EnumMember(Value = "PAUSED")]
    Paused,

    /// <summary>
    /// Enum None for "NONE"
    /// </summary>
    [EnumMember(Value = "NONE")]
    None
}
