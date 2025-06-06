using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LanguageOverride
/// </summary>

public partial class LanguageOverride : IEquatable<LanguageOverride>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LanguageOverride" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LanguageOverride() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LanguageOverride" /> class.
    /// </summary>
    /// <param name="Language">The language code of the language being overridden (required).</param>
    /// <param name="Engine">The ID of the TTS engine to use for this language override (required).</param>
    /// <param name="Voice">The ID of the voice to use for this language override. The voice must be supported by the chosen engine. (required).</param>
    public LanguageOverride(string Language = null, string Engine = null, string Voice = null)
    {
        this.Language = Language;
        this.Engine = Engine;
        this.Voice = Voice;

    }



    /// <summary>
    /// The language code of the language being overridden
    /// </summary>
    /// <value>The language code of the language being overridden</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// The ID of the TTS engine to use for this language override
    /// </summary>
    /// <value>The ID of the TTS engine to use for this language override</value>
    [JsonPropertyName("engine")]
    public string Engine { get; set; }



    /// <summary>
    /// The ID of the voice to use for this language override. The voice must be supported by the chosen engine.
    /// </summary>
    /// <value>The ID of the voice to use for this language override. The voice must be supported by the chosen engine.</value>
    [JsonPropertyName("voice")]
    public string Voice { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LanguageOverride {\n");

        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Engine: ").Append(Engine).Append("\n");
        sb.Append("  Voice: ").Append(Voice).Append("\n");
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
        return Equals(obj as LanguageOverride);
    }

    /// <summary>
    /// Returns true if LanguageOverride instances are equal
    /// </summary>
    /// <param name="other">Instance of LanguageOverride to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LanguageOverride other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Engine == other.Engine ||
                Engine != null &&
                Engine.Equals(other.Engine)
            ) &&
            (
                Voice == other.Voice ||
                Voice != null &&
                Voice.Equals(other.Voice)
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
            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Engine != null)
            {
                hash = hash * 59 + Engine.GetHashCode();
            }

            if (Voice != null)
            {
                hash = hash * 59 + Voice.GetHashCode();
            }

            return hash;
        }
    }
}
