using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalMetricDataWriteResponse
{
    /// <summary>
    /// The list of processed entities
    /// </summary>
    /// <value>The list of processed entities</value>
    public IEnumerable<ExternalMetricDataProcessedItem> ProcessedEntities { get; set; }

    /// <summary>
    /// The list of unprocessed entities
    /// </summary>
    /// <value>The list of unprocessed entities</value>
    public IEnumerable<ExternalMetricDataUnprocessedItem> UnprocessedEntities { get; set; }
}
