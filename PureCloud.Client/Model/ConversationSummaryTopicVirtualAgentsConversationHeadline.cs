using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// ConversationSummaryTopicVirtualAgentsConversationHeadline
/// </summary>
[DataContract]
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
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



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
        return this.Equals(obj as ConversationSummaryTopicVirtualAgentsConversationHeadline);
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
                this.Text == other.Text ||
                this.Text != null &&
                this.Text.Equals(other.Text)
            ) &&
            (
                this.Description == other.Description ||
                this.Description != null &&
                this.Description.Equals(other.Description)
            ) &&
            (
                this.Score == other.Score ||
                this.Score != null &&
                this.Score.Equals(other.Score)
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
            if (this.Text != null)
            {
                hash = hash * 59 + this.Text.GetHashCode();
            }

            if (this.Description != null)
            {
                hash = hash * 59 + this.Description.GetHashCode();
            }

            if (this.Score != null)
            {
                hash = hash * 59 + this.Score.GetHashCode();
            }

            return hash;
        }
    }
}
