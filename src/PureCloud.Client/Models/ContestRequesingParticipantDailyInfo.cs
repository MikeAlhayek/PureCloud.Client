using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestRequesingParticipantDailyInfo
{
    /// <summary>
    /// Workday of the contest info. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Workday of the contest info. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateWorkday { get; set; }

    /// <summary>
    /// The Contest score
    /// </summary>
    /// <value>The Contest score</value>
    public ContestScoreRanked ContestScore { get; set; }
}
