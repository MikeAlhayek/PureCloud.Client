using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExecutionDataFlowSettingsResponse
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
    /// whether or not the setting is enabled.
    /// </summary>
    /// <value>whether or not the setting is enabled.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// User that last changed the setting.
    /// </summary>
    /// <value>User that last changed the setting.</value>
    public UserReference ModifiedBy { get; set; }

    /// <summary>
    /// OAuth client that last changed the setting.
    /// </summary>
    /// <value>OAuth client that last changed the setting.</value>
    public DomainEntityRef ModifiedByClient { get; set; }

    /// <summary>
    /// The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
