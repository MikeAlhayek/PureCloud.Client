using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatReaction
/// </summary>

public partial class ChatReaction : IEquatable<ChatReaction>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatReaction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ChatReaction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatReaction" /> class.
    /// </summary>
    /// <param name="Emoji">The emoji string for the reaction (required).</param>
    /// <param name="Users">The users that reacted with an emoji (required).</param>
    public ChatReaction(string Emoji = null, List<AddressableEntityRef> Users = null)
    {
        this.Emoji = Emoji;
        this.Users = Users;

    }



    /// <summary>
    /// The emoji string for the reaction
    /// </summary>
    /// <value>The emoji string for the reaction</value>
    [JsonPropertyName("emoji")]
    public string Emoji { get; set; }



    /// <summary>
    /// The users that reacted with an emoji
    /// </summary>
    /// <value>The users that reacted with an emoji</value>
    [JsonPropertyName("users")]
    public List<AddressableEntityRef> Users { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatReaction {\n");

        sb.Append("  Emoji: ").Append(Emoji).Append("\n");
        sb.Append("  Users: ").Append(Users).Append("\n");
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
        return Equals(obj as ChatReaction);
    }

    /// <summary>
    /// Returns true if ChatReaction instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatReaction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatReaction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Emoji == other.Emoji ||
                Emoji != null &&
                Emoji.Equals(other.Emoji)
            ) &&
            (
                Users == other.Users ||
                Users != null &&
                Users.SequenceEqual(other.Users)
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
            if (Emoji != null)
            {
                hash = hash * 59 + Emoji.GetHashCode();
            }

            if (Users != null)
            {
                hash = hash * 59 + Users.GetHashCode();
            }

            return hash;
        }
    }
}
