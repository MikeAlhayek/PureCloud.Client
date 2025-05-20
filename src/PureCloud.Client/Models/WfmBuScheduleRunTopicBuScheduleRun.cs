using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuScheduleRunTopicBuScheduleRun
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public WfmBuScheduleRunTopicBuScheduleRunStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets PercentComplete
    /// </summary>
    public double? PercentComplete { get; set; }

    /// <summary>
    /// Gets or Sets IntradayRescheduling
    /// </summary>
    public bool? IntradayRescheduling { get; set; }

    /// <summary>
    /// Gets or Sets WeekCount
    /// </summary>
    public long? WeekCount { get; set; }

    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    public WfmBuScheduleRunTopicBuScheduleReference Schedule { get; set; }

    /// <summary>
    /// Gets or Sets SchedulingCanceledBy
    /// </summary>
    public WfmBuScheduleRunTopicUserReference SchedulingCanceledBy { get; set; }

    /// <summary>
    /// Gets or Sets SchedulingCompletedTime
    /// </summary>
    public string SchedulingCompletedTime { get; set; }

    /// <summary>
    /// Gets or Sets MessageCount
    /// </summary>
    public long? MessageCount { get; set; }

    /// <summary>
    /// Gets or Sets MessageSeverityCounts
    /// </summary>
    public IEnumerable<WfmBuScheduleRunTopicSchedulerMessageSeverityCount> MessageSeverityCounts { get; set; }
}
