using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Channel-specific information that describes the message and the message channel/provider.
/// </summary>

public partial class WebMessagingChannel : IEquatable<WebMessagingChannel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebMessagingChannel" /> class.
    /// </summary>
    public WebMessagingChannel()
    {

    }



    /// <summary>
    /// Information about the recipient the message is received from.
    /// </summary>
    /// <value>Information about the recipient the message is received from.</value>
    [JsonPropertyName("from")]
    public WebMessagingRecipient From { get; set; }



    /// <summary>
    /// Information about the recipient the message is sent to.
    /// </summary>
    /// <value>Information about the recipient the message is sent to.</value>
    [JsonPropertyName("to")]
    public WebMessagingRecipient To { get; set; }



    /// <summary>
    /// When the message was processed by Genesys Cloud. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When the message was processed by Genesys Cloud. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("time")]
    public DateTime? Time { get; set; }



    /// <summary>
    /// Unique provider ID of the message.
    /// </summary>
    /// <value>Unique provider ID of the message.</value>
    [JsonPropertyName("messageId")]
    public string MessageId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebMessagingChannel {\n");

        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  MessageId: ").Append(MessageId).Append("\n");
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
        return Equals(obj as WebMessagingChannel);
    }

    /// <summary>
    /// Returns true if WebMessagingChannel instances are equal
    /// </summary>
    /// <param name="other">Instance of WebMessagingChannel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebMessagingChannel other)
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
                To == other.To ||
                To != null &&
                To.Equals(other.To)
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

            if (To != null)
            {
                hash = hash * 59 + To.GetHashCode();
            }

            if (Time != null)
            {
                hash = hash * 59 + Time.GetHashCode();
            }

            if (MessageId != null)
            {
                hash = hash * 59 + MessageId.GetHashCode();
            }

            return hash;
        }
    }
}
