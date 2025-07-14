using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Groups;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class Share
{
    /// <summary>
    /// Gets or Sets SharedEntityType
    /// </summary>
    public ShareSharedEntityTypeEnum? SharedEntityType { get; set; }

    /// <summary>
    /// Gets or Sets MemberType
    /// </summary>
    public ShareMemberTypeEnum? MemberType { get; set; }

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
    /// Gets or Sets SharedEntity
    /// </summary>
    public DomainEntityRef SharedEntity { get; set; }

    /// <summary>
    /// Gets or Sets Member
    /// </summary>
    public DomainEntityRef Member { get; set; }

    /// <summary>
    /// Gets or Sets SharedBy
    /// </summary>
    public DomainEntityRef SharedBy { get; set; }

    /// <summary>
    /// Gets or Sets Workspace
    /// </summary>
    public DomainEntityRef Workspace { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public Group Group { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
