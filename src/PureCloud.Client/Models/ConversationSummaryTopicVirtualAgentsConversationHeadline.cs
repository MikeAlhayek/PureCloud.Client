using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSummaryTopicVirtualAgentsConversationHeadline
/// </summary>

public partial class ConversationSummaryTopicVirtualAgentsConversationHeadline : IEquatable<ConversationSummaryTopicVirtualAgentsConversationHeadline>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSummaryTopicVirtualAgentsConversationHeadline" /> class.
    /// </summary>
    /// <param name="Text">Text.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Score">Score.</param>
    public ConversationSummaryTopicVirtualAgentsConversationHeadline(string Text = null, string Description = null, double? Score = null)
    {
        this.Text = Text;
        this.Description = Description;
        this.Score = Score;

    }



    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSummaryTopicVirtualAgentsConversationHeadline {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as ConversationSummaryTopicVirtualAgentsConversationHeadline);
    }

    /// <summary>
    /// Returns true if ConversationSummaryTopicVirtualAgentsConversationHeadline instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSummaryTopicVirtualAgentsConversationHeadline to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSummaryTopicVirtualAgentsConversationHeadline other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            return hash;
        }
    }
}
