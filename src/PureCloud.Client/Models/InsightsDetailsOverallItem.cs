using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsDetailsOverallItem
{
    /// <summary>
    /// Insights data in the comparative period
    /// </summary>
    /// <value>Insights data in the comparative period</value>
    public InsightsDetailsOverallPeriodPoints ComparativePeriod { get; set; }

    /// <summary>
    /// Insights data in the primary period
    /// </summary>
    /// <value>Insights data in the primary period</value>
    public InsightsDetailsOverallPeriodPoints PrimaryPeriod { get; set; }

    /// <summary>
    /// Percent of goal change
    /// </summary>
    /// <value>Percent of goal change</value>
    public double? PercentOfGoalChange { get; set; }
}
