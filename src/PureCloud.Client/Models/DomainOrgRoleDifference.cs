using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Models;

public sealed class DomainOrgRoleDifference
{
    /// <summary>
    /// Gets or Sets RemovedPermissionPolicies
    /// </summary>
    public IEnumerable<DomainPermissionPolicy> RemovedPermissionPolicies { get; set; }

    /// <summary>
    /// Gets or Sets AddedPermissionPolicies
    /// </summary>
    public IEnumerable<DomainPermissionPolicy> AddedPermissionPolicies { get; set; }

    /// <summary>
    /// Gets or Sets SamePermissionPolicies
    /// </summary>
    public IEnumerable<DomainPermissionPolicy> SamePermissionPolicies { get; set; }

    /// <summary>
    /// Gets or Sets UserOrgRole
    /// </summary>
    public DomainOrganizationRole UserOrgRole { get; set; }

    /// <summary>
    /// Gets or Sets RoleFromDefault
    /// </summary>
    public DomainOrganizationRole RoleFromDefault { get; set; }
}
