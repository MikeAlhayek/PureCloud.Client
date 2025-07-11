using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueryResponseData
{
    /// <summary>
    /// Interval with start and end represented as ISO-8601 string. i.e: yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;/yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;
    /// </summary>
    /// <value>Interval with start and end represented as ISO-8601 string. i.e: yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;/yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;</value>
    public string Interval { get; set; }

    /// <summary>
    /// A list of aggregated metrics
    /// </summary>
    /// <value>A list of aggregated metrics</value>
    public IEnumerable<QueryResponseMetric> Metrics { get; set; }
}
