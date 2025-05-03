namespace PureCloud.Client.Models;

public sealed class AvailableTopic
{
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Full detailed permissions required to subscribe to the topic
    /// </summary>
    /// <value>Full detailed permissions required to subscribe to the topic</value>
    public IEnumerable<PermissionDetails> PermissionDetails { get; set; }

    /// <summary>
    /// Permissions required to subscribe to the topic
    /// </summary>
    /// <value>Permissions required to subscribe to the topic</value>
    public IEnumerable<string> RequiresPermissions { get; set; }

    /// <summary>
    /// True if the subscribing user must belong to the same division as the topic object ID
    /// </summary>
    /// <value>True if the subscribing user must belong to the same division as the topic object ID</value>
    public bool? RequiresDivisionPermissions { get; set; }

    /// <summary>
    /// If multiple permissions are required for this topic, such as both requiresCurrentUser and requiresDivisionPermissions, then true here indicates that meeting any one condition will satisfy the requirements; false indicates all conditions must be met.
    /// </summary>
    /// <value>If multiple permissions are required for this topic, such as both requiresCurrentUser and requiresDivisionPermissions, then true here indicates that meeting any one condition will satisfy the requirements; false indicates all conditions must be met.</value>
    public bool? RequiresAnyValidator { get; set; }

    /// <summary>
    /// Whether or not the permissions on this topic are enforced
    /// </summary>
    /// <value>Whether or not the permissions on this topic are enforced</value>
    public bool? Enforced { get; set; }

    /// <summary>
    /// Gets or Sets Schema
    /// </summary>
    public Dictionary<string, object> Schema { get; set; }

    /// <summary>
    /// True if the topic user ID is required to match the subscribing user ID
    /// </summary>
    /// <value>True if the topic user ID is required to match the subscribing user ID</value>
    public bool? RequiresCurrentUser { get; set; }

    /// <summary>
    /// True if permissions are only required when the topic user ID does not match the subscribing user ID
    /// </summary>
    /// <value>True if permissions are only required when the topic user ID does not match the subscribing user ID</value>
    public bool? RequiresCurrentUserOrPermission { get; set; }

    /// <summary>
    /// Transports that support events for the topic
    /// </summary>
    /// <value>Transports that support events for the topic</value>
    public IEnumerable<AvailableTopicTransports> Transports { get; set; }

    /// <summary>
    /// Gets or Sets PublicApiTemplateUriPaths
    /// </summary>
    public IEnumerable<string> PublicApiTemplateUriPaths { get; set; }

    /// <summary>
    /// Parameters in the topic name that can be substituted, in the order they appear in the topic name
    /// </summary>
    /// <value>Parameters in the topic name that can be substituted, in the order they appear in the topic name</value>
    public IEnumerable<string> TopicParameters { get; set; }
}
