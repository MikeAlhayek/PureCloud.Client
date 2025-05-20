using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PerformancePredictionRecalculationCompleteEventTopicPerformancePredictionUserRecalculationNotification
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public PerformancePredictionRecalculationCompleteEventTopicPerformancePredictionUserRecalculationNotificationStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    public PerformancePredictionRecalculationCompleteEventTopicErrorBody Error { get; set; }
}
