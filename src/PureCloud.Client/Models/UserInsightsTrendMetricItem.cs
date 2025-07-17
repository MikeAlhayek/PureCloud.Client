using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserInsightsTrendMetricItem
{
    /// <summary>
    /// The gamification metric for the trend
    /// </summary>
    /// <value>The gamification metric for the trend</value>
    public AddressableEntityRef Metric { get; set; }

    /// <summary>
    /// Trends for the metric
    /// </summary>
    /// <value>Trends for the metric</value>
    public UserInsightsTrends Trends { get; set; }
}
