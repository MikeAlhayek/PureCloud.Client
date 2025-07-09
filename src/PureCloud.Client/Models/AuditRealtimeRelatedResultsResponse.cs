using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditRealtimeRelatedResultsResponse
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<AuditLogMessage> Entities { get; set; }
}
