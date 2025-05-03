namespace PureCloud.Client.Models;

public sealed class PermissionDetails
{
    /// <summary>
    /// The type of permission requirement
    /// </summary>
    /// <value>The type of permission requirement</value>
    public PermissionDetailsType? Type { get; set; }

    /// <summary>
    /// List of required permissions
    /// </summary>
    /// <value>List of required permissions</value>
    public IEnumerable<string> Permissions { get; set; }

    /// <summary>
    /// Whether the current user can subscribe, when division permissions are otherwise required
    /// </summary>
    /// <value>Whether the current user can subscribe, when division permissions are otherwise required</value>
    public bool? AllowsCurrentUser { get; set; }

    /// <summary>
    /// Whether or not this permission requirement is enforced
    /// </summary>
    /// <value>Whether or not this permission requirement is enforced</value>
    public bool? Enforced { get; set; }
}
