using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TtsSettings
{
    /// <summary>
    /// ID of the global default TTS engine
    /// </summary>
    /// <value>ID of the global default TTS engine</value>
    public string DefaultEngine { get; set; }

    /// <summary>
    /// The list of default overrides for specific languages
    /// </summary>
    /// <value>The list of default overrides for specific languages</value>
    public IEnumerable<LanguageOverride> LanguageOverrides { get; set; }
}
