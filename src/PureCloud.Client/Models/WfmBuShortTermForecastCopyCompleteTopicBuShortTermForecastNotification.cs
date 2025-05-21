using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastCopyCompleteTopicBuShortTermForecastNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmBuShortTermForecastCopyCompleteTopicBuShortTermForecastNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    public WfmBuShortTermForecastCopyCompleteTopicBuShortTermForecast Result { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }
}
