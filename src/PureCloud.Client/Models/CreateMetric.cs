using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateMetric
{
    /// <summary>
    /// The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values
    /// </summary>
    /// <value>The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values</value>
    public CreateMetricTimeDisplayUnitEnum? TimeDisplayUnit { get; set; }

    /// <summary>
    /// The id of associated metric definition
    /// </summary>
    /// <value>The id of associated metric definition</value>
    public string MetricDefinitionId { get; set; }

    /// <summary>
    /// The id of associated external metric definition
    /// </summary>
    /// <value>The id of associated external metric definition</value>
    public string ExternalMetricDefinitionId { get; set; }

    /// <summary>
    /// Associated objective for this metric
    /// </summary>
    /// <value>Associated objective for this metric</value>
    public CreateObjective Objective { get; set; }

    /// <summary>
    /// Performance profile id of this metric
    /// </summary>
    /// <value>Performance profile id of this metric</value>
    public string PerformanceProfileId { get; set; }

    /// <summary>
    /// The name of this metric
    /// </summary>
    /// <value>The name of this metric</value>
    public string Name { get; set; }

    /// <summary>
    /// The precision of the metric, must be between 0 and 5
    /// </summary>
    public int? Precision { get; set; }
}
