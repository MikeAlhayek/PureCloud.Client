using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BatchUserPresenceEventRequest
{
    /// <summary>
    /// UserPresence events for this batch
    /// </summary>
    /// <value>UserPresence events for this batch</value>
    public IEnumerable<UserPresenceEvent> UserPresenceEvents { get; set; }
}
