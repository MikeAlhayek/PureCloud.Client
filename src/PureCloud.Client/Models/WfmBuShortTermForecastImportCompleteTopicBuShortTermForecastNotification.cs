using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastImportCompleteTopicBuShortTermForecastNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmBuShortTermForecastImportCompleteTopicBuShortTermForecastNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    public WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast Result { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }
}
