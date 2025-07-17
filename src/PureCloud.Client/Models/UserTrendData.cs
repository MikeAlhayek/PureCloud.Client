using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserTrendData
{
    /// <summary>
    /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStartWorkday { get; set; }

    /// <summary>
    /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEndWorkday { get; set; }

    /// <summary>
    /// Percent of goal
    /// </summary>
    /// <value>Percent of goal</value>
    public double? PercentOfGoal { get; set; }

    /// <summary>
    /// Average metric value
    /// </summary>
    /// <value>Average metric value</value>
    public double? AverageValue { get; set; }

    /// <summary>
    /// Rank, ordered by total points
    /// </summary>
    /// <value>Rank, ordered by total points</value>
    public int? RankTotalPoints { get; set; }

    /// <summary>
    /// Rank, ordered by percentage of points
    /// </summary>
    /// <value>Rank, ordered by percentage of points</value>
    public int? RankPercentagePoints { get; set; }
}
