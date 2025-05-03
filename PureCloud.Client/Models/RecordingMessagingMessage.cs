using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingMessagingMessage
/// </summary>

public partial class RecordingMessagingMessage : IEquatable<RecordingMessagingMessage>
{
    /// <summary>
    /// Indicates the content type for this message
    /// </summary>
    /// <value>Indicates the content type for this message</value>
    
    public enum ContentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

        /// <summary>
        /// Enum Story for "Story"
        /// </summary>
        [EnumMember(Value = "Story")]
        Story,

        /// <summary>
        /// Enum Card for "Card"
        /// </summary>
        [EnumMember(Value = "Card")]
        Card,

        /// <summary>
        /// Enum Carousel for "Carousel"
        /// </summary>
        [EnumMember(Value = "Carousel")]
        Carousel,

        /// <summary>
        /// Enum Attachment for "Attachment"
        /// </summary>
        [EnumMember(Value = "Attachment")]
        Attachment,

        /// <summary>
        /// Enum Location for "Location"
        /// </summary>
        [EnumMember(Value = "Location")]
        Location,

        /// <summary>
        /// Enum Notification for "Notification"
        /// </summary>
        [EnumMember(Value = "Notification")]
        Notification,

        /// <summary>
        /// Enum Generictemplate for "GenericTemplate"
        /// </summary>
        [EnumMember(Value = "GenericTemplate")]
        Generictemplate,

        /// <summary>
        /// Enum Listtemplate for "ListTemplate"
        /// </summary>
        [EnumMember(Value = "ListTemplate")]
        Listtemplate,

        /// <summary>
        /// Enum Postback for "Postback"
        /// </summary>
        [EnumMember(Value = "Postback")]
        Postback,

        /// <summary>
        /// Enum Reactions for "Reactions"
        /// </summary>
        [EnumMember(Value = "Reactions")]
        Reactions,

        /// <summary>
        /// Enum Mention for "Mention"
        /// </summary>
        [EnumMember(Value = "Mention")]
        Mention,

        /// <summary>
        /// Enum Buttonresponse for "ButtonResponse"
        /// </summary>
        [EnumMember(Value = "ButtonResponse")]
        Buttonresponse,

