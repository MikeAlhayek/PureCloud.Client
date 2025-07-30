namespace PureCloud.Client.Models;

public sealed class TrusteeAuditQueryRequest
{


    /// <summary>
    /// Limit returned audits to these trustee organizationIds.
    /// </summary>
    /// <value>Limit returned audits to these trustee organizationIds.</value>
    public IEnumerable<string> TrusteeOrganizationIds { get; set; }

    /// <summary>
    /// Limit returned audits to these trustee userIds.
    /// </summary>
    /// <value>Limit returned audits to these trustee userIds.</value>
    public IEnumerable<string> TrusteeUserIds { get; set; }

    /// <summary>
    /// Starting date/time for the audit search. ISO-8601 formatted date-time, UTC.
    /// </summary>
    /// <value>Starting date/time for the audit search. ISO-8601 formatted date-time, UTC.</value>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Ending date/time for the audit search. ISO-8601 formatted date-time, UTC.
    /// </summary>
    /// <value>Ending date/time for the audit search. ISO-8601 formatted date-time, UTC.</value>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Word or phrase to look for in audit bodies.
    /// </summary>
    /// <value>Word or phrase to look for in audit bodies.</value>
    public string QueryPhrase { get; set; }

    /// <summary>
    /// Facet information to be returned with the query results.
    /// </summary>
    /// <value>Facet information to be returned with the query results.</value>
    public IEnumerable<object> Facets { get; set; }

    /// <summary>
    /// Additional custom filters to be applied to the query.
    /// </summary>
    /// <value>Additional custom filters to be applied to the query.</value>
    public IEnumerable<object> Filters { get; set; }
}
