using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotificationStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleId
    /// </summary>
    public string ScheduleId { get; set; }

    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    public string WeekDate { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    public PerformancePredictionCompleteEventTopicErrorBody Error { get; set; }
}
