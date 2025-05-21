using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastCopyCompleteTopicBuForecastModification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmBuShortTermForecastCopyCompleteTopicBuForecastModificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    public WfmBuShortTermForecastCopyCompleteTopicBuForecastModificationMetricEnum? Metric { get; set; }

    /// <summary>
    /// Gets or Sets LegacyMetric
    /// </summary>
    public WfmBuShortTermForecastCopyCompleteTopicBuForecastModificationLegacyMetricEnum? LegacyMetric { get; set; }

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
    public IEnumerable<WfmBuShortTermForecastCopyCompleteTopicModificationIntervalOffsetValue> Values { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryValues
    /// </summary>
    public IEnumerable<WfmBuShortTermForecastCopyCompleteTopicModificationIntervalOffsetValue> SecondaryValues { get; set; }

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
