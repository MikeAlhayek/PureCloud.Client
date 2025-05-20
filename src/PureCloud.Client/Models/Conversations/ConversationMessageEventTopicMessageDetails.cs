using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationMessageEventTopicMessageDetails
{
    /// <summary>
    /// Gets or Sets MessageStatus
    /// </summary>
    public ConversationMessageEventTopicMessageDetailsMessageStatusEnum? MessageStatus { get; set; }

    /// <summary>
    /// Gets or Sets SocialVisibility
    /// </summary>
    public ConversationMessageEventTopicMessageDetailsSocialVisibilityEnum? SocialVisibility { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public ConversationMessageEventTopicUriReference Message { get; set; }

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
    public IEnumerable<ConversationMessageEventTopicMessageMedia> Media { get; set; }

    /// <summary>
    /// Gets or Sets Stickers
    /// </summary>
    public IEnumerable<ConversationMessageEventTopicMessageSticker> Stickers { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public ConversationMessageEventTopicErrorDetails ErrorInfo { get; set; }

    /// <summary>
    /// Gets or Sets MessageMetadata
    /// </summary>
    public ConversationMessageEventTopicMessageMetadata MessageMetadata { get; set; }
}
