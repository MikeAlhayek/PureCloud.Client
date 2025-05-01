using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSummaryFollowup
/// </summary>
[DataContract]
public partial class ConversationSummaryFollowup : IEquatable<ConversationSummaryFollowup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSummaryFollowup" /> class.
    /// </summary>
    /// <param name="Text">The text of the followup..</param>
    /// <param name="Description">The description..</param>
    public ConversationSummaryFollowup(string Text = null, string Description = null)
    {
        this.Text = Text;
        this.Description = Description;

    }



    /// <summary>
    /// The text of the followup.
    /// </summary>
    /// <value>The text of the followup.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// The description.
    /// </summary>
    /// <value>The description.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The AI confidence value.
    /// </summary>
    /// <value>The AI confidence value.</value>
    [DataMember(Name = "confidence", EmitDefaultValue = false)]
    public float? Confidence { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSummaryFollowup {\n");

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
        return Equals(obj as ConversationSummaryFollowup);
    }

    /// <summary>
    /// Returns true if ConversationSummaryFollowup instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSummaryFollowup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSummaryFollowup other)
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
