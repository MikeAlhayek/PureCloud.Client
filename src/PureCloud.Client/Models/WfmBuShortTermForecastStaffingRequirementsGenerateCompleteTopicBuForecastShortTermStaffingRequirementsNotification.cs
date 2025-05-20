using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;
public sealed class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotificationStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets BusinessUnitId
    /// </summary>
    public string BusinessUnitId { get; set; }

    /// <summary>
    /// Gets or Sets Forecast
    /// </summary>
    public WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference Forecast { get; set; }

    /// <summary>
    /// Gets or Sets WeekCount
    /// </summary>
    public long? WeekCount { get; set; }

    /// <summary>
    /// Gets or Sets IntervalLengthMinutes
    /// </summary>
    public long? IntervalLengthMinutes { get; set; }

    /// <summary>
    /// Gets or Sets ReferenceStartDate
    /// </summary>
    public DateTime? ReferenceStartDate { get; set; }

    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    public IEnumerable<WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults> Results { get; set; }
}
