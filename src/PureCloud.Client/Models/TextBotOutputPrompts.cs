using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Prompt information related to a bot flow turn.
/// </summary>

public partial class TextBotOutputPrompts : IEquatable<TextBotOutputPrompts>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotOutputPrompts" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotOutputPrompts() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotOutputPrompts" /> class.
    /// </summary>
    /// <param name="OutputLanguage">The ISO code of the output language for this prompt item. (required).</param>
    /// <param name="TextPrompts">Text output prompts, if any..</param>
    public TextBotOutputPrompts(string OutputLanguage = null, TextBotModeOutputPrompts TextPrompts = null)
    {
        this.OutputLanguage = OutputLanguage;
        this.TextPrompts = TextPrompts;

    }



    /// <summary>
    /// The ISO code of the output language for this prompt item.
    /// </summary>
    /// <value>The ISO code of the output language for this prompt item.</value>
    [JsonPropertyName("outputLanguage")]
    public string OutputLanguage { get; set; }



    /// <summary>
    /// Text output prompts, if any.
    /// </summary>
    /// <value>Text output prompts, if any.</value>
    [JsonPropertyName("textPrompts")]
    public TextBotModeOutputPrompts TextPrompts { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotOutputPrompts {\n");

        sb.Append("  OutputLanguage: ").Append(OutputLanguage).Append("\n");
        sb.Append("  TextPrompts: ").Append(TextPrompts).Append("\n");
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
        return Equals(obj as TextBotOutputPrompts);
    }

    /// <summary>
    /// Returns true if TextBotOutputPrompts instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotOutputPrompts to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotOutputPrompts other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OutputLanguage == other.OutputLanguage ||
                OutputLanguage != null &&
                OutputLanguage.Equals(other.OutputLanguage)
            ) &&
            (
                TextPrompts == other.TextPrompts ||
                TextPrompts != null &&
                TextPrompts.Equals(other.TextPrompts)
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
            if (OutputLanguage != null)
            {
                hash = hash * 59 + OutputLanguage.GetHashCode();
            }

            if (TextPrompts != null)
            {
                hash = hash * 59 + TextPrompts.GetHashCode();
            }

            return hash;
        }
    }
}
