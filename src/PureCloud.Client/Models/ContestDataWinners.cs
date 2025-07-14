using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestDataWinners
{
    /// <summary>
    /// Tier of the winners
    /// </summary>
    /// <value>Tier of the winners</value>
    public int? Tier { get; set; }

    /// <summary>
    /// Number of winners in this tier
    /// </summary>
    /// <value>Number of winners in this tier</value>
    public int? WinnersCount { get; set; }

    /// <summary>
    /// Number of winners in this tier
    /// </summary>
    /// <value>Number of winners in this tier</value>
    public ContestCompleteDataScore ContestScore { get; set; }

    /// <summary>
    /// List of users in this tier
    /// </summary>
    /// <value>List of users in this tier</value>
    public IEnumerable<ContestDataWinnersUsers> Users { get; set; }
}
