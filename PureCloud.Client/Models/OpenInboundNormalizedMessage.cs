using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Open Messaging rich media message structure
/// </summary>

public partial class OpenInboundNormalizedMessage : IEquatable<OpenInboundNormalizedMessage>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenInboundNormalizedMessage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenInboundNormalizedMessage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenInboundNormalizedMessage" /> class.
    /// </summary>
    /// <param name="Channel">Channel-specific information that describes the message and the message channel/provider. (required).</param>
    /// <param name="Text">Message text..</param>
    /// <param name="Content">List of content elements..</param>
    /// <param name="Metadata">Additional metadata about this message to capture non-channel specific data..</param>
    public OpenInboundNormalizedMessage(OpenInboundMessageMessagingChannel Channel = null, string Text = null, List<OpenInboundMessageContent> Content = null, Dictionary<string, string> Metadata = null)
    {
        this.Channel = Channel;
        this.Text = Text;
        this.Content = Content;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// Channel-specific information that describes the message and the message channel/provider.
    /// </summary>
    /// <value>Channel-specific information that describes the message and the message channel/provider.</value>
    [JsonPropertyName("channel")]
    public OpenInboundMessageMessagingChannel Channel { get; set; }



    /// <summary>
    /// Message text.
    /// </summary>
    /// <value>Message text.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// List of content elements.
    /// </summary>
    /// <value>List of content elements.</value>
    [JsonPropertyName("content")]
    public List<OpenInboundMessageContent> Content { get; set; }



    /// <summary>
    /// Additional metadata about this message to capture non-channel specific data.
    /// </summary>
    /// <value>Additional metadata about this message to capture non-channel specific data.</value>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string> Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenInboundNormalizedMessage {\n");

        sb.Append("  Channel: ").Append(Channel).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as OpenInboundNormalizedMessage);
    }

    /// <summary>
    /// Returns true if OpenInboundNormalizedMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenInboundNormalizedMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenInboundNormalizedMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Channel == other.Channel ||
                Channel != null &&
                Channel.Equals(other.Channel)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Content == other.Content ||
                Content != null &&
                Content.SequenceEqual(other.Content)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.SequenceEqual(other.Metadata)
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
            if (Channel != null)
            {
                hash = hash * 59 + Channel.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
