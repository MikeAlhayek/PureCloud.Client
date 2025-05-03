namespace PureCloud.Client.Models;

public sealed class UserAuthorization
{
    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    public IEnumerable<DomainRole> Roles { get; set; }

    /// <summary>
    /// A collection of the roles the user is not using
    /// </summary>
    /// <value>A collection of the roles the user is not using</value>
    public IEnumerable<DomainRole> UnusedRoles { get; set; }

    /// <summary>
    /// A collection of the permissions granted by all assigned roles
    /// </summary>
    /// <value>A collection of the permissions granted by all assigned roles</value>
    public IEnumerable<string> Permissions { get; set; }

    /// <summary>
    /// The policies configured for assigned permissions.
    /// </summary>
    /// <value>The policies configured for assigned permissions.</value>
    public IEnumerable<ResourcePermissionPolicy> PermissionPolicies { get; set; }
}
