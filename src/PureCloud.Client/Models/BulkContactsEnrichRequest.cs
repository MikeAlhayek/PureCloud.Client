using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkContactsEnrichRequest
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ContactEnrichRequest> Entities { get; set; }
}
