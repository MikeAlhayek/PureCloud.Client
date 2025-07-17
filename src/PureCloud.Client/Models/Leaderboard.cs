using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class Leaderboard
{
    /// <summary>
    /// The targeted division for this leaderboard
    /// </summary>
    /// <value>The targeted division for this leaderboard</value>
    public Division Division { get; set; }

    /// <summary>
    /// The metric id if the leaderboard is about a specific metric
    /// </summary>
    /// <value>The metric id if the leaderboard is about a specific metric</value>
    public AddressableEntityRef Metric { get; set; }

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
    /// The list of leaders generated.
    /// </summary>
    /// <value>The list of leaders generated.</value>
    public IEnumerable<LeaderboardItem> Leaders { get; set; }

    /// <summary>
    /// The requesting user&#39;s rank
    /// </summary>
    /// <value>The requesting user&#39;s rank</value>
    public LeaderboardItem UserRank { get; set; }

    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    public AddressableEntityRef PerformanceProfile { get; set; }
}
