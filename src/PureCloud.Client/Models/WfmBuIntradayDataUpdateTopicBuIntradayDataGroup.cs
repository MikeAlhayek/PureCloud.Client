using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuIntradayDataUpdateTopicBuIntradayDataGroup
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public WfmBuIntradayDataUpdateTopicBuIntradayDataGroupMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets ForecastDataSummary
    /// </summary>
    public WfmBuIntradayDataUpdateTopicBuIntradayForecastData ForecastDataSummary { get; set; }

    /// <summary>
    /// Gets or Sets ForecastDataPerInterval
    /// </summary>
    public IEnumerable<WfmBuIntradayDataUpdateTopicBuIntradayForecastData> ForecastDataPerInterval { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleDataSummary
    /// </summary>
    public WfmBuIntradayDataUpdateTopicBuIntradayScheduleData ScheduleDataSummary { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleDataPerInterval
    /// </summary>
    public IEnumerable<WfmBuIntradayDataUpdateTopicBuIntradayScheduleData> ScheduleDataPerInterval { get; set; }

    /// <summary>
    /// Gets or Sets PerformancePredictionDataSummary
    /// </summary>
    public WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData PerformancePredictionDataSummary { get; set; }

    /// <summary>
    /// Gets or Sets PerformancePredictionDataPerInterval
    /// </summary>
    public IEnumerable<WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData> PerformancePredictionDataPerInterval { get; set; }
}
