using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RoomParticipantsResponse
{
    /// <summary>
    /// list of room participants
    /// </summary>
    /// <value>list of room participants</value>
    public IEnumerable<RoomParticipantResponse> Participants { get; set; }
}
