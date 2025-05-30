using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatReactionUpdate
/// </summary>

public partial class ChatReactionUpdate : IEquatable<ChatReactionUpdate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatReactionUpdate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ChatReactionUpdate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatReactionUpdate" /> class.
    /// </summary>
    /// <param name="Reactions">Reactions to update (required).</param>
    public ChatReactionUpdate(List<string> Reactions = null)
    {
        this.Reactions = Reactions;

    }



    /// <summary>
    /// Reactions to update
    /// </summary>
    /// <value>Reactions to update</value>
    [JsonPropertyName("reactions")]
    public List<string> Reactions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatReactionUpdate {\n");

        sb.Append("  Reactions: ").Append(Reactions).Append("\n");
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
        return Equals(obj as ChatReactionUpdate);
    }

    /// <summary>
    /// Returns true if ChatReactionUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatReactionUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatReactionUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Reactions == other.Reactions ||
                Reactions != null &&
                Reactions.SequenceEqual(other.Reactions)
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
            if (Reactions != null)
            {
                hash = hash * 59 + Reactions.GetHashCode();
            }

            return hash;
        }
    }
}
