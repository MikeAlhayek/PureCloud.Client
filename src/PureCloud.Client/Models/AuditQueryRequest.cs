using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditQueryRequest
{
    /// <summary>
    /// Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ
    /// </summary>
    /// <value>Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ</value>
    public string Interval { get; set; }

    /// <summary>
    /// Name of the service to query audits for.
    /// </summary>
    /// <value>Name of the service to query audits for.</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// Additional filters for the query.
    /// </summary>
    /// <value>Additional filters for the query.</value>
    public IEnumerable<AuditQueryFilter> Filters { get; set; }

    /// <summary>
    /// Sort parameter for the query.
    /// </summary>
    /// <value>Sort parameter for the query.</value>
    public IEnumerable<AuditQuerySort> Sort { get; set; }
}
