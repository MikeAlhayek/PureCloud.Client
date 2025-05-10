using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Models;

public sealed class PresenceEventUserPresence
{
    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Gets or Sets PresenceDefinition
    /// </summary>
    public PresenceEventOrganizationPresence PresenceDefinition { get; set; }

    /// <summary>
    /// Gets or Sets Primary
    /// </summary>
    public bool? Primary { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    public DateTime? ModifiedDate { get; set; }
}
