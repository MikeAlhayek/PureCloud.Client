using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationEditedInput
/// </summary>

public partial class ConversationEditedInput : IEquatable<ConversationEditedInput>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEditedInput" /> class.
    /// </summary>
    /// <param name="Text">The text of the edited input..</param>
    /// <param name="DateModified">The modification date of the edited input. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ConversationEditedInput(string Text = null, DateTime? DateModified = null)
    {
        this.Text = Text;
        this.DateModified = DateModified;

    }



    /// <summary>
    /// The text of the edited input.
    /// </summary>
    /// <value>The text of the edited input.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// The modification date of the edited input. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The modification date of the edited input. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEditedInput {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as ConversationEditedInput);
    }

    /// <summary>
    /// Returns true if ConversationEditedInput instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEditedInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEditedInput other)
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
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            return hash;
        }
    }
}
