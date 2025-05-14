using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntradayDataUpdateTopicIntradayDataGroup
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public WfmIntradayDataUpdateTopicIntradayDataGroupMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets ForecastDataPerInterval
    /// </summary>
    public IEnumerable<WfmIntradayDataUpdateTopicIntradayForecastData> ForecastDataPerInterval { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleDataPerInterval
    /// </summary>
    public IEnumerable<WfmIntradayDataUpdateTopicIntradayScheduleData> ScheduleDataPerInterval { get; set; }

    /// <summary>
    /// Gets or Sets HistoricalAgentDataPerInterval
    /// </summary>
    public IEnumerable<WfmIntradayDataUpdateTopicIntradayHistoricalAgentData> HistoricalAgentDataPerInterval { get; set; }

    /// <summary>
    /// Gets or Sets HistoricalQueueDataPerInterval
    /// </summary>
    public IEnumerable<WfmIntradayDataUpdateTopicIntradayHistoricalQueueData> HistoricalQueueDataPerInterval { get; set; }

    /// <summary>
    /// Gets or Sets PerformancePredictionAgentDataPerInterval
    /// </summary>
    public IEnumerable<WfmIntradayDataUpdateTopicIntradayPerformancePredictionAgentData> PerformancePredictionAgentDataPerInterval { get; set; }

    /// <summary>
    /// Gets or Sets PerformancePredictionQueueDataPerInterval
    /// </summary>
    public IEnumerable<WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData> PerformancePredictionQueueDataPerInterval { get; set; }
}
