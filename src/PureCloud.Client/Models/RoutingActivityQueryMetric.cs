using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RoutingActivityQueryMetric
{
    /// <summary>
    /// The requested metric
    /// </summary>
    /// <value>The requested metric</value>
    public RoutingActivityQueryMetricMetricEnum? Metric { get; set; }

    /// <summary>
    /// Flag for including observation details for this metric in the response
    /// </summary>
    /// <value>Flag for including observation details for this metric in the response</value>
    public bool? Details { get; set; }
}
