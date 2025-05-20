using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification
{
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public WfmAgentScheduleUpdateTopicUserReference User { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets Updates
    /// </summary>
    public IEnumerable<WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate> Updates { get; set; }
}
