namespace PureCloud.Client.Models;

/// <summary>
/// Attribute
/// </summary>
public sealed class Attribute
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The attribute name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public DomainEntityRef? CreatedBy { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public DomainEntityRef? ModifiedBy { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string? SelfUri { get; set; }
}
