using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeMetricsTopicEdgeMetrics
{
    /// <summary>
    /// Gets or Sets Edge
    /// </summary>
    public EdgeMetricsTopicUriReference Edge { get; set; }

    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public DateTime? EventTime { get; set; }

    /// <summary>
    /// Gets or Sets UpTimeMsec
    /// </summary>
    public long? UpTimeMsec { get; set; }

    /// <summary>
    /// Gets or Sets Processors
    /// </summary>
    public IEnumerable<EdgeMetricsTopicEdgeMetricProcessor> Processors { get; set; }

    /// <summary>
    /// Gets or Sets Memory
    /// </summary>
    public IEnumerable<EdgeMetricsTopicEdgeMetricMemory> Memory { get; set; }

    /// <summary>
    /// Gets or Sets Disks
    /// </summary>
    public IEnumerable<EdgeMetricsTopicEdgeMetricDisk> Disks { get; set; }

    /// <summary>
    /// Gets or Sets Subsystems
    /// </summary>
    public IEnumerable<EdgeMetricsTopicEdgeMetricSubsystem> Subsystems { get; set; }

    /// <summary>
    /// Gets or Sets Networks
    /// </summary>
    public IEnumerable<EdgeMetricsTopicEdgeMetricNetworks> Networks { get; set; }
}
