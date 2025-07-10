using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateRoomResponse
{
    /// <summary>
    /// The jid of the room
    /// </summary>
    /// <value>The jid of the room</value>
    public string Jid { get; set; }
}
