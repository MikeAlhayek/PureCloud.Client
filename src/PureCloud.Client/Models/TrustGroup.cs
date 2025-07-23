using PureCloud.Client.Models.Groups;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// TrustGroup
/// </summary>
public sealed class TrustGroup
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The group name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Last modified date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Number of members.
    /// </summary>
    public long? MemberCount { get; set; }

    /// <summary>
    /// Active, inactive, or deleted state.
    /// </summary>
    public TrustGroupState? State { get; set; }

    /// <summary>
    /// Current version for this resource.
    /// </summary>
    public int? Version { get; set; }

    /// <summary>
    /// Type of group.
    /// </summary>
    public TrustGroupType? Type { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    public IEnumerable<Image> Images { get; set; }

    /// <summary>
    /// Gets or Sets Addresses
    /// </summary>
    public IEnumerable<GroupContact> Addresses { get; set; }

    /// <summary>
    /// Are membership rules visible to the person requesting to view the group
    /// </summary>
    public bool? RulesVisible { get; set; }

    /// <summary>
    /// Who can view this group
    /// </summary>
    public TrustGroupVisibility? Visibility { get; set; }

    /// <summary>
    /// Allow roles to be assigned to this group
    /// </summary>
    public bool? RolesEnabled { get; set; }

    /// <summary>
    /// Allow owners to be included as members of the group
    /// </summary>
    public bool? IncludeOwners { get; set; }

    /// <summary>
    /// Allow calls to be placed to this group.
    /// </summary>
    public bool? CallsEnabled { get; set; }

    /// <summary>
    /// Owners of the group
    /// </summary>
    public IEnumerable<User> Owners { get; set; }

    /// <summary>
    /// The date on which the trusted group was added. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The user that added trusted group.
    /// </summary>
    public OrgUser CreatedBy { get; set; }
}