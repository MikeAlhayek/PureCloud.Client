using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SessionLastEvent
{
    /// <summary>
    /// The ID of the last event.
    /// </summary>
    /// <value>The ID of the last event.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the event.
    /// </summary>
    /// <value>The name of the event.</value>
    public string EventName { get; set; }

    /// <summary>
    /// Timestamp indicating when the event was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the event was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreatedDate { get; set; }
}
