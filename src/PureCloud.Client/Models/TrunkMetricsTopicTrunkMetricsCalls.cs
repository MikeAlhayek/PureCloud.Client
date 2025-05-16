using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrunkMetricsTopicTrunkMetricsCalls
{
    /// <summary>
    /// Gets or Sets InboundCallCount
    /// </summary>
    public long? InboundCallCount { get; set; }

    /// <summary>
    /// Gets or Sets OutboundCallCount
    /// </summary>
    public long? OutboundCallCount { get; set; }
}
