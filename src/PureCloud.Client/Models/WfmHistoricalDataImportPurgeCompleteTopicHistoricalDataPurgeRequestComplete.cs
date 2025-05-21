using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestCompleteStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity> Entities { get; set; }

    /// <summary>
    /// Gets or Sets DisallowedEntities
    /// </summary>
    public IEnumerable<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity> DisallowedEntities { get; set; }
}
