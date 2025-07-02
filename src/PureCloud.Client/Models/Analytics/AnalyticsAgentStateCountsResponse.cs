using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsAgentStateCountsResponse
{
    /// <summary>
    /// List of count by segment types
    /// </summary>
    /// <value>List of count by segment types</value>
    public IEnumerable<AgentStateSegmentTypeCount> SegmentCounts { get; set; }
}
