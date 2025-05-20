using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuScheduleTopicSchedulerMessageSeverityCount
{
    /// <summary>
    /// Gets or Sets Severity
    /// </summary>
    public WfmBuScheduleTopicSchedulerMessageSeverityCountSeverityEnum? Severity { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    public long? Count { get; set; }
}
