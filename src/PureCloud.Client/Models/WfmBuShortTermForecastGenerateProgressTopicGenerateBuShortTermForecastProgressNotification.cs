using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    public WfmBuShortTermForecastGenerateProgressTopicBuShortTermForecast Result { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets Progress
    /// </summary>
    public long? Progress { get; set; }
}
