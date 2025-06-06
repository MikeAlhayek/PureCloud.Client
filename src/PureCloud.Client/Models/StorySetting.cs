using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// StorySetting
/// </summary>

public partial class StorySetting : IEquatable<StorySetting>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StorySetting" /> class.
    /// </summary>
    /// <param name="Mention">Setting relating to Story Mentions.</param>
    /// <param name="Reply">Setting relating to Story Replies.</param>
    public StorySetting(InboundOnlySetting Mention = null, InboundOnlySetting Reply = null)
    {
        this.Mention = Mention;
        this.Reply = Reply;

    }



    /// <summary>
    /// Setting relating to Story Mentions
    /// </summary>
    /// <value>Setting relating to Story Mentions</value>
    [JsonPropertyName("mention")]
    public InboundOnlySetting Mention { get; set; }



    /// <summary>
    /// Setting relating to Story Replies
    /// </summary>
    /// <value>Setting relating to Story Replies</value>
    [JsonPropertyName("reply")]
    public InboundOnlySetting Reply { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StorySetting {\n");

        sb.Append("  Mention: ").Append(Mention).Append("\n");
        sb.Append("  Reply: ").Append(Reply).Append("\n");
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
        return Equals(obj as StorySetting);
    }

    /// <summary>
    /// Returns true if StorySetting instances are equal
    /// </summary>
    /// <param name="other">Instance of StorySetting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(StorySetting other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Mention == other.Mention ||
                Mention != null &&
                Mention.Equals(other.Mention)
            ) &&
            (
                Reply == other.Reply ||
                Reply != null &&
                Reply.Equals(other.Reply)
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
            if (Mention != null)
            {
                hash = hash * 59 + Mention.GetHashCode();
            }

            if (Reply != null)
            {
                hash = hash * 59 + Reply.GetHashCode();
            }

            return hash;
        }
    }
}
