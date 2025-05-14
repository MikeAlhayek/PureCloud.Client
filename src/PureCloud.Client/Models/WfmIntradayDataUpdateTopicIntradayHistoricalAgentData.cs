using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntradayDataUpdateTopicIntradayHistoricalAgentData
{
    /// <summary>
    /// Gets or Sets OnQueueTimeSeconds
    /// </summary>
    public double? OnQueueTimeSeconds { get; set; }

    /// <summary>
    /// Gets or Sets InteractingTimeSeconds
    /// </summary>
    public double? InteractingTimeSeconds { get; set; }
}
