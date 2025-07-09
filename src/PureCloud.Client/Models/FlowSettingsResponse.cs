
namespace PureCloud.Client.Models;

public sealed class FlowSettingsResponse
{
    /// <summary>
    /// The Flow Type
    /// </summary>
    /// <value>The Flow Type</value>
    public FlowSettingsResponseTypeEnum? Type { get; set; }

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
    /// User that last changed the log level setting.
    /// </summary>
    /// <value>User that last changed the log level setting.</value>
    public UserReference ModifiedBy { get; set; }

    /// <summary>
    /// OAuth client that last changed the log level setting.
    /// </summary>
    /// <value>OAuth client that last changed the log level setting.</value>
    public DomainEntityRef ModifiedByClient { get; set; }

    /// <summary>
    /// The time this log level was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time this log level was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The log level set for this flow
    /// </summary>
    /// <value>The log level set for this flow</value>
    public FlowLogLevel LogLevelCharacteristics { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
