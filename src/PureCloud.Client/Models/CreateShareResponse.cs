using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateShareResponse
{
    /// <summary>
    /// Gets or Sets SharedEntityType
    /// </summary>
    public CreateShareResponseSharedEntityTypeEnum? SharedEntityType { get; set; }

    /// <summary>
    /// Gets or Sets MemberType
    /// </summary>
    public CreateShareResponseMemberTypeEnum? MemberType { get; set; }

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
    /// Gets or Sets Succeeded
    /// </summary>
    public IEnumerable<Share> Succeeded { get; set; }

    /// <summary>
    /// Gets or Sets Failed
    /// </summary>
    public IEnumerable<Share> Failed { get; set; }
}
