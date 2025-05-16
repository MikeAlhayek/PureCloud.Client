using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationSocialExpressionEventTopicMessageDetails
{
    /// <summary>
    /// Indicates the delivery status of the message.
    /// </summary>
    /// <value>Indicates the delivery status of the message.</value>
    public QueueConversationSocialExpressionEventTopicMessageDetailsMessageStatusEnum? MessageStatus { get; set; }

    /// <summary>
    /// For social media messages, the visibility of the message in the originating social platform
    /// </summary>
    /// <value>For social media messages, the visibility of the message in the originating social platform</value>
    public QueueConversationSocialExpressionEventTopicMessageDetailsSocialVisibilityEnum? SocialVisibility { get; set; }

    /// <summary>
    /// UUID identifying the message media.
    /// </summary>
    /// <value>UUID identifying the message media.</value>
    public string MessageId { get; set; }

    /// <summary>
    /// The time when the message was sent or received.
    /// </summary>
    /// <value>The time when the message was sent or received.</value>
    public DateTime? MessageTime { get; set; }

    /// <summary>
    /// The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.
    /// </summary>
    /// <value>The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.</value>
    public long? MessageSegmentCount { get; set; }

    /// <summary>
    /// The media (images, files, etc) associated with this message, if any
    /// </summary>
    /// <value>The media (images, files, etc) associated with this message, if any</value>
    public IEnumerable<QueueConversationSocialExpressionEventTopicMessageMedia> Media { get; set; }

    /// <summary>
    /// Detailed information about an error response.
    /// </summary>
    /// <value>Detailed information about an error response.</value>
    public QueueConversationSocialExpressionEventTopicErrorDetails ErrorInfo { get; set; }

    /// <summary>
    /// A list of stickers included in the message
    /// </summary>
    /// <value>A list of stickers included in the message</value>
    public IEnumerable<QueueConversationSocialExpressionEventTopicMessageSticker> Stickers { get; set; }

    /// <summary>
    /// Gets or Sets MessageMetadata
    /// </summary>
    public QueueConversationSocialExpressionEventTopicMessageMetadata MessageMetadata { get; set; }
}
