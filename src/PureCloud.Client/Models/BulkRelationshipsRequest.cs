using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkRelationshipsRequest
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<Relationship> Entities { get; set; }
}
