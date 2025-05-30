using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// User input data used in a bot flow turn.
/// </summary>

public partial class TextBotUserInputAlternative : IEquatable<TextBotUserInputAlternative>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotUserInputAlternative" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotUserInputAlternative() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotUserInputAlternative" /> class.
    /// </summary>
    /// <param name="Transcript">The user input transcript. (required).</param>
    public TextBotUserInputAlternative(TextBotTranscript Transcript = null)
    {
        this.Transcript = Transcript;

    }



    /// <summary>
    /// The user input transcript.
    /// </summary>
    /// <value>The user input transcript.</value>
    [JsonPropertyName("transcript")]
    public TextBotTranscript Transcript { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotUserInputAlternative {\n");

        sb.Append("  Transcript: ").Append(Transcript).Append("\n");
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
        return Equals(obj as TextBotUserInputAlternative);
    }

    /// <summary>
    /// Returns true if TextBotUserInputAlternative instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotUserInputAlternative to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotUserInputAlternative other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Transcript == other.Transcript ||
                Transcript != null &&
                Transcript.Equals(other.Transcript)
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
            if (Transcript != null)
            {
                hash = hash * 59 + Transcript.GetHashCode();
            }

            return hash;
        }
    }
}
