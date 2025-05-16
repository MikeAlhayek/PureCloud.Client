using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrunkMetricsTopicTrunkMetrics
{
    /// <summary>
    /// Gets or Sets Calls
    /// </summary>
    public TrunkMetricsTopicTrunkMetricsCalls Calls { get; set; }

    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public DateTime? EventTime { get; set; }

    /// <summary>
    /// Gets or Sets Qos
    /// </summary>
    public TrunkMetricsTopicTrunkMetricsQoS Qos { get; set; }

    /// <summary>
    /// Gets or Sets Trunk
    /// </summary>
    public TrunkMetricsTopicUriReference Trunk { get; set; }
}
