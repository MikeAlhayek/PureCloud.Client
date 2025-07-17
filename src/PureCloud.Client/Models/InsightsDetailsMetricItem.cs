using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsDetailsMetricItem
{
    /// <summary>
    /// The gamification metric for the data
    /// </summary>
    /// <value>The gamification metric for the data</value>
    public AddressableEntityRef Metric { get; set; }

    /// <summary>
    /// Insights data in the comparative period
    /// </summary>
    /// <value>Insights data in the comparative period</value>
    public InsightsDetailsMetricPeriodPoints ComparativePeriod { get; set; }

    /// <summary>
    /// Insights data in the primary period
    /// </summary>
    /// <value>Insights data in the primary period</value>
    public InsightsDetailsMetricPeriodPoints PrimaryPeriod { get; set; }

    /// <summary>
    /// Percent of goal change
    /// </summary>
    /// <value>Percent of goal change</value>
    public double? PercentOfGoalChange { get; set; }

    /// <summary>
    /// Value change
    /// </summary>
    /// <value>Value change</value>
    public double? ValueChange { get; set; }
}
