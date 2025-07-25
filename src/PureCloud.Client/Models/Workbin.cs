namespace PureCloud.Client.Models;

/// <summary>
/// Workbin
/// </summary>
public sealed class Workbin
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Workbin name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    public Division Division { get; set; }

    /// <summary>
    /// Workbin description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The creation date of the Workbin. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The modified date of the Workbin. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The id of the User who modified the Workbin.
    /// </summary>
    public UserReference ModifiedBy { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}
