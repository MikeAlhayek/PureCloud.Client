using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2IntegrationPresenceEventPresenceActivityEvent
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public V2IntegrationPresenceEventPresenceActivityEventEventTypeEnum? EventType { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Gets or Sets PresenceDefinition
    /// </summary>
    public V2IntegrationPresenceEventOrganizationPresence PresenceDefinition { get; set; }

    /// <summary>
    /// Gets or Sets Message
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets CurrentDisplaySourceId
    /// </summary>
    public Guid? CurrentDisplaySourceId { get; set; }

    /// <summary>
    /// Gets or Sets PreviousDisplaySourceId
    /// </summary>
    public Guid? PreviousDisplaySourceId { get; set; }
}
