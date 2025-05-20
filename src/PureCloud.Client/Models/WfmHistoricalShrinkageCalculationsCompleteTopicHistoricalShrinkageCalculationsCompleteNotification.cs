using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotificationStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrls
    /// </summary>
    public IEnumerable<string> DownloadUrls { get; set; }
}
