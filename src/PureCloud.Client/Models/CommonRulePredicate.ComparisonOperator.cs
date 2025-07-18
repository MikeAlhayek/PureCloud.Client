using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The comparison operator being performed on the metric.
/// </summary>
/// <value>The comparison operator being performed on the metric.</value>

public enum CommonRulePredicateComparisonOperatorEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Gt for "Gt"
    /// </summary>
    [EnumMember(Value = "Gt")]
    Gt,

    /// <summary>
    /// Enum Gte for "Gte"
    /// </summary>
    [EnumMember(Value = "Gte")]
    Gte,

    /// <summary>
    /// Enum Lt for "Lt"
    /// </summary>
    [EnumMember(Value = "Lt")]
    Lt,

    /// <summary>
    /// Enum Lte for "Lte"
    /// </summary>
    [EnumMember(Value = "Lte")]
    Lte,

    /// <summary>
    /// Enum Eq for "Eq"
    /// </summary>
    [EnumMember(Value = "Eq")]
    Eq,

    /// <summary>
    /// Enum Ne for "Ne"
    /// </summary>
    [EnumMember(Value = "Ne")]
    Ne
}
