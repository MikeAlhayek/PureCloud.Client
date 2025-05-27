using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SocialMediaAggregateMetricData
{
    /// <summary>
    /// Gets or Sets Metric
    public string Metric { get; set; }

    /// <summary>
    /// Gets or Sets Qualifier
    /// </summary>
    public string Qualifier { get; set; }

    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    public SocialMediaStatisticalSummary Stats { get; set; }
}
