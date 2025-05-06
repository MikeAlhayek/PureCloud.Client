using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// StatEventFlowOutcomeTopicIntervalMetrics
/// </summary>

public sealed class StatEventFlowOutcomeTopicIntervalMetrics
{
    /// <summary>
    /// Gets or Sets Interval
    /// </summary>
    public string Interval { get; set; }


    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    public IEnumerable<StatEventFlowOutcomeTopicMetricStats> Metrics { get; set; }

}
