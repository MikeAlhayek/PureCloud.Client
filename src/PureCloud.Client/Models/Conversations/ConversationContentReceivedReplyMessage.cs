using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReceivedReplyMessage content object.
/// </summary>

public partial class ConversationContentReceivedReplyMessage : IEquatable<ConversationContentReceivedReplyMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentReceivedReplyMessage" /> class.
    /// </summary>
    /// <param name="Title">Text to show in the title..</param>
    /// <param name="Subtitle">Text to show in the subtitle..</param>
    /// <param name="ImageUrl">URL of an image..</param>
    public ConversationContentReceivedReplyMessage(string Title = null, string Subtitle = null, string ImageUrl = null)
    {
        this.Title = Title;
        this.Subtitle = Subtitle;
        this.ImageUrl = ImageUrl;

    }



    /// <summary>
    /// Text to show in the title.
    /// </summary>
    /// <value>Text to show in the title.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// Text to show in the subtitle.
    /// </summary>
    /// <value>Text to show in the subtitle.</value>
    [JsonPropertyName("subtitle")]
    public string Subtitle { get; set; }



    /// <summary>
    /// URL of an image.
    /// </summary>
    /// <value>URL of an image.</value>
    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationContentReceivedReplyMessage {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
        sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
        return Equals(obj as ConversationContentReceivedReplyMessage);
    }

    /// <summary>
    /// Returns true if ConversationContentReceivedReplyMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationContentReceivedReplyMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationContentReceivedReplyMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Subtitle == other.Subtitle ||
                Subtitle != null &&
                Subtitle.Equals(other.Subtitle)
            ) &&
            (
                ImageUrl == other.ImageUrl ||
                ImageUrl != null &&
                ImageUrl.Equals(other.ImageUrl)
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
            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Subtitle != null)
            {
                hash = hash * 59 + Subtitle.GetHashCode();
            }

            if (ImageUrl != null)
            {
                hash = hash * 59 + ImageUrl.GetHashCode();
            }

            return hash;
        }
    }
}
