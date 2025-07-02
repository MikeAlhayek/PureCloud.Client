using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Analytics;

namespace PureCloud.Client.Models;

public sealed class AnalyticsConversationQueryResponse
{
    /// <summary>
    /// Gets or Sets Conversations
    /// </summary>
    public IEnumerable<AnalyticsConversationWithoutAttributes> Conversations { get; set; }

    /// <summary>
    /// Gets or Sets Aggregations
    /// </summary>
    public IEnumerable<AggregationResult> Aggregations { get; set; }

    /// <summary>
    /// Gets or Sets TotalHits
    /// </summary>
    public int? TotalHits { get; set; }
}
