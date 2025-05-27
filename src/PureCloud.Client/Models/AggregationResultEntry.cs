using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AggregationResultEntry
{
    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    public long? Count { get; set; }

    /// <summary>
    /// For termFrequency aggregations
    /// </summary>
    /// <value>For termFrequency aggregations</value>
    public string Value { get; set; }

    /// <summary>
    /// For numericRange aggregations
    /// </summary>
    /// <value>For numericRange aggregations</value>
    public double? Gte { get; set; }

    /// <summary>
    /// For numericRange aggregations
    /// </summary>
    /// <value>For numericRange aggregations</value>
    public double? Lt { get; set; }
}
