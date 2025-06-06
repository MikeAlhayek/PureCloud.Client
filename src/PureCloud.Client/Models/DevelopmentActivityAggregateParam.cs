using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DevelopmentActivityAggregateParam
{
    /// <summary>
    /// Specifies the range of due dates to be used for filtering. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Specifies the range of due dates to be used for filtering. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    public string Interval { get; set; }

    /// <summary>
    /// The list of metrics to be returned. If omitted, all metrics are returned.
    /// </summary>
    /// <value>The list of metrics to be returned. If omitted, all metrics are returned.</value>
    public IEnumerable<DevelopmentActivityAggregateParamMetricsEnum> Metrics { get; set; }

    /// <summary>
    /// Specifies if the aggregated data is combined into a single set of metrics (groupBy is empty or not specified), or contains an element per attendeeId (groupBy is \&quot;attendeeId\&quot;)
    /// </summary>
    /// <value>Specifies if the aggregated data is combined into a single set of metrics (groupBy is empty or not specified), or contains an element per attendeeId (groupBy is \&quot;attendeeId\&quot;)</value>
    public IEnumerable<DevelopmentActivityAggregateParamGroupByEnum> GroupBy { get; set; }

    /// <summary>
    /// The filter applied to the data. This is ANDed with the interval parameter.
    /// </summary>
    /// <value>The filter applied to the data. This is ANDed with the interval parameter.</value>
    public DevelopmentActivityAggregateQueryRequestFilter Filter { get; set; }
}
