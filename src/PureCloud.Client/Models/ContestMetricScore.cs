using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestMetricScore
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
}
