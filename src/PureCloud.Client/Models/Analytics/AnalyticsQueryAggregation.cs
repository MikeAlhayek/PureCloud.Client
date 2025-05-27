using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsQueryAggregation
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    public AnalyticsQueryAggregationTypeEnum? Type { get; set; }

    /// <summary>
    /// For use with termFrequency aggregations
    /// </summary>
    /// <value>For use with termFrequency aggregations</value>
    public string Dimension { get; set; }

    /// <summary>
    /// For use with numericRange aggregations
    /// </summary>
    /// <value>For use with numericRange aggregations</value>
    public string Metric { get; set; }

    /// <summary>
    /// For use with termFrequency aggregations
    /// </summary>
    /// <value>For use with termFrequency aggregations</value>
    public int? Size { get; set; }

    /// <summary>
    /// For use with numericRange aggregations
    /// </summary>
    /// <value>For use with numericRange aggregations</value>
    public IEnumerable<AggregationRange> Ranges { get; set; }
}
