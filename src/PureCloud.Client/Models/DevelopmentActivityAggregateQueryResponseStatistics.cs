using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class DevelopmentActivityAggregateQueryResponseStatistics
{
    /// <summary>
    /// The count for this metric
    /// </summary>
    /// <value>The count for this metric</value>
    public int? Count { get; set; }

    /// <summary>
    /// The minimum value in this metric
    /// </summary>
    /// <value>The minimum value in this metric</value>
    public double? Min { get; set; }

    /// <summary>
    /// The maximum value in this metric
    /// </summary>
    /// <value>The maximum value in this metric</value>
    public double? Max { get; set; }

    /// <summary>
    /// The total of the values for this metric
    /// </summary>
    /// <value>The total of the values for this metric</value>
    public double? Sum { get; set; }
}
