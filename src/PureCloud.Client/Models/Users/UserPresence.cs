using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserPresence
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Deprecated - The sourceID field should be used as a replacement.
    /// </summary>
    /// <value>Deprecated - The sourceID field should be used as a replacement.</value>
    public string Source { get; set; }

    /// <summary>
    /// Represents the ID of a registered source
    /// </summary>
    /// <value>Represents the ID of a registered source</value>
    public string SourceId { get; set; }

    /// <summary>
    /// A boolean used to tell whether or not to set this presence source as the primary on a PATCH
    /// </summary>
    /// <value>A boolean used to tell whether or not to set this presence source as the primary on a PATCH</value>
    public bool? Primary { get; set; }

    /// <summary>
    /// Gets or Sets PresenceDefinition
    /// </summary>
    public PresenceDefinition PresenceDefinition { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
