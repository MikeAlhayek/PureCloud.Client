using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowOutcomeDetailEventTopicFlowMilestone
{
    /// <summary>
    /// Gets or Sets MilestoneId
    /// </summary>
    public Guid? MilestoneId { get; set; }

    /// <summary>
    /// Gets or Sets MilestoneTime
    /// </summary>
    public long? MilestoneTime { get; set; }
}
