using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastUpdateCompleteTopicBuForecastModification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmBuShortTermForecastUpdateCompleteTopicBuForecastModificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    public WfmBuShortTermForecastUpdateCompleteTopicBuForecastModificationMetricEnum? Metric { get; set; }

    /// <summary>
    /// Gets or Sets LegacyMetric
    /// </summary>
    public WfmBuShortTermForecastUpdateCompleteTopicBuForecastModificationLegacyMetricEnum? LegacyMetric { get; set; }

    /// <summary>
    /// Gets or Sets StartIntervalIndex
    /// </summary>
    public long? StartIntervalIndex { get; set; }

    /// <summary>
    /// Gets or Sets EndIntervalIndex
    /// </summary>
    public long? EndIntervalIndex { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    public IEnumerable<WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue> Values { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryValues
    /// </summary>
    public IEnumerable<WfmBuShortTermForecastUpdateCompleteTopicModificationIntervalOffsetValue> SecondaryValues { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Granularity
    /// </summary>
    public string Granularity { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryGranularity
    /// </summary>
    public string SecondaryGranularity { get; set; }

    /// <summary>
    /// Gets or Sets DisplayGranularity
    /// </summary>
    public string DisplayGranularity { get; set; }

    /// <summary>
    /// Gets or Sets PlanningGroupIds
    /// </summary>
    public IEnumerable<string> PlanningGroupIds { get; set; }
}
