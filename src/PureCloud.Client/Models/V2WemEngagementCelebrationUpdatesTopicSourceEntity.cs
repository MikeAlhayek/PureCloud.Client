using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2WemEngagementCelebrationUpdatesTopicSourceEntity
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2WemEngagementCelebrationUpdatesTopicSourceEntityTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets ContestCompleteData
    /// </summary>
    public V2WemEngagementCelebrationUpdatesTopicContestCompleteData ContestCompleteData { get; set; }
}
