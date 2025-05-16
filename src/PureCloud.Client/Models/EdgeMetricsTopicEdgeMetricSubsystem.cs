using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeMetricsTopicEdgeMetricSubsystem
{
    /// <summary>
    /// Gets or Sets ProcessName
    /// </summary>
    public string ProcessName { get; set; }

    /// <summary>
    /// Gets or Sets DelayMs
    /// </summary>
    public long? DelayMs { get; set; }

    /// <summary>
    /// Gets or Sets MediaSubsystem
    /// </summary>
    public EdgeMetricsTopicEdgeMetricSubsystemMedia MediaSubsystem { get; set; }
}
