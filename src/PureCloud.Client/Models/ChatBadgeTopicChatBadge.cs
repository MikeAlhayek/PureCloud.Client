using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChatBadgeTopicChatBadge
{
    /// <summary>
    /// Gets or Sets Entity
    /// </summary>
    public ChatBadgeTopicBadgeEntity Entity { get; set; }

    /// <summary>
    /// Gets or Sets UnreadCount
    /// </summary>
    public long? UnreadCount { get; set; }

    /// <summary>
    /// Gets or Sets LastUnreadNotificationDate
    /// </summary>
    public DateTime? LastUnreadNotificationDate { get; set; }
}
