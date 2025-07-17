using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GDPRRequest
{
    /// <summary>
    /// The type of GDPR request
    /// </summary>
    /// <value>The type of GDPR request</value>
    public GDPRRequestRequestTypeEnum? RequestType { get; set; }

    /// <summary>
    /// The status of the request
    /// </summary>
    /// <value>The status of the request</value>
    public GDPRRequestStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The user that created this request
    /// </summary>
    /// <value>The user that created this request</value>
    public DomainEntityRef CreatedBy { get; set; }

    /// <summary>
    /// The replacement terms for the provided search terms, in the case of a GDPR_UPDATE request
    /// </summary>
    /// <value>The replacement terms for the provided search terms, in the case of a GDPR_UPDATE request</value>
    public IEnumerable<ReplacementTerm> ReplacementTerms { get; set; }

    /// <summary>
    /// When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The subject of the GDPR request
    /// </summary>
    /// <value>The subject of the GDPR request</value>
    public GDPRSubject Subject { get; set; }

    /// <summary>
    /// The location where the results of the request can be retrieved
    /// </summary>
    /// <value>The location where the results of the request can be retrieved</value>
    public string ResultsUrl { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
