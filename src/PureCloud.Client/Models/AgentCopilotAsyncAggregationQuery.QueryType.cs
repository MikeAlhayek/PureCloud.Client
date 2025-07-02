using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)
/// </summary>
/// <value>Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)</value>

public enum AgentCopilotAsyncAggregationQueryQueryTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Groupby for "groupBy"
    /// </summary>
    [EnumMember(Value = "groupBy")]
    Groupby,

    /// <summary>
    /// Enum Topn for "topN"
    /// </summary>
    [EnumMember(Value = "topN")]
    Topn
}
