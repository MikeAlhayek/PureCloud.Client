using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeMetricsTopicEdgeMetricProcessor
{
    /// <summary>
    /// Gets or Sets CpuId
    /// </summary>
    public string CpuId { get; set; }

    /// <summary>
    /// Gets or Sets IdleTimePct
    /// </summary>
    public long? IdleTimePct { get; set; }

    /// <summary>
    /// Gets or Sets ActiveTimePct
    /// </summary>
    public long? ActiveTimePct { get; set; }

    /// <summary>
    /// Gets or Sets PrivilegedTimePct
    /// </summary>
    public long? PrivilegedTimePct { get; set; }

    /// <summary>
    /// Gets or Sets UserTimePct
    /// </summary>
    public long? UserTimePct { get; set; }
}
