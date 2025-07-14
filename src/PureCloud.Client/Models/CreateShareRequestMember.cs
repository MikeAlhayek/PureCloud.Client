using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateShareRequestMember
{
    /// <summary>
    /// Gets or Sets MemberType
    /// </summary>
    public CreateShareRequestMemberMemberTypeEnum? MemberType { get; set; }

    /// <summary>
    /// Gets or Sets Member
    /// </summary>
    public MemberEntity Member { get; set; }
}
