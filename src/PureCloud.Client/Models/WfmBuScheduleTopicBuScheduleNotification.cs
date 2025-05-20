using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuScheduleTopicBuScheduleNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmBuScheduleTopicBuScheduleNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public WfmBuScheduleTopicBuScheduleNotificationEventTypeEnum? EventType { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    public WfmBuScheduleTopicBuScheduleMetadata Result { get; set; }
}
