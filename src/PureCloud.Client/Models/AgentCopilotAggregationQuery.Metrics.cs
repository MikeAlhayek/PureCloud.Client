using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metrics
/// </summary>

public enum AgentCopilotAggregationQueryMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Ncannedresponsesuggestions for "nCannedResponseSuggestions"
    /// </summary>
    [EnumMember(Value = "nCannedResponseSuggestions")]
    Ncannedresponsesuggestions,

    /// <summary>
    /// Enum Ndistinctsuggestions for "nDistinctSuggestions"
    /// </summary>
    [EnumMember(Value = "nDistinctSuggestions")]
    Ndistinctsuggestions,

    /// <summary>
    /// Enum Nknowledgearticlesuggestions for "nKnowledgeArticleSuggestions"
    /// </summary>
    [EnumMember(Value = "nKnowledgeArticleSuggestions")]
    Nknowledgearticlesuggestions,

    /// <summary>
    /// Enum Nknowledgesearchsuggestions for "nKnowledgeSearchSuggestions"
    /// </summary>
    [EnumMember(Value = "nKnowledgeSearchSuggestions")]
    Nknowledgesearchsuggestions,

    /// <summary>
    /// Enum Nscriptsuggestions for "nScriptSuggestions"
    /// </summary>
    [EnumMember(Value = "nScriptSuggestions")]
    Nscriptsuggestions
}
