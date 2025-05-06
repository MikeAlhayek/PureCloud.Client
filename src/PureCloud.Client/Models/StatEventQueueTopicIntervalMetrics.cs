using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class StatEventQueueTopicIntervalMetrics
{
    /// <summary>
    /// Gets or Sets Interval
    /// </summary>
    public string Interval { get; set; }


    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    public IEnumerable<StatEventQueueTopicMetricStats> Metrics { get; set; }
}
