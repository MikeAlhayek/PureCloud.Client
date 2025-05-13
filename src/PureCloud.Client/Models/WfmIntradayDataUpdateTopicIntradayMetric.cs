using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntradayDataUpdateTopicIntradayMetric
{
    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    public WfmIntradayDataUpdateTopicIntradayMetricCategoryEnum? Category { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public string Version { get; set; }
}
