using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkOrganizationsRequest
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ExternalOrganization> Entities { get; set; }
}
