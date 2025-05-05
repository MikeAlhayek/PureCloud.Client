using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSummaryTopicVirtualAgentsConversationResolution
/// </summary>

public partial class ConversationSummaryTopicVirtualAgentsConversationResolution : IEquatable<ConversationSummaryTopicVirtualAgentsConversationResolution>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSummaryTopicVirtualAgentsConversationResolution" /> class.
    /// </summary>
    /// <param name="Text">Text.</param>
    /// <param name="Description">Description.</param>
    /// <param name="ResolutionValue">ResolutionValue.</param>
    /// <param name="Score">Score.</param>
    public ConversationSummaryTopicVirtualAgentsConversationResolution(string Text = null, string Description = null, string ResolutionValue = null, double? Score = null)
    {
        this.Text = Text;
        this.Description = Description;
        this.ResolutionValue = ResolutionValue;
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
    /// Gets or Sets ResolutionValue
    /// </summary>
    [JsonPropertyName("resolutionValue")]
    public string ResolutionValue { get; set; }



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
        sb.Append("class ConversationSummaryTopicVirtualAgentsConversationResolution {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ResolutionValue: ").Append(ResolutionValue).Append("\n");
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
        return Equals(obj as ConversationSummaryTopicVirtualAgentsConversationResolution);
    }

    /// <summary>
    /// Returns true if ConversationSummaryTopicVirtualAgentsConversationResolution instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSummaryTopicVirtualAgentsConversationResolution to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSummaryTopicVirtualAgentsConversationResolution other)
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
                ResolutionValue == other.ResolutionValue ||
                ResolutionValue != null &&
                ResolutionValue.Equals(other.ResolutionValue)
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

            if (ResolutionValue != null)
            {
                hash = hash * 59 + ResolutionValue.GetHashCode();
            }

            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            return hash;
        }
    }
}
