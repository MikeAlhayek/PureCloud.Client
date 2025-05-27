using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class ChatItem
{
    /// <summary>
    /// The type of chat
    /// </summary>
    /// <value>The type of chat</value>
    public ChatItemChatTypeEnum? ChatType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// If the chat is open
    /// </summary>
    /// <value>If the chat is open</value>
    public bool? Open { get; set; }

    /// <summary>
    /// The favorite entity for the chat, only appears if the chat is favorited
    /// </summary>
    /// <value>The favorite entity for the chat, only appears if the chat is favorited</value>
    public ChatFavorite Favorite { get; set; }

    /// <summary>
    /// Avatar images for the chat
    /// </summary>
    /// <value>Avatar images for the chat</value>
    public IEnumerable<Image> Images { get; set; }

    /// <summary>
    /// The date of the last message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateLastMessage { get; set; }

    /// <summary>
    /// The date the chat was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the chat was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateClosed { get; set; }

    /// <summary>
    /// The other 1on1 user
    /// </summary>
    /// <value>The other 1on1 user</value>
    public ChatUserRef User { get; set; }

    /// <summary>
    /// The room of the chat
    /// </summary>
    /// <value>The room of the chat</value>
    public Room Room { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
