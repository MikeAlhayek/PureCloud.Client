using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestScoresAgentTrendList
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ContestScoresAgentTrend> Entities { get; set; }

    /// <summary>
    /// The Contest Scores Leaderboard user
    /// </summary>
    /// <value>The Contest Scores Leaderboard user</value>
    public UserReference User { get; set; }
}
