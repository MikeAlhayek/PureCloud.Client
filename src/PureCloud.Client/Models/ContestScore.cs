using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestScore
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
}
