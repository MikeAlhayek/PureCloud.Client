using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SupportedLanguage
{
    /// <summary>
    /// Architect supported language tag, e.g. en-us, es-us
    /// </summary>
    /// <value>Architect supported language tag, e.g. en-us, es-us</value>
    public string Language { get; set; }

    /// <summary>
    /// Whether or not this language is the default language
    /// </summary>
    /// <value>Whether or not this language is the default language</value>
    public bool? IsDefault { get; set; }
}
