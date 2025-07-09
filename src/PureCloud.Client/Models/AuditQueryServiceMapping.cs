using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditQueryServiceMapping
{
    /// <summary>
    /// List of Services
    /// </summary>
    /// <value>List of Services</value>
    public IEnumerable<AuditQueryService> Services { get; set; }
}
