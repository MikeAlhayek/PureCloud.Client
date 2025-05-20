using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2WemEngagementCelebrationUpdatesTopicContestPrizes
{
    /// <summary>
    /// Gets or Sets Tier
    /// </summary>
    public long? Tier { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ImageId
    /// </summary>
    public string ImageId { get; set; }
}
