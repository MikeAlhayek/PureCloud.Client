using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSummaryTopicVirtualAgentsConversationSummary
/// </summary>
[DataContract]
public partial class ConversationSummaryTopicVirtualAgentsConversationSummary : IEquatable<ConversationSummaryTopicVirtualAgentsConversationSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSummaryTopicVirtualAgentsConversationSummary" /> class.
    /// </summary>
    /// <param name="Text">Text.</param>
    /// <param name="Score">Score.</param>
    public ConversationSummaryTopicVirtualAgentsConversationSummary(string Text = null, double? Score = null)
    {
        this.Text = Text;
        this.Score = Score;

    }



    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    [DataMember(Name = "score", EmitDefaultValue = false)]
    public double? Score { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSummaryTopicVirtualAgentsConversationSummary {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Score: ").Append(Score).Append("\n");
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
        return Equals(obj as ConversationSummaryTopicVirtualAgentsConversationSummary);
    }

    /// <summary>
    /// Returns true if ConversationSummaryTopicVirtualAgentsConversationSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSummaryTopicVirtualAgentsConversationSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSummaryTopicVirtualAgentsConversationSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Score == other.Score ||
                Score != null &&
                Score.Equals(other.Score)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            return hash;
        }
    }
}
