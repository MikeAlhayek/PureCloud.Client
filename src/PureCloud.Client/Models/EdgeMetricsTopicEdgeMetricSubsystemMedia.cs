using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeMetricsTopicEdgeMetricSubsystemMedia
{
    /// <summary>
    /// Gets or Sets ProcessName
    /// </summary>
    public string ProcessName { get; set; }

    /// <summary>
    /// Gets or Sets DelayMs
    /// </summary>
    public long? DelayMs { get; set; }
}
