using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RoomParticipantResponse
{
    /// <summary>
    /// jid of the participant
    /// </summary>
    /// <value>jid of the participant</value>
    public string Jid { get; set; }

    /// <summary>
    /// User id of the participant
    /// </summary>
    /// <value>User id of the participant</value>
    public AddressableEntityRef User { get; set; }
}
