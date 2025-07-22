using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LanguageOverride
{
    /// <summary>
    /// The language code of the language being overridden
    /// </summary>
    /// <value>The language code of the language being overridden</value>
    public string Language { get; set; }

    /// <summary>
    /// The ID of the TTS engine to use for this language override
    /// </summary>
    public string Engine { get; set; }

    /// <summary>
    /// The ID of the voice to use for this language override. The voice must be supported by the chosen engine.
    /// </summary>
    /// <value>The ID of the voice to use for this language override. The voice must be supported by the chosen engine.</value>
    public string Voice { get; set; }
}
