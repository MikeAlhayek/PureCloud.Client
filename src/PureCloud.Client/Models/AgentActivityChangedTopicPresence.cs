using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AgentActivityChangedTopicPresence
{
    /// <summary>
    /// Gets or Sets PresenceDefinition
    /// </summary>
    public AgentActivityChangedTopicOrganizationPresence PresenceDefinition { get; set; }

    /// <summary>
    /// Gets or Sets PresenceMessage
    /// </summary>
    public string PresenceMessage { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    public DateTime? ModifiedDate { get; set; }
}
