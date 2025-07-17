using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsDetailsOverallPeriodPoints
{
    /// <summary>
    /// Points scored
    /// </summary>
    /// <value>Points scored</value>
    public int? Points { get; set; }

    /// <summary>
    /// Max possible points
    /// </summary>
    /// <value>Max possible points</value>
    public int? MaxPoints { get; set; }

    /// <summary>
    /// Number of data points
    /// </summary>
    /// <value>Number of data points</value>
    public int? DataPointCount { get; set; }

    /// <summary>
    /// Percentage of the goal
    /// </summary>
    /// <value>Percentage of the goal</value>
    public double? PercentOfGoal { get; set; }

    /// <summary>
    /// The agent&#39;s rank in leader board for points on this metric
    /// </summary>
    /// <value>The agent&#39;s rank in leader board for points on this metric</value>
    public int? RankTotalPoints { get; set; }

    /// <summary>
    /// The agent&#39;s rank in leader board for percentage on this metric
    /// </summary>
    /// <value>The agent&#39;s rank in leader board for percentage on this metric</value>
    public int? RankPercentagePoints { get; set; }
}
