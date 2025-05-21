using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets LengthMinutes
    /// </summary>
    public long? LengthMinutes { get; set; }
}
