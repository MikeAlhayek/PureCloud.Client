using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestScoreRanked
{
    /// <summary>
    /// The Contest score
    /// </summary>
    /// <value>The Contest score</value>
    public double? Score { get; set; }

    /// <summary>
    /// The Contest totalPoints
    /// </summary>
    /// <value>The Contest totalPoints</value>
    public double? TotalPoints { get; set; }

    /// <summary>
    /// The Contest percentOfGoal
    /// </summary>
    /// <value>The Contest percentOfGoal</value>
    public double? PercentOfGoal { get; set; }

    /// <summary>
    /// The Contest Score rank
    /// </summary>
    /// <value>The Contest Score rank</value>
    public int? Rank { get; set; }

    /// <summary>
    /// The Contest Score tier
    /// </summary>
    /// <value>The Contest Score tier</value>
    public int? Tier { get; set; }
}
