using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AggregateViewData
{
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    public StatisticalSummary Stats { get; set; }
}
