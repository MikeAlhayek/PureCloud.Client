using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeMetricsTopicEdgeMetricDisk
{
    /// <summary>
    /// Gets or Sets PartitionName
    /// </summary>
    public string PartitionName { get; set; }

    /// <summary>
    /// Gets or Sets AvailableBytes
    /// </summary>
    public long? AvailableBytes { get; set; }

    /// <summary>
    /// Gets or Sets TotalBytes
    /// </summary>
    public long? TotalBytes { get; set; }
}
