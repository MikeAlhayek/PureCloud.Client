using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Prompt information related to a bot flow turn.
/// </summary>

public partial class TextBotModeOutputPrompts : IEquatable<TextBotModeOutputPrompts>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotModeOutputPrompts" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotModeOutputPrompts() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotModeOutputPrompts" /> class.
    /// </summary>
    /// <param name="Segments">The list of prompt segments. (required).</param>
    public TextBotModeOutputPrompts(List<TextBotPromptSegment> Segments = null)
    {
        this.Segments = Segments;

    }



    /// <summary>
    /// The list of prompt segments.
    /// </summary>
    /// <value>The list of prompt segments.</value>
    [JsonPropertyName("segments")]
    public List<TextBotPromptSegment> Segments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotModeOutputPrompts {\n");

        sb.Append("  Segments: ").Append(Segments).Append("\n");
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
        return Equals(obj as TextBotModeOutputPrompts);
    }

    /// <summary>
    /// Returns true if TextBotModeOutputPrompts instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotModeOutputPrompts to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotModeOutputPrompts other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Segments == other.Segments ||
                Segments != null &&
                Segments.SequenceEqual(other.Segments)
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
            if (Segments != null)
            {
                hash = hash * 59 + Segments.GetHashCode();
            }

            return hash;
        }
    }
}
