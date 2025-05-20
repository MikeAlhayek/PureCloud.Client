using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuScheduleTopicBuManagementUnitScheduleSummary
{
    /// <summary>
    /// Gets or Sets ManagementUnit
    /// </summary>
    public WfmBuScheduleTopicManagementUnit ManagementUnit { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets Agents
    /// </summary>
    public IEnumerable<WfmBuScheduleTopicUserReference> Agents { get; set; }

    /// <summary>
    /// Gets or Sets AgentCount
    /// </summary>
    public long? AgentCount { get; set; }
}
