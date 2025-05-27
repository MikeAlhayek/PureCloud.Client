using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DevelopmentActivityAggregateQueryResponseMetric
{
    /// <summary>
    /// The metric this applies to
    /// </summary>
    /// <value>The metric this applies to</value>
    public DevelopmentActivityAggregateQueryResponseMetricMetricEnum? Metric { get; set; }

    /// <summary>
    /// The aggregated values for this metric
    /// </summary>
    /// <value>The aggregated values for this metric</value>
    public DevelopmentActivityAggregateQueryResponseStatistics Stats { get; set; }
}
