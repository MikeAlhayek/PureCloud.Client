using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntradayDataUpdateTopicIntradayDataUpdate
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
    /// Gets or Sets NumberOfIntervals
    /// </summary>
    public long? NumberOfIntervals { get; set; }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    public IEnumerable<WfmIntradayDataUpdateTopicIntradayMetric> Metrics { get; set; }

    /// <summary>
    /// Gets or Sets QueueIds
    /// </summary>
    public IEnumerable<string> QueueIds { get; set; }

    /// <summary>
    /// Gets or Sets IntradayDataGroupings
    /// </summary>
    public IEnumerable<WfmIntradayDataUpdateTopicIntradayDataGroup> IntradayDataGroupings { get; set; }
}
