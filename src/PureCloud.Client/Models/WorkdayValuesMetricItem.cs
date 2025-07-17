using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkdayValuesMetricItem
{
    /// <summary>
    /// The unit type of the metric value
    /// </summary>
    /// <value>The unit type of the metric value</value>
    public WorkdayValuesMetricItemUnitTypeEnum? UnitType { get; set; }

    /// <summary>
    /// Gamification metric for the average and the trend
    /// </summary>
    /// <value>Gamification metric for the average and the trend</value>
    public AddressableEntityRef Metric { get; set; }

    /// <summary>
    /// Gamification metric definition for the average and the trend
    /// </summary>
    /// <value>Gamification metric definition for the average and the trend</value>
    public DomainEntityRef MetricDefinition { get; set; }

    /// <summary>
    /// The average value of the metric
    /// </summary>
    /// <value>The average value of the metric</value>
    public double? Average { get; set; }

    /// <summary>
    /// The metric value trend
    /// </summary>
    /// <value>The metric value trend</value>
    public IEnumerable<WorkdayValuesTrendItem> Trend { get; set; }
}
