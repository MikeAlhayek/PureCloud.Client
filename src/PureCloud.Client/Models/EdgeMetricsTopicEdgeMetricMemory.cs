using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeMetricsTopicEdgeMetricMemory
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets AvailableBytes
    /// </summary>
    public long? AvailableBytes { get; set; }

    /// <summary>
    /// Gets or Sets TotalBytes
    /// </summary>
    public long? TotalBytes { get; set; }
}
