using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class StatisticalResponse
{
    /// <summary>
    /// Gets or Sets Interval
    /// </summary>
    public string Interval { get; set; }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    public IEnumerable<AggregateMetricData> Metrics { get; set; }

    /// <summary>
    /// Gets or Sets Views
    /// </summary>
    public IEnumerable<AggregateViewData> Views { get; set; }
}
