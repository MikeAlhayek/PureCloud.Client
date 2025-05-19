using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Statistic
/// </summary>

public enum KlaxonInteractionStatsRulesTopicInteractionStatRuleStatisticEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Count for "count"
    /// </summary>
    [EnumMember(Value = "count")]
    Count,

    /// <summary>
    /// Enum Min for "min"
    /// </summary>
    [EnumMember(Value = "min")]
    Min,

    /// <summary>
    /// Enum Ratio for "ratio"
    /// </summary>
    [EnumMember(Value = "ratio")]
    Ratio,

    /// <summary>
    /// Enum Max for "max"
    /// </summary>
    [EnumMember(Value = "max")]
    Max
}
