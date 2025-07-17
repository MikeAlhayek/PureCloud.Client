using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestMetricScoreRanked
{
    /// <summary>
    /// The gamification metric for the data
    /// </summary>
    /// <value>The gamification metric for the data</value>
    public AddressableEntityRef Metric { get; set; }

    /// <summary>
    /// The Contest Metric score
    /// </summary>
    /// <value>The Contest Metric score</value>
    public double? Score { get; set; }

    /// <summary>
    /// The Contest Metric totalPoints
    /// </summary>
    /// <value>The Contest Metric totalPoints</value>
    public double? TotalPoints { get; set; }

    /// <summary>
    /// The Contest Metric percentOfGoal
    /// </summary>
    /// <value>The Contest Metric percentOfGoal</value>
    public double? PercentOfGoal { get; set; }

    /// <summary>
    /// The Contest Score rank, a lower rank is better (1 is the best)
    /// </summary>
    /// <value>The Contest Score rank, a lower rank is better (1 is the best)</value>
    public int? Rank { get; set; }
}
