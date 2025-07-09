using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditQueryService
{
    /// <summary>
    /// Name of the Service
    /// </summary>
    /// <value>Name of the Service</value>
    public string Name { get; set; }

    /// <summary>
    /// List of Entities
    /// </summary>
    /// <value>List of Entities</value>
    public IEnumerable<AuditQueryEntity> Entities { get; set; }
}
