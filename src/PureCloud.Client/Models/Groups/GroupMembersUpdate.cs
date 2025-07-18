using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GroupMembersUpdate
{
    /// <summary>
    /// A list of the ids of the members to add. A maximum of 50 members are allowed per request.
    /// </summary>
    /// <value>A list of the ids of the members to add. A maximum of 50 members are allowed per request.</value>
    public IEnumerable<string> MemberIds { get; set; }

    /// <summary>
    /// The current group version.
    /// </summary>
    /// <value>The current group version.</value>
    public int? Version { get; set; }
}
