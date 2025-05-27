using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AggregationResult
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public AggregationResultTypeEnum? Type { get; set; }

    /// <summary>
    /// For termFrequency aggregations
    /// </summary>
    /// <value>For termFrequency aggregations</value>
    public string Dimension { get; set; }

    /// <summary>
    /// For numericRange aggregations
    /// </summary>
    /// <value>For numericRange aggregations</value>
    public string Metric { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    public long? Count { get; set; }

    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    public IEnumerable<AggregationResultEntry> Results { get; set; }
}
