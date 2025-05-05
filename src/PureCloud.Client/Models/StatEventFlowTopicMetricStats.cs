namespace PureCloud.Client.Models;

public sealed class StatEventFlowTopicMetricStats
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
