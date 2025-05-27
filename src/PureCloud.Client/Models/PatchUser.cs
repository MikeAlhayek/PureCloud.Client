using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PatchUser
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Preferred full name of agent
    /// </summary>
    /// <value>Preferred full name of agent</value>
    public string PreferredName { get; set; }

    /// <summary>
    /// The value that denotes if acdAutoAnswer is set on the user
    /// </summary>
    /// <value>The value that denotes if acdAutoAnswer is set on the user</value>
    public bool? AcdAutoAnswer { get; set; }
}
