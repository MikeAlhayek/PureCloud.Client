using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AggregationRange
{
    /// <summary>
    /// Greater than or equal to
    /// </summary>
    /// <value>Greater than or equal to</value>
    public double? Gte { get; set; }

    /// <summary>
    /// Less than
    /// </summary>
    /// <value>Less than</value>
    public double? Lt { get; set; }
}
