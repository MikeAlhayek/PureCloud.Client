using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AssignUsers
{
    /// <summary>
    /// List of user ids to assign to a performance profile
    /// </summary>
    /// <value>List of user ids to assign to a performance profile</value>
    public IEnumerable<string> MembersToAssign { get; set; }

    /// <summary>
    /// List of user ids to remove from a performance profile
    /// </summary>
    /// <value>List of user ids to remove from a performance profile</value>
    public IEnumerable<string> MembersToRemove { get; set; }
}
