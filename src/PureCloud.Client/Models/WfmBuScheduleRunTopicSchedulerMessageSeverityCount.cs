using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuScheduleRunTopicSchedulerMessageSeverityCount
{
    /// <summary>
    /// Gets or Sets Severity
    /// </summary>
    public WfmBuScheduleRunTopicSchedulerMessageSeverityCountSeverityEnum? Severity { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    public long? Count { get; set; }
}
