using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Models;

/// <summary>
/// Trustee
/// </summary>
public sealed class Trustee
{
    /// <summary>
    /// Organization Id for this trust.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// If disabled no trustee user will have access, even if they were previously added.
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Denotes if trustee uses admin role by default.
    /// </summary>
    public bool? UsesDefaultRole { get; set; }

    /// <summary>
    /// Denotes if trustee uses full access role by default.
    /// </summary>
    public bool? HasFullAccess { get; set; }

    /// <summary>
    /// Denotes if trustee is given Trusted User access by default.
    /// </summary>
    public bool? IsTrustedUser { get; set; }

    /// <summary>
    /// Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateExpired { get; set; }

    /// <summary>
    /// User that created trust.
    /// </summary>
    public OrgUser CreatedBy { get; set; }

    /// <summary>
    /// Organization associated with this trust.
    /// </summary>
    public Organization Organization { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}