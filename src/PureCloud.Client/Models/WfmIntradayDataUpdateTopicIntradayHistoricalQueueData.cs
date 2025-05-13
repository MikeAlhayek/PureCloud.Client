using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntradayDataUpdateTopicIntradayHistoricalQueueData
{
    /// <summary>
    /// Gets or Sets Offered
    /// </summary>
    public long? Offered { get; set; }

    /// <summary>
    /// Gets or Sets Completed
    /// </summary>
    public long? Completed { get; set; }

    /// <summary>
    /// Gets or Sets Answered
    /// </summary>
    public long? Answered { get; set; }

    /// <summary>
    /// Gets or Sets Abandoned
    /// </summary>
    public long? Abandoned { get; set; }

    /// <summary>
    /// Gets or Sets AverageTalkTimeSeconds
    /// </summary>
    public double? AverageTalkTimeSeconds { get; set; }

    /// <summary>
    /// Gets or Sets AverageAfterCallWorkSeconds
    /// </summary>
    public double? AverageAfterCallWorkSeconds { get; set; }

    /// <summary>
    /// Gets or Sets ServiceLevelPercent
    /// </summary>
    public double? ServiceLevelPercent { get; set; }

    /// <summary>
    /// Gets or Sets AverageSpeedOfAnswerSeconds
    /// </summary>
    public double? AverageSpeedOfAnswerSeconds { get; set; }
}
