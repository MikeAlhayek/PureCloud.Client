using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer
{
    /// <summary>
    /// Gets or Sets DayOfWeek
    /// </summary>
    public WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointerDayOfWeekEnum? DayOfWeek { get; set; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    public long? Weight { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    public string Date { get; set; }

    /// <summary>
    /// Gets or Sets FileName
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Gets or Sets DataKey
    /// </summary>
    public string DataKey { get; set; }
}
