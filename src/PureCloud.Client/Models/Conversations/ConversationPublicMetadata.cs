using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about a public message.
/// </summary>

public partial class ConversationPublicMetadata : IEquatable<ConversationPublicMetadata>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationPublicMetadata" /> class.
    /// </summary>
    /// <param name="RootId">The id of the root public message..</param>
    /// <param name="ReplyToId">The id of the message this public message is replying to..</param>
    public ConversationPublicMetadata(string RootId = null, string ReplyToId = null)
    {
        this.RootId = RootId;
        this.ReplyToId = ReplyToId;

    }



    /// <summary>
    /// The id of the root public message.
    /// </summary>
    /// <value>The id of the root public message.</value>
    [JsonPropertyName("rootId")]
    public string RootId { get; set; }



    /// <summary>
    /// The id of the message this public message is replying to.
    /// </summary>
    /// <value>The id of the message this public message is replying to.</value>
    [JsonPropertyName("replyToId")]
    public string ReplyToId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationPublicMetadata {\n");

        sb.Append("  RootId: ").Append(RootId).Append("\n");
        sb.Append("  ReplyToId: ").Append(ReplyToId).Append("\n");
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
        return Equals(obj as ConversationPublicMetadata);
    }

    /// <summary>
    /// Returns true if ConversationPublicMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationPublicMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationPublicMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RootId == other.RootId ||
                RootId != null &&
                RootId.Equals(other.RootId)
            ) &&
            (
                ReplyToId == other.ReplyToId ||
                ReplyToId != null &&
                ReplyToId.Equals(other.ReplyToId)
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
            if (RootId != null)
            {
                hash = hash * 59 + RootId.GetHashCode();
            }

            if (ReplyToId != null)
            {
                hash = hash * 59 + ReplyToId.GetHashCode();
            }

            return hash;
        }
    }
}
