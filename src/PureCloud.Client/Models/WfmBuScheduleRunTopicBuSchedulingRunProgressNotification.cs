using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuScheduleRunTopicBuSchedulingRunProgressNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmBuScheduleRunTopicBuSchedulingRunProgressNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    public WfmBuScheduleRunTopicBuScheduleRun Result { get; set; }
}
