using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BatchEventResponse
{
    /// <summary>
    /// A list of validation or server errors that occurred for posted events.
    /// </summary>
    /// <value>A list of validation or server errors that occurred for posted events.</value>
    public IEnumerable<EventError> Errors { get; set; }
}
