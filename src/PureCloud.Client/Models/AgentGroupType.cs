using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Conditional group routing agent group type
/// </summary>
/// <value>Conditional group routing agent group type</value>

public enum AgentGroupType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Group for "Group"
    /// </summary>
    [EnumMember(Value = "Group")]
    Group,

    /// <summary>
    /// Enum Skillgroup for "SkillGroup"
    /// </summary>
    [EnumMember(Value = "SkillGroup")]
    Skillgroup,

    /// <summary>
    /// Enum Team for "Team"
    /// </summary>
    [EnumMember(Value = "Team")]
    Team
}
