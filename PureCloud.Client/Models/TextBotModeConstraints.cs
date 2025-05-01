using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Mode constraints to observe when operating on a bot flow.
/// </summary>
[DataContract]
public partial class TextBotModeConstraints : IEquatable<TextBotModeConstraints>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotModeConstraints" /> class.
    /// </summary>
    /// <param name="Text">Mode constraints that apply to text scenarios..</param>
    public TextBotModeConstraints(TextBotTextModeConstraints Text = null)
    {
        this.Text = Text;

    }



    /// <summary>
    /// Mode constraints that apply to text scenarios.
    /// </summary>
    /// <value>Mode constraints that apply to text scenarios.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public TextBotTextModeConstraints Text { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotModeConstraints {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
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
        return Equals(obj as TextBotModeConstraints);
    }

    /// <summary>
    /// Returns true if TextBotModeConstraints instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotModeConstraints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotModeConstraints other)
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

            return hash;
        }
    }
}
