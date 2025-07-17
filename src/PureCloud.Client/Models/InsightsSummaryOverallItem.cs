using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsSummaryOverallItem
{
    /// <summary>
    /// Insights data in the comparative period
    /// </summary>
    /// <value>Insights data in the comparative period</value>
    public InsightsSummaryOverallPeriodPoints ComparativePeriod { get; set; }

    /// <summary>
    /// Insights data in the primary period
    /// </summary>
    /// <value>Insights data in the primary period</value>
    public InsightsSummaryOverallPeriodPoints PrimaryPeriod { get; set; }

    /// <summary>
    /// Percent of goal change
    /// </summary>
    /// <value>Percent of goal change</value>
    public double? PercentOfGoalChange { get; set; }
}
