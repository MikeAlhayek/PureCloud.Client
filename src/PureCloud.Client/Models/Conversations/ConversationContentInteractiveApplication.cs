using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InteractiveApplication content object.
/// </summary>

public partial class ConversationContentInteractiveApplication : IEquatable<ConversationContentInteractiveApplication>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentInteractiveApplication" /> class.
    /// </summary>
    /// <param name="Name">The name of the message app..</param>
    /// <param name="Url">Contains the data that is sent to the message app..</param>
    /// <param name="ReceivedMessage">The message displayed in the received message bubble..</param>
    /// <param name="ReplyMessage">The message displayed in the reply message bubble..</param>
    public ConversationContentInteractiveApplication(string Name = null, string Url = null, ConversationContentReceivedReplyMessage ReceivedMessage = null, ConversationContentReceivedReplyMessage ReplyMessage = null)
    {
        this.Name = Name;
        this.Url = Url;
        this.ReceivedMessage = ReceivedMessage;
        this.ReplyMessage = ReplyMessage;

    }



    /// <summary>
    /// The name of the message app.
    /// </summary>
    /// <value>The name of the message app.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Contains the data that is sent to the message app.
    /// </summary>
    /// <value>Contains the data that is sent to the message app.</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// The message displayed in the received message bubble.
    /// </summary>
    /// <value>The message displayed in the received message bubble.</value>
    [JsonPropertyName("receivedMessage")]
    public ConversationContentReceivedReplyMessage ReceivedMessage { get; set; }



    /// <summary>
    /// The message displayed in the reply message bubble.
    /// </summary>
    /// <value>The message displayed in the reply message bubble.</value>
    [JsonPropertyName("replyMessage")]
    public ConversationContentReceivedReplyMessage ReplyMessage { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationContentInteractiveApplication {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  ReceivedMessage: ").Append(ReceivedMessage).Append("\n");
        sb.Append("  ReplyMessage: ").Append(ReplyMessage).Append("\n");
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
        return Equals(obj as ConversationContentInteractiveApplication);
    }

    /// <summary>
    /// Returns true if ConversationContentInteractiveApplication instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationContentInteractiveApplication to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationContentInteractiveApplication other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                ReceivedMessage == other.ReceivedMessage ||
                ReceivedMessage != null &&
                ReceivedMessage.Equals(other.ReceivedMessage)
            ) &&
            (
                ReplyMessage == other.ReplyMessage ||
                ReplyMessage != null &&
                ReplyMessage.Equals(other.ReplyMessage)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (ReceivedMessage != null)
            {
                hash = hash * 59 + ReceivedMessage.GetHashCode();
            }

            if (ReplyMessage != null)
            {
                hash = hash * 59 + ReplyMessage.GetHashCode();
            }

            return hash;
        }
    }
}
