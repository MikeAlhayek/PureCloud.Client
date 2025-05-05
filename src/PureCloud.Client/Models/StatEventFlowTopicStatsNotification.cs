namespace PureCloud.Client.Models;

public sealed class StatEventFlowTopicStatsNotification
{
    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public Dictionary<string, string> Group { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    public IEnumerable<StatEventFlowTopicIntervalMetrics> Data { get; set; }
}
