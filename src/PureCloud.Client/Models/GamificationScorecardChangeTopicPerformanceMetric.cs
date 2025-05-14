using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GamificationScorecardChangeTopicPerformanceMetric
{
    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    public GamificationScorecardChangeTopicMetric Metric { get; set; }

    /// <summary>
    /// Gets or Sets Points
    /// </summary>
    public long? Points { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or Sets PunctualityEvents
    /// </summary>
    public IEnumerable<GamificationScorecardChangeTopicPunctualityEvent> PunctualityEvents { get; set; }

    /// <summary>
    /// Gets or Sets EvaluationDetails
    /// </summary>
    public IEnumerable<GamificationScorecardChangeTopicEvaluationDetail> EvaluationDetails { get; set; }
}
