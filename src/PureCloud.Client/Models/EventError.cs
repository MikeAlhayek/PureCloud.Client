using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EventError
{
    /// <summary>
    /// The eventId (V4 UUID) for the event that encountered an error.
    /// </summary>
    /// <value>The eventId (V4 UUID) for the event that encountered an error.</value>
    public string EventId { get; set; }

    /// <summary>
    /// A message describing the error.
    /// </summary>
    /// <value>A message describing the error.</value>
    public string Message { get; set; }

    /// <summary>
    /// The event for this eventId can be resubmitted if this value is true.
    /// </summary>
    /// <value>The event for this eventId can be resubmitted if this value is true.</value>
    public bool? Retryable { get; set; }
}
