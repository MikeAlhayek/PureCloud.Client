namespace PureCloud.Client.Models;

public sealed class StatEventFlowTopicIntervalMetrics
{
    /// <summary>
    /// Gets or Sets Interval
    /// </summary>
    public string Interval { get; set; }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    public IEnumerable<StatEventFlowTopicMetricStats> Metrics { get; set; }
}
