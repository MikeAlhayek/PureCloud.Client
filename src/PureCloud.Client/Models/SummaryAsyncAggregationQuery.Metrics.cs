using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metrics
/// </summary>

public enum SummaryAsyncAggregationQueryMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nconversationsummaries for "nConversationSummaries"
    /// </summary>
    [EnumMember(Value = "nConversationSummaries")]
    Nconversationsummaries,

    /// <summary>
    /// Enum Nconversationsummaryengagements for "nConversationSummaryEngagements"
    /// </summary>
    [EnumMember(Value = "nConversationSummaryEngagements")]
    Nconversationsummaryengagements,

    /// <summary>
    /// Enum Tconversationsummary for "tConversationSummary"
    /// </summary>
    [EnumMember(Value = "tConversationSummary")]
    Tconversationsummary
}
