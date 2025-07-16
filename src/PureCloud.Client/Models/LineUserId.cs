using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LineUserId
{
    /// <summary>
    /// The unique channel-specific userId for the user
    /// </summary>
    /// <value>The unique channel-specific userId for the user</value>
    public string UserId { get; set; }
}
