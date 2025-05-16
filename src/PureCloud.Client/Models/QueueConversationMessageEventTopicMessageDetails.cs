using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationMessageEventTopicMessageDetails
{
    /// <summary>
    /// Gets or Sets MessageStatus
    /// </summary>
    public QueueConversationMessageEventTopicMessageDetailsMessageStatusEnum? MessageStatus { get; set; }

    /// <summary>
    /// Gets or Sets SocialVisibility
    /// </summary>
    public QueueConversationMessageEventTopicMessageDetailsSocialVisibilityEnum? SocialVisibility { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public QueueConversationMessageEventTopicUriReference Message { get; set; }

    /// <summary>
    /// Gets or Sets MessageTime
    /// </summary>
    public DateTime? MessageTime { get; set; }

    /// <summary>
    /// Gets or Sets MessageSegmentCount
    /// </summary>
    public long? MessageSegmentCount { get; set; }

    /// <summary>
    /// Gets or Sets Media
    /// </summary>
    public IEnumerable<QueueConversationMessageEventTopicMessageMedia> Media { get; set; }

    /// <summary>
    /// Gets or Sets Stickers
    /// </summary>
    public IEnumerable<QueueConversationMessageEventTopicMessageSticker> Stickers { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public QueueConversationMessageEventTopicErrorDetails ErrorInfo { get; set; }

    /// <summary>
    /// Gets or Sets MessageMetadata
    /// </summary>
    public QueueConversationMessageEventTopicMessageMetadata MessageMetadata { get; set; }
}
