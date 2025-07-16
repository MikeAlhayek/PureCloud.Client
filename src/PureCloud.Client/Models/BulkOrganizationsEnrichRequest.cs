using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkOrganizationsEnrichRequest
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ExternalOrganizationEnrichRequest> Entities { get; set; }
}
