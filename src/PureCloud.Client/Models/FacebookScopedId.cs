using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FacebookScopedId
{
    /// <summary>
    /// The unique page/app-specific scopedId for the user
    /// </summary>
    /// <value>The unique page/app-specific scopedId for the user</value>
    public string ScopedId { get; set; }
}
