using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdditionalMessage
/// </summary>

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
    [JsonPropertyName("textBody")]
    public string TextBody { get; set; }



    /// <summary>
    /// The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.
    /// </summary>
    /// <value>The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.</value>
    [JsonPropertyName("mediaIds")]
    public List<string> MediaIds { get; set; }



    /// <summary>
    /// The sticker ids associated with the text message.
    /// </summary>
    /// <value>The sticker ids associated with the text message.</value>
    [JsonPropertyName("stickerIds")]
    public List<string> StickerIds { get; set; }



    /// <summary>
    /// The messaging template use to send a predefined canned response with the message
    /// </summary>
    /// <value>The messaging template use to send a predefined canned response with the message</value>
    [JsonPropertyName("messagingTemplate")]
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
        return Equals(obj as AdditionalMessage);
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
                TextBody == other.TextBody ||
                TextBody != null &&
                TextBody.Equals(other.TextBody)
            ) &&
            (
                MediaIds == other.MediaIds ||
                MediaIds != null &&
                MediaIds.SequenceEqual(other.MediaIds)
            ) &&
            (
                StickerIds == other.StickerIds ||
                StickerIds != null &&
                StickerIds.SequenceEqual(other.StickerIds)
            ) &&
            (
                MessagingTemplate == other.MessagingTemplate ||
                MessagingTemplate != null &&
                MessagingTemplate.Equals(other.MessagingTemplate)
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
            if (TextBody != null)
            {
                hash = hash * 59 + TextBody.GetHashCode();
            }

            if (MediaIds != null)
            {
                hash = hash * 59 + MediaIds.GetHashCode();
            }

            if (StickerIds != null)
            {
                hash = hash * 59 + StickerIds.GetHashCode();
            }

            if (MessagingTemplate != null)
            {
                hash = hash * 59 + MessagingTemplate.GetHashCode();
            }

            return hash;
        }
    }
}
