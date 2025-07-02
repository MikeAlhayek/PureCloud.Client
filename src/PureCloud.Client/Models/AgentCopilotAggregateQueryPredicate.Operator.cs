using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Optional operator, default is matches
/// </summary>
/// <value>Optional operator, default is matches</value>

public enum AgentCopilotAggregateQueryPredicateOperatorEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Matches for "matches"
    /// </summary>
    [EnumMember(Value = "matches")]
    Matches,

    /// <summary>
    /// Enum Exists for "exists"
    /// </summary>
    [EnumMember(Value = "exists")]
    Exists,

    /// <summary>
    /// Enum Notexists for "notExists"
    /// </summary>
    [EnumMember(Value = "notExists")]
    Notexists
}
