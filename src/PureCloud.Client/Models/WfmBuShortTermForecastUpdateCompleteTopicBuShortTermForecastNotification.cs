using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecastNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecastNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    public WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast Result { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }
}
