using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSummaryReason
/// </summary>

public partial class ConversationSummaryReason : IEquatable<ConversationSummaryReason>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSummaryReason" /> class.
    /// </summary>
    /// <param name="Text">The text of the reason..</param>
    /// <param name="Description">The description..</param>
    public ConversationSummaryReason(string Text = null, string Description = null)
    {
        this.Text = Text;
        this.Description = Description;

    }



    /// <summary>
    /// The text of the reason.
    /// </summary>
    /// <value>The text of the reason.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// The description.
    /// </summary>
    /// <value>The description.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The AI confidence value.
    /// </summary>
    /// <value>The AI confidence value.</value>
    [JsonPropertyName("confidence")]
    public float? Confidence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSummaryReason {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
        return Equals(obj as ConversationSummaryReason);
    }

    /// <summary>
    /// Returns true if ConversationSummaryReason instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSummaryReason to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSummaryReason other)
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
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
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

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            return hash;
        }
    }
}
