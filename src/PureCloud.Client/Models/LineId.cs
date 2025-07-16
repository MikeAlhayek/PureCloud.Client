using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LineId
{
    /// <summary>
    /// The set of Line userIds that this person has. Each userId is specific to the Line channel that the user interacts with.
    /// </summary>
    /// <value>The set of Line userIds that this person has. Each userId is specific to the Line channel that the user interacts with.</value>
    public IEnumerable<LineUserId> Ids { get; set; }

    /// <summary>
    /// The displayName of this person&#39;s account in Line
    /// </summary>
    /// <value>The displayName of this person&#39;s account in Line</value>
    public string DisplayName { get; set; }
}
