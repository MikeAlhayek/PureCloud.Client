using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// Presence from a given source for a user
/// </summary>
public sealed class UcUserPresence
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// User ID of the associated Genesys Cloud user.
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Deprecated - The sourceID field should be used as a replacement.
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// The registered source ID from where the presence was set
    /// </summary>
    public string SourceId { get; set; }

    /// <summary>
    /// Gets or Sets PresenceDefinition
    /// </summary>
    public PresenceDefinition PresenceDefinition { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}
