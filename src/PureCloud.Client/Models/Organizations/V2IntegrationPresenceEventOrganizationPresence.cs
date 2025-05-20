using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2IntegrationPresenceEventOrganizationPresence
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    public string SystemPresence { get; set; }
}
