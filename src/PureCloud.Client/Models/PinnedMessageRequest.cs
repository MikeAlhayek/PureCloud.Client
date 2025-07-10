using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PinnedMessageRequest
{
    /// <summary>
    /// Ids of the messages to pin
    /// </summary>
    /// <value>Ids of the messages to pin</value>
    public IEnumerable<string> PinnedMessageIds { get; set; }
}
