using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmScheduleTopicWfmScheduleNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmScheduleTopicWfmScheduleNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public WfmScheduleTopicWfmScheduleNotificationEventTypeEnum? EventType { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets PercentComplete
    /// </summary>
    public long? PercentComplete { get; set; }
}
