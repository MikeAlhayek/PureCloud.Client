using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification
{
    /// <summary>
    /// Gets or Sets QueryState
    /// </summary>
    public WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotificationQueryStateEnum? QueryState { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrls
    /// </summary>
    public IEnumerable<string> DownloadUrls { get; set; }
}
