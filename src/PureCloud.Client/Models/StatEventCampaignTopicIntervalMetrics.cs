using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class StatEventCampaignTopicIntervalMetrics
{
    /// <summary>
    /// Gets or Sets Interval
    /// </summary>
    public string Interval { get; set; }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    public IEnumerable<StatEventCampaignTopicMetricStats> Metrics { get; set; }
}
