namespace PureCloud.Client.Models.Users;

/// <summary>
/// PresenceDefinition
/// </summary>

public sealed class PresenceDefinition
{
    /// <summary>
    /// description
    /// </summary>
    /// <value>description</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    public string SystemPresence { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
