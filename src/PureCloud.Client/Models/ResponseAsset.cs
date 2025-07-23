using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// ResponseAsset
/// </summary>
public sealed class ResponseAsset
{
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
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public Division Division { get; set; }

    /// <summary>
    /// response asset size in bytes
    /// </summary>
    /// <value>response asset size in bytes</value>
    public long? ContentLength { get; set; }

    /// <summary>
    /// response asset location.
    /// </summary>
    /// <value>response asset location.</value>
    public string ContentLocation { get; set; }

    /// <summary>
    /// MIME type of response asset
    /// </summary>
    /// <value>MIME type of response asset</value>
    public string ContentType { get; set; }

    /// <summary>
    /// Created date of the response asset. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Created date of the response asset. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// User who created the response asset
    /// </summary>
    /// <value>User who created the response asset</value>
    public DomainEntityRef CreatedBy { get; set; }

    /// <summary>
    /// Last modified date of the response asset. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified date of the response asset. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// User who last modified the response asset
    /// </summary>
    /// <value>User who last modified the response asset</value>
    public DomainEntityRef ModifiedBy { get; set; }

    /// <summary>
    /// Canned responses actively using this asset
    /// </summary>
    /// <value>Canned responses actively using this asset</value>
    public IEnumerable<DomainEntityRef> Responses { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}