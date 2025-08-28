using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// MutableUserPresence
/// </summary>
public sealed class MutableUserPresence
{
    /// <summary>
    /// The user's id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Deprecated - The sourceID field should be used as a replacement.
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Represents the ID of a registered source
    /// </summary>
    public string SourceId { get; set; }

    /// <summary>
    /// A boolean used to tell whether or not to set this presence source as the primary on a PATCH
    /// </summary>
    public bool? Primary { get; set; }

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
