using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults
{
    /// <summary>
    /// Gets or Sets WeekNumber
    /// </summary>
    public long? WeekNumber { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrlExpirationDate
    /// </summary>
    public DateTime? DownloadUrlExpirationDate { get; set; }
}
