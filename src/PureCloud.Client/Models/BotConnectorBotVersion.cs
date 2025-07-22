using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BotConnectorBotVersion
{
    /// <summary>
    /// The name of the version. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace
    /// </summary>
    /// <value>The name of the version. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
    public string Version { get; set; }

    /// <summary>
    /// The supported languages for this bot. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code)
    /// </summary>
    /// <value>The supported languages for this bot. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code)</value>
    public IEnumerable<string> SupportedLanguages { get; set; }

    /// <summary>
    /// A list of potential intents this bot will return, limit of 50
    /// </summary>
    /// <value>A list of potential intents this bot will return, limit of 50</value>
    public IEnumerable<BotIntent> Intents { get; set; }
}
