using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Groups;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class GroupUpdate
{
    /// <summary>
    /// State of the group.
    /// </summary>
    /// <value>State of the group.</value>
    public GroupUpdateStateEnum? State { get; set; }

    /// <summary>
    /// Who can view this group
    /// </summary>
    /// <value>Who can view this group</value>
    public GroupUpdateVisibilityEnum? Visibility { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The group name.
    /// </summary>
    /// <value>The group name.</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Current version for this resource.
    /// </summary>
    /// <value>Current version for this resource.</value>
    public int? Version { get; set; }

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
    /// <value>Are membership rules visible to the person requesting to view the group</value>
    public bool? RulesVisible { get; set; }

    /// <summary>
    /// Allow roles to be assigned to this group
    /// </summary>
    /// <value>Allow roles to be assigned to this group</value>
    public bool? RolesEnabled { get; set; }

    /// <summary>
    /// Allow owners to be included as members of the group
    /// </summary>
    /// <value>Allow owners to be included as members of the group</value>
    public bool? IncludeOwners { get; set; }

    /// <summary>
    /// Allow calls to be placed to this group.
    /// </summary>
    public bool? CallsEnabled { get; set; }

    /// <summary>
    /// Owners of the group
    /// </summary>
    /// <value>Owners of the group</value>
    public IEnumerable<string> OwnerIds { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
