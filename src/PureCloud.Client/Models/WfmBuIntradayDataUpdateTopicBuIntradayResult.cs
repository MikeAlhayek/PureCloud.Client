using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuIntradayDataUpdateTopicBuIntradayResult
{
    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets IntervalLengthMinutes
    /// </summary>
    public long? IntervalLengthMinutes { get; set; }

    /// <summary>
    /// Gets or Sets IntradayDataGroupings
    /// </summary>
    public IEnumerable<WfmBuIntradayDataUpdateTopicBuIntradayDataGroup> IntradayDataGroupings { get; set; }

    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    public IEnumerable<WfmBuIntradayDataUpdateTopicBuIntradayResultCategoriesEnum> Categories { get; set; }

    /// <summary>
    /// Gets or Sets NoDataReason
    /// </summary>
    public string NoDataReason { get; set; }

    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    public WfmBuIntradayDataUpdateTopicBuScheduleReference Schedule { get; set; }

    /// <summary>
    /// Gets or Sets ShortTermForecast
    /// </summary>
    public WfmBuIntradayDataUpdateTopicBuShortTermForecastReference ShortTermForecast { get; set; }
}
