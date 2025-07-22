using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BotVersionSummary
{
    /// <summary>
    /// The name of the bot.
    /// </summary>
    /// <value>The name of the bot.</value>
    public string Name { get; set; }

    /// <summary>
    /// The id of the bot.
    /// </summary>
    /// <value>The id of the bot.</value>
    public string Id { get; set; }

    /// <summary>
    /// An optional description of the bot.
    /// </summary>
    /// <value>An optional description of the bot.</value>
    public string Description { get; set; }

    /// <summary>
    /// A system-generated string that contains metadata about this bot.
    /// </summary>
    /// <value>A system-generated string that contains metadata about this bot.</value>
    public string BotCompositeTag { get; set; }

    /// <summary>
    /// The name of the version.
    /// </summary>
    /// <value>The name of the version.</value>
    public string Version { get; set; }
}
