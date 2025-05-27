using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Room
{
    /// <summary>
    /// The type of room
    /// </summary>
    /// <value>The type of room</value>
    public RoomRoomTypeEnum? RoomType { get; set; }

    /// <summary>
    /// The jid of the room if adhoc, the id of the group for group rooms
    /// </summary>
    /// <value>The jid of the room if adhoc, the id of the group for group rooms</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Room&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Room&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

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
    /// Room&#39;s size limit
    /// </summary>
    /// <value>Room&#39;s size limit</value>
    public int? ParticipantLimit { get; set; }

    /// <summary>
    /// Room&#39;s owners
    /// </summary>
    /// <value>Room&#39;s owners</value>
    public IEnumerable<UserReference> Owners { get; set; }

    /// <summary>
    /// Room&#39;s pinned messages
    /// </summary>
    /// <value>Room&#39;s pinned messages</value>
    public IEnumerable<AddressableEntityRef> PinnedMessages { get; set; }

    /// <summary>
    /// The jid of the room
    /// </summary>
    /// <value>The jid of the room</value>
    public string Jid { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
