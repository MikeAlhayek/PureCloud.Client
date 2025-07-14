using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateShareRequest
{
    /// <summary>
    /// The share entity type
    /// </summary>
    /// <value>The share entity type</value>
    public CreateShareRequestSharedEntityTypeEnum? SharedEntityType { get; set; }

    /// <summary>
    /// Gets or Sets MemberType
    /// </summary>
    public CreateShareRequestMemberTypeEnum? MemberType { get; set; }

    /// <summary>
    /// The entity that will be shared
    /// </summary>
    /// <value>The entity that will be shared</value>
    public SharedEntity SharedEntity { get; set; }

    /// <summary>
    /// The member that will have access to this share. Only required if a list of members is not provided.
    /// </summary>
    /// <value>The member that will have access to this share. Only required if a list of members is not provided.</value>
    public SharedEntity Member { get; set; }

    /// <summary>
    /// Gets or Sets Members
    /// </summary>
    public IEnumerable<CreateShareRequestMember> Members { get; set; }
}
