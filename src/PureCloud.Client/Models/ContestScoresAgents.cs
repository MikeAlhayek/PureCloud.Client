using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestScoresAgents
{
    /// <summary>
    /// The Contest score
    /// </summary>
    /// <value>The Contest score</value>
    public ContestScoreRanked ContestScore { get; set; }

    /// <summary>
    /// The Contest metric scores
    /// </summary>
    /// <value>The Contest metric scores</value>
    public IEnumerable<ContestMetricScoreRanked> MetricScores { get; set; }

    /// <summary>
    /// Indicates whether an agent is disqualified or not
    /// </summary>
    /// <value>Indicates whether an agent is disqualified or not</value>
    public bool? Disqualified { get; set; }

    /// <summary>
    /// The Contest Scores Leaderboard user
    /// </summary>
    /// <value>The Contest Scores Leaderboard user</value>
    public UserReference User { get; set; }
}
