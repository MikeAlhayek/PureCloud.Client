using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditRealtimeRelatedRequest
{
    /// <summary>
    /// The id of the audit of which related audits will be retrieved.
    /// </summary>
    /// <value>The id of the audit of which related audits will be retrieved.</value>
    public string AuditId { get; set; }

    /// <summary>
    /// The id of the trustor org to which the audit belongs. Used when searching for audits performed by a trustee user within a trustor org.
    /// </summary>
    /// <value>The id of the trustor org to which the audit belongs. Used when searching for audits performed by a trustee user within a trustor org.</value>
    public string TrustorOrgId { get; set; }

    /// <summary>
    /// Sort parameter for the query.
    /// </summary>
    /// <value>Sort parameter for the query.</value>
    public IEnumerable<AuditQuerySort> Sort { get; set; }
}
