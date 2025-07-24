using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingMessagingMessage
/// </summary>
public sealed class RecordingMessagingMessage
{
    /// <summary>
    /// Indicates the content type for this message
    /// </summary>
    /// <value>Indicates the content type for this message</value>
    public RecordingMessagingMessageContentType? ContentType { get; set; }

    /// <summary>
    /// The message sender session id.
    /// </summary>
    /// <value>The message sender session id.</value>
    public string From { get; set; }

    /// <summary>
    /// The user who sent this message.
    /// </summary>
    /// <value>The user who sent this message.</value>
    public User FromUser { get; set; }

    /// <summary>
    /// The PureCloudEnvironment external contact sender details.
    /// </summary>
    /// <value>The PureCloudEnvironment external contact sender details.</value>
    public ExternalContact FromExternalContact { get; set; }

    /// <summary>
    /// The message recipient.
    /// </summary>
    /// <value>The message recipient.</value>
    public string To { get; set; }

    /// <summary>
    /// The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// A well known string that specifies the purpose or type of the participant on this communication.
    /// </summary>
    /// <value>A well known string that specifies the purpose or type of the participant on this communication.</value>
    public string Purpose { get; set; }

    /// <summary>
    /// A globally unique identifier for the participant on this communication.
    /// </summary>
    /// <value>A globally unique identifier for the participant on this communication.</value>
    public string ParticipantId { get; set; }

    /// <summary>
    /// A globally unique identifier for the queue involved in this communication.
    /// </summary>
    /// <value>A globally unique identifier for the queue involved in this communication.</value>
    public AddressableEntityRef Queue { get; set; }

    /// <summary>
    /// A globally unique identifier for the workflow involved in this communication.
    /// </summary>
    /// <value>A globally unique identifier for the workflow involved in this communication.</value>
    public AddressableEntityRef Workflow { get; set; }

    /// The content of this message.
    /// </summary>
    /// <value>The content of this message.</value>
    public string MessageText { get; set; }

    /// <summary>
    /// List of media objects attached  with this message.
    /// </summary>
    /// <value>List of media objects attached  with this message.</value>
    public IEnumerable<MessageMediaAttachment> MessageMediaAttachments { get; set; }

    /// <summary>
    /// List of message stickers attached with this message.
    /// </summary>
    /// <value>List of message stickers attached with this message.</value>
    public IEnumerable<MessageStickerAttachment> MessageStickerAttachments { get; set; }

    /// <summary>
    /// List of quick reply options offered with this message.
    /// </summary>
    /// <value>List of quick reply options offered with this message.</value>
    public IEnumerable<QuickReply> QuickReplies { get; set; }

    /// <summary>
    /// Button Response selected by user for this message.
    /// </summary>
    /// <value>Button Response selected by user for this message.</value>
    public ButtonResponse ButtonResponse { get; set; }

    /// <summary>
    /// Ephemeral story content.
    /// </summary>
    /// <value>Ephemeral story content.</value>
    public RecordingContentStory Story { get; set; }

    /// <summary>
    /// List of cards offered for this message
    /// </summary>
    /// <value>List of cards offered for this message</value>
    public IEnumerable<Card> Cards { get; set; }

    /// <summary>
    /// Template notification content.
    /// </summary>
    /// <value>Template notification content.</value>
    public RecordingNotificationTemplate NotificationTemplate { get; set; }

    /// <summary>
    /// List of event elements
    /// </summary>
    /// <value>List of event elements</value>
    public IEnumerable<ConversationMessageEvent> Events { get; set; }
}
