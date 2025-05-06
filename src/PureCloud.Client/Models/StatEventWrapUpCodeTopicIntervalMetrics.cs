using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class StatEventWrapUpCodeTopicIntervalMetrics
{
    /// <summary>
    /// Gets or Sets Interval
    /// </summary>
    public string Interval { get; set; }


    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    public IEnumerable<StatEventWrapUpCodeTopicMetricStats> Metrics { get; set; }
}
