using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntityStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets RequestId
    /// </summary>
    public string RequestId { get; set; }
}
