using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// AdditionalMessage
/// </summary>
[DataContract]
public partial class AdditionalMessage : IEquatable<AdditionalMessage>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AdditionalMessage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AdditionalMessage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AdditionalMessage" /> class.
    /// </summary>
    /// <param name="TextBody">The body of the text message.  Maximum character counts are: SMS - 765 characters, other channels - 2000 characters. (required).</param>
    /// <param name="MediaIds">The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage..</param>
    /// <param name="StickerIds">The sticker ids associated with the text message..</param>
    /// <param name="MessagingTemplate">The messaging template use to send a predefined canned response with the message.</param>
    public AdditionalMessage(string TextBody = null, List<string> MediaIds = null, List<string> StickerIds = null, SendMessagingTemplateRequest MessagingTemplate = null)
    {
        this.TextBody = TextBody;
        this.MediaIds = MediaIds;
        this.StickerIds = StickerIds;
        this.MessagingTemplate = MessagingTemplate;

    }



    /// <summary>
    /// The body of the text message.  Maximum character counts are: SMS - 765 characters, other channels - 2000 characters.
    /// </summary>
    /// <value>The body of the text message.  Maximum character counts are: SMS - 765 characters, other channels - 2000 characters.</value>
    [DataMember(Name = "textBody", EmitDefaultValue = false)]
    public string TextBody { get; set; }



    /// <summary>
    /// The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.
    /// </summary>
    /// <value>The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.</value>
    [DataMember(Name = "mediaIds", EmitDefaultValue = false)]
    public List<string> MediaIds { get; set; }



    /// <summary>
    /// The sticker ids associated with the text message.
    /// </summary>
    /// <value>The sticker ids associated with the text message.</value>
    [DataMember(Name = "stickerIds", EmitDefaultValue = false)]
    public List<string> StickerIds { get; set; }



    /// <summary>
    /// The messaging template use to send a predefined canned response with the message
    /// </summary>
    /// <value>The messaging template use to send a predefined canned response with the message</value>
    [DataMember(Name = "messagingTemplate", EmitDefaultValue = false)]
    public SendMessagingTemplateRequest MessagingTemplate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdditionalMessage {\n");

        sb.Append("  TextBody: ").Append(TextBody).Append("\n");
        sb.Append("  MediaIds: ").Append(MediaIds).Append("\n");
        sb.Append("  StickerIds: ").Append(StickerIds).Append("\n");
        sb.Append("  MessagingTemplate: ").Append(MessagingTemplate).Append("\n");
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
        return this.Equals(obj as AdditionalMessage);
    }

    /// <summary>
    /// Returns true if AdditionalMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of AdditionalMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdditionalMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.TextBody == other.TextBody ||
                this.TextBody != null &&
                this.TextBody.Equals(other.TextBody)
            ) &&
            (
                this.MediaIds == other.MediaIds ||
                this.MediaIds != null &&
                this.MediaIds.SequenceEqual(other.MediaIds)
            ) &&
            (
                this.StickerIds == other.StickerIds ||
                this.StickerIds != null &&
                this.StickerIds.SequenceEqual(other.StickerIds)
            ) &&
            (
                this.MessagingTemplate == other.MessagingTemplate ||
                this.MessagingTemplate != null &&
                this.MessagingTemplate.Equals(other.MessagingTemplate)
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
            if (this.TextBody != null)
            {
                hash = hash * 59 + this.TextBody.GetHashCode();
            }

            if (this.MediaIds != null)
            {
                hash = hash * 59 + this.MediaIds.GetHashCode();
            }

            if (this.StickerIds != null)
            {
                hash = hash * 59 + this.StickerIds.GetHashCode();
            }

            if (this.MessagingTemplate != null)
            {
                hash = hash * 59 + this.MessagingTemplate.GetHashCode();
            }

            return hash;
        }
    }
}
