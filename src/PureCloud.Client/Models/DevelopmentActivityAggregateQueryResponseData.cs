using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DevelopmentActivityAggregateQueryResponseData
{
    /// <summary>
    /// Specifies the range of due dates to be used for filtering. A maximum of 1 year can be specified in the range. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Specifies the range of due dates to be used for filtering. A maximum of 1 year can be specified in the range. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    public string Interval { get; set; }

    /// <summary>
    /// The list of aggregated metrics
    /// </summary>
    /// <value>The list of aggregated metrics</value>
    public IEnumerable<DevelopmentActivityAggregateQueryResponseMetric> Metrics { get; set; }
}