        /// <summary>
        /// Enum Datepicker for "DatePicker"
        /// </summary>
        [EnumMember(Value = "DatePicker")]
        Datepicker
    }
    /// <summary>
    /// Indicates the content type for this message
    /// </summary>
    /// <value>Indicates the content type for this message</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingMessagingMessage" /> class.
    /// </summary>
    /// <param name="From">The message sender session id..</param>
    /// <param name="FromUser">The user who sent this message..</param>
    /// <param name="FromExternalContact">The PureCloudEnvironment external contact sender details..</param>
    /// <param name="To">The message recipient..</param>
    /// <param name="Timestamp">The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="Purpose">A well known string that specifies the purpose or type of the participant on this communication..</param>
    /// <param name="ParticipantId">A globally unique identifier for the participant on this communication..</param>
    /// <param name="Queue">A globally unique identifier for the queue involved in this communication..</param>
    /// <param name="Workflow">A globally unique identifier for the workflow involved in this communication..</param>
    /// <param name="MessageText">The content of this message..</param>
    /// <param name="MessageMediaAttachments">List of media objects attached  with this message..</param>
    /// <param name="MessageStickerAttachments">List of message stickers attached with this message..</param>
    /// <param name="QuickReplies">List of quick reply options offered with this message..</param>
    /// <param name="ButtonResponse">Button Response selected by user for this message..</param>
    /// <param name="Story">Ephemeral story content..</param>
    /// <param name="Cards">List of cards offered for this message.</param>
    /// <param name="NotificationTemplate">Template notification content..</param>
    /// <param name="ContentType">Indicates the content type for this message.</param>
    /// <param name="Events">List of event elements.</param>
    public RecordingMessagingMessage(string From = null, User FromUser = null, ExternalContact FromExternalContact = null, string To = null, DateTime? Timestamp = null, string Id = null, string Purpose = null, string ParticipantId = null, AddressableEntityRef Queue = null, AddressableEntityRef Workflow = null, string MessageText = null, List<MessageMediaAttachment> MessageMediaAttachments = null, List<MessageStickerAttachment> MessageStickerAttachments = null, List<QuickReply> QuickReplies = null, ButtonResponse ButtonResponse = null, RecordingContentStory Story = null, List<Card> Cards = null, RecordingNotificationTemplate NotificationTemplate = null, ContentTypeEnum? ContentType = null, List<ConversationMessageEvent> Events = null)
    {
        this.From = From;
        this.FromUser = FromUser;
        this.FromExternalContact = FromExternalContact;
        this.To = To;
        this.Timestamp = Timestamp;
        this.Id = Id;
        this.Purpose = Purpose;
        this.ParticipantId = ParticipantId;
        this.Queue = Queue;
        this.Workflow = Workflow;
        this.MessageText = MessageText;
        this.MessageMediaAttachments = MessageMediaAttachments;
        this.MessageStickerAttachments = MessageStickerAttachments;
        this.QuickReplies = QuickReplies;
        this.ButtonResponse = ButtonResponse;
        this.Story = Story;
        this.Cards = Cards;
        this.NotificationTemplate = NotificationTemplate;
        this.ContentType = ContentType;
        this.Events = Events;

    }



    /// <summary>
    /// The message sender session id.
    /// </summary>
    /// <value>The message sender session id.</value>
    [JsonPropertyName("from")]
    public string From { get; set; }



    /// <summary>
    /// The user who sent this message.
    /// </summary>
    /// <value>The user who sent this message.</value>
    [JsonPropertyName("fromUser")]
    public User FromUser { get; set; }



    /// <summary>
    /// The PureCloudEnvironment external contact sender details.
    /// </summary>
    /// <value>The PureCloudEnvironment external contact sender details.</value>
    [JsonPropertyName("fromExternalContact")]
    public ExternalContact FromExternalContact { get; set; }



    /// <summary>
    /// The message recipient.
    /// </summary>
    /// <value>The message recipient.</value>
    [JsonPropertyName("to")]
    public string To { get; set; }



    /// <summary>
    /// The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }



    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// A well known string that specifies the purpose or type of the participant on this communication.
    /// </summary>
    /// <value>A well known string that specifies the purpose or type of the participant on this communication.</value>
    [JsonPropertyName("purpose")]
    public string Purpose { get; set; }



    /// <summary>
    /// A globally unique identifier for the participant on this communication.
    /// </summary>
    /// <value>A globally unique identifier for the participant on this communication.</value>
    [JsonPropertyName("participantId")]
    public string ParticipantId { get; set; }



    /// <summary>
    /// A globally unique identifier for the queue involved in this communication.
    /// </summary>
    /// <value>A globally unique identifier for the queue involved in this communication.</value>
    [JsonPropertyName("queue")]
    public AddressableEntityRef Queue { get; set; }



    /// <summary>
    /// A globally unique identifier for the workflow involved in this communication.
    /// </summary>
    /// <value>A globally unique identifier for the workflow involved in this communication.</value>
    [JsonPropertyName("workflow")]
    public AddressableEntityRef Workflow { get; set; }



    /// <summary>
    /// The content of this message.
    /// </summary>
    /// <value>The content of this message.</value>
    [JsonPropertyName("messageText")]
    public string MessageText { get; set; }



    /// <summary>
    /// List of media objects attached  with this message.
    /// </summary>
    /// <value>List of media objects attached  with this message.</value>
    [JsonPropertyName("messageMediaAttachments")]
    public List<MessageMediaAttachment> MessageMediaAttachments { get; set; }



    /// <summary>
    /// List of message stickers attached with this message.
    /// </summary>
    /// <value>List of message stickers attached with this message.</value>
    [JsonPropertyName("messageStickerAttachments")]
    public List<MessageStickerAttachment> MessageStickerAttachments { get; set; }



    /// <summary>
    /// List of quick reply options offered with this message.
    /// </summary>
    /// <value>List of quick reply options offered with this message.</value>
    [JsonPropertyName("quickReplies")]
    public List<QuickReply> QuickReplies { get; set; }



    /// <summary>
    /// Button Response selected by user for this message.
    /// </summary>
    /// <value>Button Response selected by user for this message.</value>
    [JsonPropertyName("buttonResponse")]
    public ButtonResponse ButtonResponse { get; set; }



    /// <summary>
    /// Ephemeral story content.
    /// </summary>
    /// <value>Ephemeral story content.</value>
    [JsonPropertyName("story")]
    public RecordingContentStory Story { get; set; }



    /// <summary>
    /// List of cards offered for this message
    /// </summary>
    /// <value>List of cards offered for this message</value>
    [JsonPropertyName("cards")]
    public List<Card> Cards { get; set; }



    /// <summary>
    /// Template notification content.
    /// </summary>
    /// <value>Template notification content.</value>
    [JsonPropertyName("notificationTemplate")]
    public RecordingNotificationTemplate NotificationTemplate { get; set; }





    /// <summary>
    /// List of event elements
    /// </summary>
    /// <value>List of event elements</value>
    [JsonPropertyName("events")]
    public List<ConversationMessageEvent> Events { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingMessagingMessage {\n");

        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  FromUser: ").Append(FromUser).Append("\n");
        sb.Append("  FromExternalContact: ").Append(FromExternalContact).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Purpose: ").Append(Purpose).Append("\n");
        sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Workflow: ").Append(Workflow).Append("\n");
        sb.Append("  MessageText: ").Append(MessageText).Append("\n");
        sb.Append("  MessageMediaAttachments: ").Append(MessageMediaAttachments).Append("\n");
        sb.Append("  MessageStickerAttachments: ").Append(MessageStickerAttachments).Append("\n");
        sb.Append("  QuickReplies: ").Append(QuickReplies).Append("\n");
        sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
        sb.Append("  Story: ").Append(Story).Append("\n");
        sb.Append("  Cards: ").Append(Cards).Append("\n");
        sb.Append("  NotificationTemplate: ").Append(NotificationTemplate).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  Events: ").Append(Events).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as RecordingMessagingMessage);
    }

    /// <summary>
    /// Returns true if RecordingMessagingMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingMessagingMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingMessagingMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                From == other.From ||
                From != null &&
                From.Equals(other.From)
            ) &&
            (
                FromUser == other.FromUser ||
                FromUser != null &&
                FromUser.Equals(other.FromUser)
            ) &&
            (
                FromExternalContact == other.FromExternalContact ||
                FromExternalContact != null &&
                FromExternalContact.Equals(other.FromExternalContact)
            ) &&
            (
                To == other.To ||
                To != null &&
                To.Equals(other.To)
            ) &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Purpose == other.Purpose ||
                Purpose != null &&
                Purpose.Equals(other.Purpose)
            ) &&
            (
                ParticipantId == other.ParticipantId ||
                ParticipantId != null &&
                ParticipantId.Equals(other.ParticipantId)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Workflow == other.Workflow ||
                Workflow != null &&
                Workflow.Equals(other.Workflow)
            ) &&
            (
                MessageText == other.MessageText ||
                MessageText != null &&
                MessageText.Equals(other.MessageText)
            ) &&
            (
                MessageMediaAttachments == other.MessageMediaAttachments ||
                MessageMediaAttachments != null &&
                MessageMediaAttachments.SequenceEqual(other.MessageMediaAttachments)
            ) &&
            (
                MessageStickerAttachments == other.MessageStickerAttachments ||
                MessageStickerAttachments != null &&
                MessageStickerAttachments.SequenceEqual(other.MessageStickerAttachments)
            ) &&
            (
                QuickReplies == other.QuickReplies ||
                QuickReplies != null &&
                QuickReplies.SequenceEqual(other.QuickReplies)
            ) &&
            (
                ButtonResponse == other.ButtonResponse ||
                ButtonResponse != null &&
                ButtonResponse.Equals(other.ButtonResponse)
            ) &&
            (
                Story == other.Story ||
                Story != null &&
                Story.Equals(other.Story)
            ) &&
            (
                Cards == other.Cards ||
                Cards != null &&
                Cards.SequenceEqual(other.Cards)
            ) &&
            (
                NotificationTemplate == other.NotificationTemplate ||
                NotificationTemplate != null &&
                NotificationTemplate.Equals(other.NotificationTemplate)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                Events == other.Events ||
                Events != null &&
                Events.SequenceEqual(other.Events)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (From != null)
            {
                hash = hash * 59 + From.GetHashCode();
            }

            if (FromUser != null)
            {
                hash = hash * 59 + FromUser.GetHashCode();
            }

            if (FromExternalContact != null)
            {
                hash = hash * 59 + FromExternalContact.GetHashCode();
            }

            if (To != null)
            {
                hash = hash * 59 + To.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Purpose != null)
            {
                hash = hash * 59 + Purpose.GetHashCode();
            }

            if (ParticipantId != null)
            {
                hash = hash * 59 + ParticipantId.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Workflow != null)
            {
                hash = hash * 59 + Workflow.GetHashCode();
            }

            if (MessageText != null)
            {
                hash = hash * 59 + MessageText.GetHashCode();
            }

            if (MessageMediaAttachments != null)
            {
                hash = hash * 59 + MessageMediaAttachments.GetHashCode();
            }

            if (MessageStickerAttachments != null)
            {
                hash = hash * 59 + MessageStickerAttachments.GetHashCode();
            }

            if (QuickReplies != null)
            {
                hash = hash * 59 + QuickReplies.GetHashCode();
            }

            if (ButtonResponse != null)
            {
                hash = hash * 59 + ButtonResponse.GetHashCode();
            }

            if (Story != null)
            {
                hash = hash * 59 + Story.GetHashCode();
            }

            if (Cards != null)
            {
                hash = hash * 59 + Cards.GetHashCode();
            }

            if (NotificationTemplate != null)
            {
                hash = hash * 59 + NotificationTemplate.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (Events != null)
            {
                hash = hash * 59 + Events.GetHashCode();
            }

            return hash;
        }
    }
}
