using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2WemEngagementCelebrationUpdatesTopicContestCompleteData
{
    /// <summary>
    /// Gets or Sets Anonymization
    /// </summary>
    public V2WemEngagementCelebrationUpdatesTopicContestCompleteDataAnonymizationEnum? Anonymization { get; set; }

    /// <summary>
    /// Gets or Sets DateEnd
    /// </summary>
    public string DateEnd { get; set; }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    public IEnumerable<V2WemEngagementCelebrationUpdatesTopicContestMetrics> Metrics { get; set; }

    /// <summary>
    /// Gets or Sets Prizes
    /// </summary>
    public IEnumerable<V2WemEngagementCelebrationUpdatesTopicContestPrizes> Prizes { get; set; }

    /// <summary>
    /// Gets or Sets Winners
    /// </summary>
    public IEnumerable<V2WemEngagementCelebrationUpdatesTopicContestWinners> Winners { get; set; }
}
