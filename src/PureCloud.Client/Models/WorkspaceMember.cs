using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Groups;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class WorkspaceMember
{
    /// <summary>
    /// The workspace member type.
    /// </summary>
    /// <value>The workspace member type.</value>
    public WorkspaceMemberMemberTypeEnum? MemberType { get; set; }

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
    /// Gets or Sets Workspace
    /// </summary>
    public DomainEntityRef Workspace { get; set; }

    /// <summary>
    /// Gets or Sets Member
    /// </summary>
    public DomainEntityRef Member { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public Group Group { get; set; }

    /// <summary>
    /// Gets or Sets SecurityProfile
    /// </summary>
    public SecurityProfile SecurityProfile { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
