using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatBadgeTopicBadgeEntity
/// </summary>
[DataContract]
public partial class ChatBadgeTopicBadgeEntity : IEquatable<ChatBadgeTopicBadgeEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatBadgeTopicBadgeEntity" /> class.
    /// </summary>
    /// <param name="JabberId">JabberId.</param>
    public ChatBadgeTopicBadgeEntity(string JabberId = null)
    {
        this.JabberId = JabberId;

    }



    /// <summary>
    /// Gets or Sets JabberId
    /// </summary>
    [DataMember(Name = "jabberId", EmitDefaultValue = false)]
    public string JabberId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatBadgeTopicBadgeEntity {\n");

        sb.Append("  JabberId: ").Append(JabberId).Append("\n");
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
        return Equals(obj as ChatBadgeTopicBadgeEntity);
    }

    /// <summary>
    /// Returns true if ChatBadgeTopicBadgeEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatBadgeTopicBadgeEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatBadgeTopicBadgeEntity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                JabberId == other.JabberId ||
                JabberId != null &&
                JabberId.Equals(other.JabberId)
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
            if (JabberId != null)
            {
                hash = hash * 59 + JabberId.GetHashCode();
            }

            return hash;
        }
    }
}
