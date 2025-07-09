using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DomainOrganizationRoleCreate
{
    /// <summary>
    /// role id
    /// </summary>
    /// <value>role id</value>
    public string Id { get; set; }

    /// <summary>
    /// The role name
    /// </summary>
    /// <value>The role name</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets DefaultRoleId
    /// </summary>
    public string DefaultRoleId { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    public IEnumerable<string> Permissions { get; set; }

    /// <summary>
    /// A collection of the permissions the role is not using
    /// </summary>
    /// <value>A collection of the permissions the role is not using</value>
    public IEnumerable<string> UnusedPermissions { get; set; }

    /// <summary>
    /// Gets or Sets PermissionPolicies
    /// </summary>
    public IEnumerable<DomainPermissionPolicy> PermissionPolicies { get; set; }

    /// <summary>
    /// Gets or Sets UserCount
    /// </summary>
    public int? UserCount { get; set; }

    /// <summary>
    /// Optional unless patch operation.
    /// </summary>
    /// <value>Optional unless patch operation.</value>
    public bool? RoleNeedsUpdate { get; set; }

    /// <summary>
    /// Gets or Sets Base
    /// </summary>
    public bool? Base { get; set; }

    /// <summary>
    /// Gets or Sets Default
    public bool? Default { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
