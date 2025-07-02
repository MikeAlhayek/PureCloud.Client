using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowObservationQuery
{
    /// <summary>
    /// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
    /// </summary>
    /// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
    public FlowObservationQueryFilter Filter { get; set; }

    /// <summary>
    /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
    /// </summary>
    /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
    public IEnumerable<FlowObservationQueryMetricsEnum> Metrics { get; set; }

    /// <summary>
    /// Metrics for which to include additional detailed observations
    /// </summary>
    /// <value>Metrics for which to include additional detailed observations</value>
    public IEnumerable<FlowObservationQueryDetailMetricsEnum> DetailMetrics { get; set; }
}
