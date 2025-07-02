using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueObservationQuery
{
    /// <summary>
    /// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
    /// </summary>
    /// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
    public QueueObservationQueryFilter Filter { get; set; }

    /// <summary>
    /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
    /// </summary>
    /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
    public IEnumerable<QueueObservationQueryMetricsEnum> Metrics { get; set; }

    /// <summary>
    /// Metrics for which to include additional detailed observations
    /// </summary>
    /// <value>Metrics for which to include additional detailed observations</value>
    public IEnumerable<QueueObservationQueryDetailMetricsEnum> DetailMetrics { get; set; }
}
