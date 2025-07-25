namespace PureCloud.Client.Models;

public sealed class MessageContent
{
    /// <summary>
    /// Type of this content element.
    /// </summary>
    /// <value>Type of this content element.</value>
    public MessageContentContentTypeEnum? ContentType { get; set; }

    /// <summary>
    /// Attachment content.
    /// </summary>
    /// <value>Attachment content.</value>
    public ContentAttachment Attachment { get; set; }

    /// <summary>
    /// Quick reply content.
    /// </summary>
    /// <value>Quick reply content.</value>
    public ContentQuickReply QuickReply { get; set; }

    /// <summary>
    /// Button response content.
    /// </summary>
    /// <value>Button response content.</value>
    public ContentButtonResponse ButtonResponse { get; set; }

    /// <summary>
    /// Generic content (Deprecated).
    /// </summary>
    /// <value>Generic content (Deprecated).</value>
    public ContentGeneric Generic { get; set; }

    /// <summary>
    /// List content (Deprecated).
    /// </summary>
    /// <value>List content (Deprecated).</value>
    public ContentList List { get; set; }

    /// <summary>
    /// Template notification content.
    /// </summary>
    /// <value>Template notification content.</value>
    public ContentNotificationTemplate Template { get; set; }

    /// <summary>
    /// A set of reactions to a message.
    /// </summary>
    /// <value>A set of reactions to a message.</value>
    public IEnumerable<ContentReaction> Reactions { get; set; }

    /// <summary>
    /// Mention content.
    /// </summary>
    /// <value>Mention content.</value>
    public MessagingRecipient Mention { get; set; }

    /// <summary>
    /// Structured message postback (Deprecated).
    /// </summary>
    /// <value>Structured message postback (Deprecated).</value>
    public ContentPostback Postback { get; set; }

    /// <summary>
    /// Ephemeral story content.
    /// </summary>
    /// <value>Ephemeral story content.</value>
    public ContentStory Story { get; set; }

    /// <summary>
    /// Card content
    /// </summary>
    /// <value>Card content</value>
    public ContentCard Card { get; set; }

    /// <summary>
    /// Carousel content
    /// </summary>
    /// <value>Carousel content</value>
    public ContentCarousel Carousel { get; set; }

    /// <summary>
    /// Text content.
    /// </summary>
    /// <value>Text content.</value>
    public ContentText Text { get; set; }

    /// <summary>
    /// Quick reply V2 content.
    /// </summary>
    /// <value>Quick reply V2 content.</value>
    public ContentQuickReplyV2 QuickReplyV2 { get; set; }

    /// <summary>
    /// DatePicker content.
    /// </summary>
    /// <value>DatePicker content.</value>
    public ContentDatePicker DatePicker { get; set; }

    /// <summary>
    /// Location content.
    /// </summary>
    /// <value>Location content.</value>
    public ContentLocation Location { get; set; }
}
