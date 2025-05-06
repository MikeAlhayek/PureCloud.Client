namespace PureCloud.Client.Models;

public sealed class StatEventFlowOutcomeTopicStatsNotification
{
    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public Dictionary<string, string> Group { get; set; }


    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    public IEnumerable<StatEventFlowOutcomeTopicIntervalMetrics> Data { get; set; }
}
