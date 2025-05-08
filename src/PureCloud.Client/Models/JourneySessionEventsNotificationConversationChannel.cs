using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneySessionEventsNotificationConversationChannel
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public JourneySessionEventsNotificationConversationChannelTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    public JourneySessionEventsNotificationConversationChannelMessageTypeEnum? MessageType { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    public string Platform { get; set; }
}
