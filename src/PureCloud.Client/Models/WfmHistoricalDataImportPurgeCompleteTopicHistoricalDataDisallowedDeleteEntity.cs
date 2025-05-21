using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity
{
    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    public WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntityReasonEnum? Reason { get; set; }

    /// <summary>
    /// Gets or Sets RequestId
    /// </summary>
    public string RequestId { get; set; }
}
