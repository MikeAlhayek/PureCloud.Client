using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkResponseResultVoidEntityBulkEntityErrorEntity
{
    /// <summary>
    /// The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity.
    /// </summary>
    /// <value>The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity.</value>
    public string Id { get; set; }

    /// <summary>
    /// Whether the requested operation completed successfully.
    /// </summary>
    /// <value>Whether the requested operation completed successfully.</value>
    public bool? Success { get; set; }

    /// <summary>
    /// The entity which was affected by this Bulk operation. Only returned on success.
    /// </summary>
    /// <value>The entity which was affected by this Bulk operation. Only returned on success.</value>
    public object Entity { get; set; }

    /// <summary>
    /// An error describing why this Bulk operation failed. Only returned on failure.
    /// </summary>
    /// <value>An error describing why this Bulk operation failed. Only returned on failure.</value>
    public BulkEntityErrorEntity Error { get; set; }
}
