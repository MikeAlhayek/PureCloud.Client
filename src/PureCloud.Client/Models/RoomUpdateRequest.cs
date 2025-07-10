using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RoomUpdateRequest
{
    /// <summary>
    /// Room&#39;s description
    /// </summary>
    /// <value>Room&#39;s description</value
    public string Description { get; set; }

    /// <summary>
    /// Room&#39;s subject
    /// </summary>
    /// <value>Room&#39;s subject</value>
    public string Subject { get; set; }

    /// <summary>
    /// Room&#39;s pinned messages
    /// </summary>
    /// <value>Room&#39;s pinned messages</value>
    public IEnumerable<string> PinnedMessageIds { get; set; }

    /// <summary>
    /// Room&#39;s owners
    /// </summary>
    /// <value>Room&#39;s owners</value>
    public IEnumerable<string> OwnerIds { get; set; }
}
