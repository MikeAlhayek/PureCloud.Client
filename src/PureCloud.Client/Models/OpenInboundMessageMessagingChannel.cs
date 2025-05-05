using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Open Channel-specific information that describes the message and the message channel/provider, with additional message information
/// </summary>

public partial class OpenInboundMessageMessagingChannel : IEquatable<OpenInboundMessageMessagingChannel>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenInboundMessageMessagingChannel" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenInboundMessageMessagingChannel() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenInboundMessageMessagingChannel" /> class.
    /// </summary>
    /// <param name="From">Information about the recipient the message is received from. (required).</param>
    /// <param name="Time">Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="MessageId">Unique provider ID of the message..</param>
    /// <param name="Metadata">Additional Custom Information about the channel..</param>
    public OpenInboundMessageMessagingChannel(OpenMessagingFromRecipient From = null, DateTime? Time = null, string MessageId = null, object Metadata = null)
    {
        this.From = From;
        this.Time = Time;
        this.MessageId = MessageId;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// Information about the recipient the message is received from.
    /// </summary>
    /// <value>Information about the recipient the message is received from.</value>
    [JsonPropertyName("from")]
    public OpenMessagingFromRecipient From { get; set; }



    /// <summary>
    /// Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("time")]
    public DateTime? Time { get; set; }



    /// <summary>
    /// Unique provider ID of the message.
    /// </summary>
    /// <value>Unique provider ID of the message.</value>
    [JsonPropertyName("messageId")]
    public string MessageId { get; set; }



    /// <summary>
    /// Additional Custom Information about the channel.
    /// </summary>
    /// <value>Additional Custom Information about the channel.</value>
    [JsonPropertyName("metadata")]
    public object Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenInboundMessageMessagingChannel {\n");

        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  MessageId: ").Append(MessageId).Append("\n");
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
        return Equals(obj as OpenInboundMessageMessagingChannel);
    }

    /// <summary>
    /// Returns true if OpenInboundMessageMessagingChannel instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenInboundMessageMessagingChannel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenInboundMessageMessagingChannel other)
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
                Time == other.Time ||
                Time != null &&
                Time.Equals(other.Time)
            ) &&
            (
                MessageId == other.MessageId ||
                MessageId != null &&
                MessageId.Equals(other.MessageId)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (Time != null)
            {
                hash = hash * 59 + Time.GetHashCode();
            }

            if (MessageId != null)
            {
                hash = hash * 59 + MessageId.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
