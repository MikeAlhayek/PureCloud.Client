using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Message content element. If contentType &#x3D; \&quot;Attachment\&quot; only one item is allowed.
/// </summary>

public partial class MessageContent : IEquatable<MessageContent>
{
    /// <summary>
    /// Type of this content element.
    /// </summary>
    /// <value>Type of this content element.</value>
    
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
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

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
        /// Enum Text for "Text"
        /// </summary>
        [EnumMember(Value = "Text")]
        Text,

        /// <summary>
        /// Enum Quickreplyv2 for "QuickReplyV2"
        /// </summary>
        [EnumMember(Value = "QuickReplyV2")]
        Quickreplyv2,

        /// <summary>
        /// Enum Datepicker for "DatePicker"
        /// </summary>
        [EnumMember(Value = "DatePicker")]
        Datepicker
    }
    /// <summary>
    /// Type of this content element.
    /// </summary>
    /// <value>Type of this content element.</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MessageContent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessageContent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageContent" /> class.
    /// </summary>
    /// <param name="ContentType">Type of this content element. (required).</param>
    /// <param name="Attachment">Attachment content..</param>
    /// <param name="QuickReply">Quick reply content..</param>
    /// <param name="ButtonResponse">Button response content..</param>
    /// <param name="Generic">Generic content (Deprecated)..</param>
    /// <param name="List">List content (Deprecated)..</param>
    /// <param name="Template">Template notification content..</param>
    /// <param name="Reactions">A set of reactions to a message..</param>
    /// <param name="Mention">Mention content..</param>
    /// <param name="Postback">Structured message postback (Deprecated)..</param>
    /// <param name="Story">Ephemeral story content..</param>
    /// <param name="Card">Card content.</param>
    /// <param name="Carousel">Carousel content.</param>
    /// <param name="Text">Text content..</param>
    /// <param name="QuickReplyV2">Quick reply V2 content..</param>
    /// <param name="DatePicker">DatePicker content..</param>
    /// <param name="Location">Location content..</param>
    public MessageContent(ContentTypeEnum? ContentType = null, ContentAttachment Attachment = null, ContentQuickReply QuickReply = null, ContentButtonResponse ButtonResponse = null, ContentGeneric Generic = null, ContentList List = null, ContentNotificationTemplate Template = null, List<ContentReaction> Reactions = null, MessagingRecipient Mention = null, ContentPostback Postback = null, ContentStory Story = null, ContentCard Card = null, ContentCarousel Carousel = null, ContentText Text = null, ContentQuickReplyV2 QuickReplyV2 = null, ContentDatePicker DatePicker = null, ContentLocation Location = null)
    {
        this.ContentType = ContentType;
        this.Attachment = Attachment;
        this.QuickReply = QuickReply;
        this.ButtonResponse = ButtonResponse;
        this.Generic = Generic;
        this.List = List;
        this.Template = Template;
        this.Reactions = Reactions;
        this.Mention = Mention;
        this.Postback = Postback;
        this.Story = Story;
        this.Card = Card;
        this.Carousel = Carousel;
        this.Text = Text;
        this.QuickReplyV2 = QuickReplyV2;
        this.DatePicker = DatePicker;
        this.Location = Location;

    }





    /// <summary>
    /// Attachment content.
    /// </summary>
    /// <value>Attachment content.</value>
    [JsonPropertyName("attachment")]
    public ContentAttachment Attachment { get; set; }



    /// <summary>
    /// Quick reply content.
    /// </summary>
    /// <value>Quick reply content.</value>
    [JsonPropertyName("quickReply")]
    public ContentQuickReply QuickReply { get; set; }



    /// <summary>
    /// Button response content.
    /// </summary>
    /// <value>Button response content.</value>
    [JsonPropertyName("buttonResponse")]
    public ContentButtonResponse ButtonResponse { get; set; }



    /// <summary>
    /// Generic content (Deprecated).
    /// </summary>
    /// <value>Generic content (Deprecated).</value>
    [JsonPropertyName("generic")]
    public ContentGeneric Generic { get; set; }



    /// <summary>
    /// List content (Deprecated).
    /// </summary>
    /// <value>List content (Deprecated).</value>
    [JsonPropertyName("list")]
    public ContentList List { get; set; }



    /// <summary>
    /// Template notification content.
    /// </summary>
    /// <value>Template notification content.</value>
    [JsonPropertyName("template")]
    public ContentNotificationTemplate Template { get; set; }



    /// <summary>
    /// A set of reactions to a message.
    /// </summary>
    /// <value>A set of reactions to a message.</value>
    [JsonPropertyName("reactions")]
    public List<ContentReaction> Reactions { get; set; }



    /// <summary>
    /// Mention content.
    /// </summary>
    /// <value>Mention content.</value>
    [JsonPropertyName("mention")]
    public MessagingRecipient Mention { get; set; }



    /// <summary>
    /// Structured message postback (Deprecated).
    /// </summary>
    /// <value>Structured message postback (Deprecated).</value>
    [JsonPropertyName("postback")]
    public ContentPostback Postback { get; set; }



    /// <summary>
    /// Ephemeral story content.
    /// </summary>
    /// <value>Ephemeral story content.</value>
    [JsonPropertyName("story")]
    public ContentStory Story { get; set; }



    /// <summary>
    /// Card content
    /// </summary>
    /// <value>Card content</value>
    [JsonPropertyName("card")]
    public ContentCard Card { get; set; }



    /// <summary>
    /// Carousel content
    /// </summary>
    /// <value>Carousel content</value>
    [JsonPropertyName("carousel")]
    public ContentCarousel Carousel { get; set; }



    /// <summary>
    /// Text content.
    /// </summary>
    /// <value>Text content.</value>
    [JsonPropertyName("text")]
    public ContentText Text { get; set; }



    /// <summary>
    /// Quick reply V2 content.
    /// </summary>
    /// <value>Quick reply V2 content.</value>
    [JsonPropertyName("quickReplyV2")]
    public ContentQuickReplyV2 QuickReplyV2 { get; set; }



    /// <summary>
    /// DatePicker content.
    /// </summary>
    /// <value>DatePicker content.</value>
    [JsonPropertyName("datePicker")]
    public ContentDatePicker DatePicker { get; set; }



    /// <summary>
    /// Location content.
    /// </summary>
    /// <value>Location content.</value>
    [JsonPropertyName("location")]
    public ContentLocation Location { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessageContent {\n");

        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  Attachment: ").Append(Attachment).Append("\n");
        sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
        sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
        sb.Append("  Generic: ").Append(Generic).Append("\n");
        sb.Append("  List: ").Append(List).Append("\n");
        sb.Append("  Template: ").Append(Template).Append("\n");
        sb.Append("  Reactions: ").Append(Reactions).Append("\n");
        sb.Append("  Mention: ").Append(Mention).Append("\n");
        sb.Append("  Postback: ").Append(Postback).Append("\n");
        sb.Append("  Story: ").Append(Story).Append("\n");
        sb.Append("  Card: ").Append(Card).Append("\n");
        sb.Append("  Carousel: ").Append(Carousel).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  QuickReplyV2: ").Append(QuickReplyV2).Append("\n");
        sb.Append("  DatePicker: ").Append(DatePicker).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
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
        return Equals(obj as MessageContent);
    }

    /// <summary>
    /// Returns true if MessageContent instances are equal
    /// </summary>
    /// <param name="other">Instance of MessageContent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessageContent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                Attachment == other.Attachment ||
                Attachment != null &&
                Attachment.Equals(other.Attachment)
            ) &&
            (
                QuickReply == other.QuickReply ||
                QuickReply != null &&
                QuickReply.Equals(other.QuickReply)
            ) &&
            (
                ButtonResponse == other.ButtonResponse ||
                ButtonResponse != null &&
                ButtonResponse.Equals(other.ButtonResponse)
            ) &&
            (
                Generic == other.Generic ||
                Generic != null &&
                Generic.Equals(other.Generic)
            ) &&
            (
                List == other.List ||
                List != null &&
                List.Equals(other.List)
            ) &&
            (
                Template == other.Template ||
                Template != null &&
                Template.Equals(other.Template)
            ) &&
            (
                Reactions == other.Reactions ||
                Reactions != null &&
                Reactions.SequenceEqual(other.Reactions)
            ) &&
            (
                Mention == other.Mention ||
                Mention != null &&
                Mention.Equals(other.Mention)
            ) &&
            (
                Postback == other.Postback ||
                Postback != null &&
                Postback.Equals(other.Postback)
            ) &&
            (
                Story == other.Story ||
                Story != null &&
                Story.Equals(other.Story)
            ) &&
            (
                Card == other.Card ||
                Card != null &&
                Card.Equals(other.Card)
            ) &&
            (
                Carousel == other.Carousel ||
                Carousel != null &&
                Carousel.Equals(other.Carousel)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                QuickReplyV2 == other.QuickReplyV2 ||
                QuickReplyV2 != null &&
                QuickReplyV2.Equals(other.QuickReplyV2)
            ) &&
            (
                DatePicker == other.DatePicker ||
                DatePicker != null &&
                DatePicker.Equals(other.DatePicker)
            ) &&
            (
                Location == other.Location ||
                Location != null &&
                Location.Equals(other.Location)
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
            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (Attachment != null)
            {
                hash = hash * 59 + Attachment.GetHashCode();
            }

            if (QuickReply != null)
            {
                hash = hash * 59 + QuickReply.GetHashCode();
            }

            if (ButtonResponse != null)
            {
                hash = hash * 59 + ButtonResponse.GetHashCode();
            }

            if (Generic != null)
            {
                hash = hash * 59 + Generic.GetHashCode();
            }

            if (List != null)
            {
                hash = hash * 59 + List.GetHashCode();
            }

            if (Template != null)
            {
                hash = hash * 59 + Template.GetHashCode();
            }

            if (Reactions != null)
            {
                hash = hash * 59 + Reactions.GetHashCode();
            }

            if (Mention != null)
            {
                hash = hash * 59 + Mention.GetHashCode();
            }

            if (Postback != null)
            {
                hash = hash * 59 + Postback.GetHashCode();
            }

            if (Story != null)
            {
                hash = hash * 59 + Story.GetHashCode();
            }

            if (Card != null)
            {
                hash = hash * 59 + Card.GetHashCode();
            }

            if (Carousel != null)
            {
                hash = hash * 59 + Carousel.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (QuickReplyV2 != null)
            {
                hash = hash * 59 + QuickReplyV2.GetHashCode();
            }

            if (DatePicker != null)
            {
                hash = hash * 59 + DatePicker.GetHashCode();
            }

            if (Location != null)
            {
                hash = hash * 59 + Location.GetHashCode();
            }

            return hash;
        }
    }
}
