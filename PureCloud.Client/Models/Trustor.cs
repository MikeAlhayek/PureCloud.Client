namespace PureCloud.Client.Models;

/// <summary>
/// Trustor
/// </summary>

public sealed class Trustor
{
    /// <summary>
    /// Organization Id for this trust.
    /// </summary>
    /// <value>Organization Id for this trust.</value>
    public string Id { get; set; }

    /// <summary>
    /// If disabled no trustee user will have access, even if they were previously added.
    /// </summary>
    /// <value>If disabled no trustee user will have access, even if they were previously added.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// User that created trust.
    /// </summary>
    /// <value>User that created trust.</value>
    public OrgUser CreatedBy { get; set; }

    /// <summary>
    /// Organization associated with this trust.
    /// </summary>
    /// <value>Organization associated with this trust.</value>
    public Organization Organization { get; set; }

    /// <summary>
    /// Authorization for the trustee user has in this trustor organization
    /// </summary>
    /// <value>Authorization for the trustee user has in this trustor organization</value>
    public TrusteeAuthorization Authorization { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
