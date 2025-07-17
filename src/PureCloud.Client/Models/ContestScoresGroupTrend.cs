using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestScoresGroupTrend
{
    /// <summary>
    /// Workday of the contest score. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Workday of the contest score. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateWorkday { get; set; }

    /// <summary>
    /// The Contest score
    /// </summary>
    /// <value>The Contest score</value>
    public ContestScore ContestScore { get; set; }

    /// <summary>
    /// The Contest metric scores
    /// </summary>
    /// <value>The Contest metric scores</value>
    public IEnumerable<ContestMetricScore> MetricScores { get; set; }
}
