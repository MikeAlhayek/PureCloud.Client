using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrusteeAuditQueryRequest
/// </summary>

public partial class TrusteeAuditQueryRequest : IEquatable<TrusteeAuditQueryRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TrusteeAuditQueryRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TrusteeAuditQueryRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TrusteeAuditQueryRequest" /> class.
    /// </summary>
    /// <param name="TrusteeOrganizationIds">Limit returned audits to these trustee organizationIds. (required).</param>
    /// <param name="TrusteeUserIds">Limit returned audits to these trustee userIds. (required).</param>
    /// <param name="StartDate">Starting date/time for the audit search. ISO-8601 formatted date-time, UTC..</param>
    /// <param name="EndDate">Ending date/time for the audit search. ISO-8601 formatted date-time, UTC..</param>
    /// <param name="QueryPhrase">Word or phrase to look for in audit bodies..</param>
    /// <param name="Facets">Facet information to be returned with the query results..</param>
    /// <param name="Filters">Additional custom filters to be applied to the query..</param>
    public TrusteeAuditQueryRequest(List<string> TrusteeOrganizationIds = null, List<string> TrusteeUserIds = null, DateTime? StartDate = null, DateTime? EndDate = null, string QueryPhrase = null, List<Facet> Facets = null, List<Filter> Filters = null)
    {
        this.TrusteeOrganizationIds = TrusteeOrganizationIds;
        this.TrusteeUserIds = TrusteeUserIds;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.QueryPhrase = QueryPhrase;
        this.Facets = Facets;
        this.Filters = Filters;

    }



    /// <summary>
    /// Limit returned audits to these trustee organizationIds.
    /// </summary>
    /// <value>Limit returned audits to these trustee organizationIds.</value>
    [JsonPropertyName("trusteeOrganizationIds")]
    public List<string> TrusteeOrganizationIds { get; set; }



    /// <summary>
    /// Limit returned audits to these trustee userIds.
    /// </summary>
    /// <value>Limit returned audits to these trustee userIds.</value>
    [JsonPropertyName("trusteeUserIds")]
    public List<string> TrusteeUserIds { get; set; }



    /// <summary>
    /// Starting date/time for the audit search. ISO-8601 formatted date-time, UTC.
    /// </summary>
    /// <value>Starting date/time for the audit search. ISO-8601 formatted date-time, UTC.</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Ending date/time for the audit search. ISO-8601 formatted date-time, UTC.
    /// </summary>
    /// <value>Ending date/time for the audit search. ISO-8601 formatted date-time, UTC.</value>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// Word or phrase to look for in audit bodies.
    /// </summary>
    /// <value>Word or phrase to look for in audit bodies.</value>
    [JsonPropertyName("queryPhrase")]
    public string QueryPhrase { get; set; }



    /// <summary>
    /// Facet information to be returned with the query results.
    /// </summary>
    /// <value>Facet information to be returned with the query results.</value>
    [JsonPropertyName("facets")]
    public List<Facet> Facets { get; set; }



    /// <summary>
    /// Additional custom filters to be applied to the query.
    /// </summary>
    /// <value>Additional custom filters to be applied to the query.</value>
    [JsonPropertyName("filters")]
    public List<Filter> Filters { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrusteeAuditQueryRequest {\n");

        sb.Append("  TrusteeOrganizationIds: ").Append(TrusteeOrganizationIds).Append("\n");
        sb.Append("  TrusteeUserIds: ").Append(TrusteeUserIds).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  QueryPhrase: ").Append(QueryPhrase).Append("\n");
        sb.Append("  Facets: ").Append(Facets).Append("\n");
        sb.Append("  Filters: ").Append(Filters).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as TrusteeAuditQueryRequest);
    }

    /// <summary>
    /// Returns true if TrusteeAuditQueryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TrusteeAuditQueryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrusteeAuditQueryRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TrusteeOrganizationIds == other.TrusteeOrganizationIds ||
                TrusteeOrganizationIds != null &&
                TrusteeOrganizationIds.SequenceEqual(other.TrusteeOrganizationIds)
            ) &&
            (
                TrusteeUserIds == other.TrusteeUserIds ||
                TrusteeUserIds != null &&
                TrusteeUserIds.SequenceEqual(other.TrusteeUserIds)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                QueryPhrase == other.QueryPhrase ||
                QueryPhrase != null &&
                QueryPhrase.Equals(other.QueryPhrase)
            ) &&
            (
                Facets == other.Facets ||
                Facets != null &&
                Facets.SequenceEqual(other.Facets)
            ) &&
            (
                Filters == other.Filters ||
                Filters != null &&
                Filters.SequenceEqual(other.Filters)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (TrusteeOrganizationIds != null)
            {
                hash = hash * 59 + TrusteeOrganizationIds.GetHashCode();
            }

            if (TrusteeUserIds != null)
            {
                hash = hash * 59 + TrusteeUserIds.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (QueryPhrase != null)
            {
                hash = hash * 59 + QueryPhrase.GetHashCode();
            }

            if (Facets != null)
            {
                hash = hash * 59 + Facets.GetHashCode();
            }

            if (Filters != null)
            {
                hash = hash * 59 + Filters.GetHashCode();
            }

            return hash;
        }
    }
}
