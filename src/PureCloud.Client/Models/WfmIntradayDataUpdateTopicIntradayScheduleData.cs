using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntradayDataUpdateTopicIntradayScheduleData
{
    /// <summary>
    /// Gets or Sets OnQueueTimeSeconds
    /// </summary>
    public long? OnQueueTimeSeconds { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledTimeSeconds
    /// </summary>
    public long? ScheduledTimeSeconds { get; set; }
}
