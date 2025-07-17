using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkdayMetric
{
    /// <summary>
    /// Gamification metric
    /// </summary>
    /// <value>Gamification metric</value>
    public Metric Metric { get; set; }

    /// <summary>
    /// Current objective for this metric
    /// </summary>
    /// <value>Current objective for this metric</value>
    public Objective Objective { get; set; }

    /// <summary>
    /// Gamification points earned for this metric
    /// </summary>
    /// <value>Gamification points earned for this metric</value>
    public int? Points { get; set; }

    /// <summary>
    /// The maximum Gamification points a user may earn for this metric
    /// </summary>
    /// <value>The maximum Gamification points a user may earn for this metric</value>
    public int? MaxPoints { get; set; }

    /// <summary>
    /// Value of this metric
    /// </summary>
    /// <value>Value of this metric</value>
    public double? Value { get; set; }

    /// <summary>
    /// List of schedule activity events for punctuality metrics
    /// </summary>
    /// <value>List of schedule activity events for punctuality metrics</value>
    public IEnumerable<PunctualityEvent> PunctualityEvents { get; set; }

    /// <summary>
    /// List of evaluations for quality evaluation score metrics
    /// </summary>
    /// <value>List of evaluations for quality evaluation score metrics</value>
    public IEnumerable<QualityEvaluationScoreItem> EvaluationDetails { get; set; }
}
