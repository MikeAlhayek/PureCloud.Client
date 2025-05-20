using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Rank
    /// </summary>
    public long? Rank { get; set; }
}
