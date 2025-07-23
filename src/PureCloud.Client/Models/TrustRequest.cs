using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Models;

/// <summary>
/// TrustRequest
/// </summary>
public sealed class TrustRequest
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// User who created this request.
    /// </summary>
    public OrgUser CreatedBy { get; set; }

    /// <summary>
    /// Date request was created. There is a 48 hour expiration on all requests. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Trustee organization who generated this request.
    /// </summary>
    public Organization Trustee { get; set; }

    /// <summary>
    /// The list of trustee users that are requesting access.
    /// </summary>
    public IEnumerable<OrgUser> Users { get; set; }

    /// <summary>
    /// The list of trustee groups that are requesting access.
    /// </summary>
    public IEnumerable<TrustGroup> Groups { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}