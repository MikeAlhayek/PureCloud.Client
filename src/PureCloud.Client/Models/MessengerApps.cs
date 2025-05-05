using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The apps embedded in the messenger
/// </summary>

public partial class MessengerApps : IEquatable<MessengerApps>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessengerApps" /> class.
    /// </summary>
    /// <param name="Conversations">The conversation settings that handles chats within the messenger.</param>
    /// <param name="Knowledge">The knowledge base config for messenger.</param>
    public MessengerApps(ConversationAppSettings Conversations = null, Knowledge Knowledge = null)
    {
        this.Conversations = Conversations;
        this.Knowledge = Knowledge;

    }



    /// <summary>
    /// The conversation settings that handles chats within the messenger
    /// </summary>
    /// <value>The conversation settings that handles chats within the messenger</value>
    [JsonPropertyName("conversations")]
    public ConversationAppSettings Conversations { get; set; }



    /// <summary>
    /// The knowledge base config for messenger
    /// </summary>
    /// <value>The knowledge base config for messenger</value>
    [JsonPropertyName("knowledge")]
    public Knowledge Knowledge { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessengerApps {\n");

        sb.Append("  Conversations: ").Append(Conversations).Append("\n");
        sb.Append("  Knowledge: ").Append(Knowledge).Append("\n");
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
        return Equals(obj as MessengerApps);
    }

    /// <summary>
    /// Returns true if MessengerApps instances are equal
    /// </summary>
    /// <param name="other">Instance of MessengerApps to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessengerApps other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversations == other.Conversations ||
                Conversations != null &&
                Conversations.Equals(other.Conversations)
            ) &&
            (
                Knowledge == other.Knowledge ||
                Knowledge != null &&
                Knowledge.Equals(other.Knowledge)
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
            if (Conversations != null)
            {
                hash = hash * 59 + Conversations.GetHashCode();
            }

            if (Knowledge != null)
            {
                hash = hash * 59 + Knowledge.GetHashCode();
            }

            return hash;
        }
    }
}
