using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Message content element. If contentType &#x3D; \&quot;Attachment\&quot; only one item is allowed.
/// </summary>

public partial class ConversationMessageContent : IEquatable<ConversationMessageContent>
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
        /// Enum Reactions for "Reactions"
        /// </summary>
        [EnumMember(Value = "Reactions")]
        Reactions,

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
        /// Enum Mention for "Mention"
        /// </summary>
        [EnumMember(Value = "Mention")]
        Mention,

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
        Datepicker,

        /// <summary>
        /// Enum Interactiveapplication for "InteractiveApplication"
        /// </summary>
        [EnumMember(Value = "InteractiveApplication")]
        Interactiveapplication,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Type of this content element.
    /// </summary>
    /// <value>Type of this content element.</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMessageContent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationMessageContent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMessageContent" /> class.
    /// </summary>
    /// <param name="ContentType">Type of this content element. (required).</param>
    /// <param name="Location">Location content..</param>
    /// <param name="Attachment">Attachment content..</param>
    /// <param name="QuickReply">Quick reply content..</param>
    /// <param name="ButtonResponse">Button response content..</param>
    /// <param name="Template">Template notification content..</param>
    /// <param name="Story">Ephemeral story content..</param>
    /// <param name="Card">Card content.</param>
    /// <param name="Carousel">Carousel content.</param>
    /// <param name="Text">Text content..</param>
    /// <param name="QuickReplyV2">Quick reply V2 content..</param>
    public ConversationMessageContent(ContentTypeEnum? ContentType = null, ConversationContentLocation Location = null, ConversationContentAttachment Attachment = null, ConversationContentQuickReply QuickReply = null, ConversationContentButtonResponse ButtonResponse = null, ConversationContentNotificationTemplate Template = null, ConversationContentStory Story = null, ConversationContentCard Card = null, ConversationContentCarousel Carousel = null, ConversationContentText Text = null, ConversationContentQuickReplyV2 QuickReplyV2 = null)
    {
        this.ContentType = ContentType;
        this.Location = Location;
        this.Attachment = Attachment;
        this.QuickReply = QuickReply;
        this.ButtonResponse = ButtonResponse;
        this.Template = Template;
        this.Story = Story;
        this.Card = Card;
        this.Carousel = Carousel;
        this.Text = Text;
        this.QuickReplyV2 = QuickReplyV2;

    }





    /// <summary>
    /// Location content.
    /// </summary>
    /// <value>Location content.</value>
    [JsonPropertyName("location")]
    public ConversationContentLocation Location { get; set; }



    /// <summary>
    /// Attachment content.
    /// </summary>
    /// <value>Attachment content.</value>
    [JsonPropertyName("attachment")]
    public ConversationContentAttachment Attachment { get; set; }



    /// <summary>
    /// Quick reply content.
    /// </summary>
    /// <value>Quick reply content.</value>
    [JsonPropertyName("quickReply")]
    public ConversationContentQuickReply QuickReply { get; set; }



    /// <summary>
    /// Button response content.
    /// </summary>
    /// <value>Button response content.</value>
    [JsonPropertyName("buttonResponse")]
    public ConversationContentButtonResponse ButtonResponse { get; set; }



    /// <summary>
    /// Template notification content.
    /// </summary>
    /// <value>Template notification content.</value>
    [JsonPropertyName("template")]
    public ConversationContentNotificationTemplate Template { get; set; }



    /// <summary>
    /// Ephemeral story content.
    /// </summary>
    /// <value>Ephemeral story content.</value>
    [JsonPropertyName("story")]
    public ConversationContentStory Story { get; set; }



    /// <summary>
    /// Card content
    /// </summary>
    /// <value>Card content</value>
    [JsonPropertyName("card")]
    public ConversationContentCard Card { get; set; }



    /// <summary>
    /// Carousel content
    /// </summary>
    /// <value>Carousel content</value>
    [JsonPropertyName("carousel")]
    public ConversationContentCarousel Carousel { get; set; }



    /// <summary>
    /// Text content.
    /// </summary>
    /// <value>Text content.</value>
    [JsonPropertyName("text")]
    public ConversationContentText Text { get; set; }



    /// <summary>
    /// Quick reply V2 content.
    /// </summary>
    /// <value>Quick reply V2 content.</value>
    [JsonPropertyName("quickReplyV2")]
    public ConversationContentQuickReplyV2 QuickReplyV2 { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationMessageContent {\n");

        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
        sb.Append("  Attachment: ").Append(Attachment).Append("\n");
        sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
        sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
        sb.Append("  Template: ").Append(Template).Append("\n");
        sb.Append("  Story: ").Append(Story).Append("\n");
        sb.Append("  Card: ").Append(Card).Append("\n");
        sb.Append("  Carousel: ").Append(Carousel).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  QuickReplyV2: ").Append(QuickReplyV2).Append("\n");
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
        return Equals(obj as ConversationMessageContent);
    }

    /// <summary>
    /// Returns true if ConversationMessageContent instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationMessageContent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationMessageContent other)
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
                Location == other.Location ||
                Location != null &&
                Location.Equals(other.Location)
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
                Template == other.Template ||
                Template != null &&
                Template.Equals(other.Template)
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

            if (Location != null)
            {
                hash = hash * 59 + Location.GetHashCode();
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

            if (Template != null)
            {
                hash = hash * 59 + Template.GetHashCode();
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

            return hash;
        }
    }
}
