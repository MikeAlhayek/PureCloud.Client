using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditQueryExecutionStatusResponse
{
    /// <summary>
    /// Status of the audit query execution request.
    /// </summary>
    /// <value>Status of the audit query execution request.</value>
    public AuditQueryExecutionStatusResponseStateEnum? State { get; set; }

    /// <summary>
    /// Id of the audit query execution request.
    /// </summary>
    /// <value>Id of the audit query execution request.</value>
    public string Id { get; set; }

    /// <summary>
    /// Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    public string Interval { get; set; }

    /// <summary>
    /// Service name for the audit query.
    /// </summary>
    /// <value>Service name for the audit query.</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// Filters for the audit query.
    /// </summary>
    /// <value>Filters for the audit query.</value>
    public IEnumerable<AuditQueryFilter> Filters { get; set; }

    /// <summary>
    /// Sort parameter for the audit query.
    /// </summary>
    /// <value>Sort parameter for the audit query.</value>
    public IEnumerable<AuditQuerySort> Sort { get; set; }
}
