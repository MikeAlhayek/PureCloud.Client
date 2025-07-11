using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingAppointmentAggregateRequest
{
    /// <summary>
    /// Interval to aggregate across. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Interval to aggregate across. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    public string Interval { get; set; }

    /// <summary>
    /// A list of metrics to aggregate.  If omitted, all metrics are returned.
    /// </summary>
    /// <value>A list of metrics to aggregate.  If omitted, all metrics are returned.</value>
    public IEnumerable<CoachingAppointmentAggregateRequestMetricsEnum> Metrics { get; set; }

    /// <summary>
    /// An optional list of items by which to group the result data.
    /// </summary>
    /// <value>An optional list of items by which to group the result data.</value>
    public IEnumerable<CoachingAppointmentAggregateRequestGroupByEnum> GroupBy { get; set; }

    /// <summary>
    /// The filter applied to the data
    /// </summary>
    /// <value>The filter applied to the data</value>
    public QueryRequestFilter Filter { get; set; }
}
