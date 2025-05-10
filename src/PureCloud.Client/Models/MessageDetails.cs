namespace PureCloud.Client.Models;

public sealed class MessageDetails
{
    /// <summary>
    /// Indicates the delivery status of the message.
    /// </summary>
    /// <value>Indicates the delivery status of the message.</value>
    public MessageDetailsStatus? MessageStatus { get; set; }

    /// <summary>
    /// For social media messages, the visibility of the message in the originating social platform
    /// </summary>
    /// <value>For social media messages, the visibility of the message in the originating social platform</value>
    public MessageDetailsSocialVisibility? SocialVisibility { get; set; }

    /// <summary>
    /// UUID identifying the message media.
    /// </summary>
    /// <value>UUID identifying the message media.</value>
    public string MessageId { get; set; }

    /// <summary>
    /// A URI for this message entity.
    /// </summary>
    /// <value>A URI for this message entity.</value>
    public string MessageURI { get; set; }

    /// <summary>
    /// The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.
    /// </summary>
    /// <value>The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.</value>
    public int? MessageSegmentCount { get; set; }

    /// <summary>
    /// The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? MessageTime { get; set; }

    /// <summary>
    /// The media (images, files, etc) associated with this message, if any
    /// </summary>
    /// <value>The media (images, files, etc) associated with this message, if any</value>
    public IEnumerable<MessageMedia> Media { get; set; }

    /// <summary>
    /// One or more stickers associated with this message, if any
    /// </summary>
    /// <value>One or more stickers associated with this message, if any</value>
    public IEnumerable<MessageSticker> Stickers { get; set; }

    /// <summary>
    /// Information that describes the content of the message, if any
    /// </summary>
    /// <value>Information that describes the content of the message, if any</value>
    public ConversationMessageMetadata MessageMetadata { get; set; }

    /// <summary>
    /// Provider specific error information for a communication.
    /// </summary>
    /// <value>Provider specific error information for a communication.</value>
    public ErrorBody ErrorInfo { get; set; }
}
