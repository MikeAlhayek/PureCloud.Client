using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Quick reply object V2.
/// </summary>

public partial class ConversationContentQuickReplyV2 : IEquatable<ConversationContentQuickReplyV2>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentQuickReplyV2" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationContentQuickReplyV2() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentQuickReplyV2" /> class.
    /// </summary>
    /// <param name="Title">Text to show as the title of the quick reply. (required).</param>
    /// <param name="Actions">An array of quick reply objects. (required).</param>
    public ConversationContentQuickReplyV2(string Title = null, List<ConversationContentQuickReply> Actions = null)
    {
        this.Title = Title;
        this.Actions = Actions;

    }



    /// <summary>
    /// Text to show as the title of the quick reply.
    /// </summary>
    /// <value>Text to show as the title of the quick reply.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// An array of quick reply objects.
    /// </summary>
    /// <value>An array of quick reply objects.</value>
    [JsonPropertyName("actions")]
    public List<ConversationContentQuickReply> Actions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationContentQuickReplyV2 {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Actions: ").Append(Actions).Append("\n");
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
        return Equals(obj as ConversationContentQuickReplyV2);
    }

    /// <summary>
    /// Returns true if ConversationContentQuickReplyV2 instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationContentQuickReplyV2 to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationContentQuickReplyV2 other)
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
                Actions == other.Actions ||
                Actions != null &&
                Actions.SequenceEqual(other.Actions)
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

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            return hash;
        }
    }
}
