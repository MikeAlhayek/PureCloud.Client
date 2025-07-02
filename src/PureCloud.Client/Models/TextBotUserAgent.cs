using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TextBotUserAgent
{
    /// <summary>
    /// The name of the user agent.
    /// </summary>
    /// <value>The name of the user agent.</value>
    public TextBotUserAgentNameEnum? Name { get; set; }
}
