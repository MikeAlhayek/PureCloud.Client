using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BotConnectorBot
{
    /// <summary>
    /// The Botconnector Bot Id - this is configurable by the user when put
    /// </summary>
    /// <value>The Botconnector Bot Id - this is configurable by the user when put</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// An optional description of the bot.  This can be up to 256 characters long and must be comprised of displayable characters without leading or trailing whitespace
    /// </summary>
    /// <value>An optional description of the bot.  This can be up to 256 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
    public string Description { get; set; }

    /// <summary>
    /// This bots versions, limit of 50 per bot
    /// </summary>
    /// <value>This bots versions, limit of 50 per bot</value>
    public IEnumerable<BotConnectorBotVersion> Versions { get; set; }

    /// <summary>
    /// A system-generated string that contains metadata about this bot.
    /// </summary>
    /// <value>A system-generated string that contains metadata about this bot.</value>
    public string BotCompositeTag { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
