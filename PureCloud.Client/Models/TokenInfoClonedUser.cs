namespace PureCloud.Client.Models;

public sealed class TokenInfoClonedUser
{
    /// <summary>
    /// User id of the original native user
    /// </summary>
    /// <value>User id of the original native user</value>
    public string Id { get; set; }

    /// <summary>
    /// Organization of the original native user
    /// </summary>
    /// <value>Organization of the original native user</value>
    public Entity Organization { get; set; }
}
