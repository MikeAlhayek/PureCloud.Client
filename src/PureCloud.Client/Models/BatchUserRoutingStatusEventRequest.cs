using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BatchUserRoutingStatusEventRequest
{
    /// <summary>
    /// UserRoutingStatus events for this batch
    /// </summary>
    /// <value>UserRoutingStatus events for this batch</value>
    public IEnumerable<UserRoutingStatusEvent> UserRoutingStatusEvents { get; set; }
}
