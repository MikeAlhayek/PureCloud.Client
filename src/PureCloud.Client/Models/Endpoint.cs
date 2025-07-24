using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// Endpoint
/// </summary>
public sealed class Endpoint
{
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    public EndpointStateEnum? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public Division Division { get; set; }

    /// <summary>
    /// The resource&#39;s description.
    /// </summary>
    /// <value>The resource&#39;s description.</value>
    public string Description { get; set; }

    /// <summary>
    /// The current version of the resource.
    /// </summary>
    /// <value>The current version of the resource.</value>
    public int? Version { get; set; }

    /// <summary>
    /// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The ID of the user that last modified the resource.
    /// </summary>
    /// <value>The ID of the user that last modified the resource.</value>
    public string ModifiedBy { get; set; }

    /// <summary>
    /// The ID of the user that created the resource.
    /// </summary>
    /// <value>The ID of the user that created the resource.</value>
    public string CreatedBy { get; set; }

    /// <summary>
    /// The application that last modified the resource.
    /// </summary>
    /// <value>The application that last modified the resource.</value>
    public string ModifiedByApp { get; set; }

    /// <summary>
    /// The application that created the resource.
    /// </summary>
    /// <value>The application that created the resource.</value>
    public string CreatedByApp { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    public int? Count { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    public Dictionary<string, object> Properties { get; set; }

    /// <summary>
    /// Schema
    /// </summary>
    /// <value>Schema</value>
    public DomainEntityRef Schema { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Site
    /// </summary>
    public DomainEntityRef Site { get; set; }

    /// <summary>
    /// Gets or Sets Dids
    /// </summary>
    public IEnumerable<string> Dids { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
