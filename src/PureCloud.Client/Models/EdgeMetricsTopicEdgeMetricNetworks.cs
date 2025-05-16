using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeMetricsTopicEdgeMetricNetworks
{
    /// <summary>
    /// Gets or Sets Ifname
    /// </summary>
    public string Ifname { get; set; }

    /// <summary>
    /// Gets or Sets SentBytesPerSec
    /// </summary>
    public long? SentBytesPerSec { get; set; }

    /// <summary>
    /// Gets or Sets ReceivedBytesPerSec
    /// </summary>
    public long? ReceivedBytesPerSec { get; set; }

    /// <summary>
    /// Gets or Sets BandwidthBitsPerSec
    /// </summary>
    public long? BandwidthBitsPerSec { get; set; }

    /// <summary>
    /// Gets or Sets UtilizationPct
    /// </summary>
    public double? UtilizationPct { get; set; }
}
