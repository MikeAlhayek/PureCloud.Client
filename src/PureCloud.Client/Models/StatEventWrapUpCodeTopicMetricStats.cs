using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class StatEventWrapUpCodeTopicMetricStats
{
    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    public string Metric { get; set; }


    /// <summary>
    /// Gets or Sets Qualifier
    /// </summary>
    public string Qualifier { get; set; }


    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    public Dictionary<string, double?> Stats { get; set; }
}
