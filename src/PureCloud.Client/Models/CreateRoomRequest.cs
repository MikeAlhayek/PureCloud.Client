using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateRoomRequest
{
    /// <summary>
    /// Room&#39;s description
    /// </summary>
    /// <value>Room&#39;s description</value>
    public string Description { get; set; }

    /// <summary>
    /// Room&#39;s subject
    /// </summary>
    /// <value>Room&#39;s subject</value>
    public string Subject { get; set; }

    /// <summary>
    /// Users to add to the room
    /// </summary>
    /// <value>Users to add to the room</value>
    public IEnumerable<string> UserIds { get; set; }
}
