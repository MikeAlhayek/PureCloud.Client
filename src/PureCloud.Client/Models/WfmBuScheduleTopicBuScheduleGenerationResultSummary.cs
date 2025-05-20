using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuScheduleTopicBuScheduleGenerationResultSummary
{
    /// <summary>
    /// Gets or Sets Failed
    /// </summary>
    public bool? Failed { get; set; }

    /// <summary>
    /// Gets or Sets RunId
    /// </summary>
    public string RunId { get; set; }

    /// <summary>
    /// Gets or Sets MessageCount
    /// </summary>
    public long? MessageCount { get; set; }

    /// <summary>
    /// Gets or Sets MessageSeverityCounts
    /// </summary>
    public IEnumerable<WfmBuScheduleTopicSchedulerMessageSeverityCount> MessageSeverityCounts { get; set; }
}
