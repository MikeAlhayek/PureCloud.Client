using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class DependencyStatus
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public DependencyStatusStatusEnum? Status { get; set; }

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
    /// User that initiated the build.
    /// </summary>
    /// <value>User that initiated the build.</value>
    public User User { get; set; }

    /// <summary>
    /// OAuth client that initiated the build.
    /// </summary>
    /// <value>OAuth client that initiated the build.</value>
    public DomainEntityRef Client { get; set; }

    /// <summary>
    /// Gets or Sets BuildId
    /// </summary>
    public string BuildId { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStarted { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCompleted { get; set; }

    /// <summary>
    /// Gets or Sets FailedObjects
    /// </summary>
    public IEnumerable<FailedObject> FailedObjects { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
