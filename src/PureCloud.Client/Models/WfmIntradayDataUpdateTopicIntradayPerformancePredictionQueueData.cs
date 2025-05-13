using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData
{
    /// <summary>
    /// Gets or Sets ServiceLevelPercent
    /// </summary>
    public double? ServiceLevelPercent { get; set; }

    /// <summary>
    /// Gets or Sets AverageSpeedOfAnswerSeconds
    /// </summary>
    public double? AverageSpeedOfAnswerSeconds { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfInteractions
    /// </summary>
    public double? NumberOfInteractions { get; set; }
}
