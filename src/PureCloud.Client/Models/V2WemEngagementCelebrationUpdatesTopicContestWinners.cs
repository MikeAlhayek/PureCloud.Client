using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2WemEngagementCelebrationUpdatesTopicContestWinners
{
    /// <summary>
    /// Gets or Sets Tier
    /// </summary>
    public long? Tier { get; set; }

    /// <summary>
    /// Gets or Sets WinnersCount
    /// </summary>
    public long? WinnersCount { get; set; }

    /// <summary>
    /// Gets or Sets ContestScore
    /// </summary>
    public V2WemEngagementCelebrationUpdatesTopicContestWinnersScore ContestScore { get; set; }

    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    public IEnumerable<V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers> Users { get; set; }
}
