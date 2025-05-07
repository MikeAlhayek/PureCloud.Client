using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuIntradayDataUpdateTopicBuScheduleReference
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    public DateTime? WeekDate { get; set; }
}
