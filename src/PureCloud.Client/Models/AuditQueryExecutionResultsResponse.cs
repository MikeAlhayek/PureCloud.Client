using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditQueryExecutionResultsResponse
{
    /// <summary>
    /// Id of the audit query execution request.
    /// </summary>
    /// <value>Id of the audit query execution request.</value>
    public string Id { get; set; }

    /// <summary>
    /// Number of results in a page.
    /// </summary>
    /// <value>Number of results in a page.</value>
    public int? PageSize { get; set; }

    /// <summary>
    /// Optional cursor to indicate where to resume the results.
    /// </summary>
    /// <value>Optional cursor to indicate where to resume the results.</value>
    public string Cursor { get; set; }

    /// <summary>
    /// List of audit messages.
    /// </summary>
    /// <value>List of audit messages.</value>
    public IEnumerable<AuditLogMessage> Entities { get; set; }
}
