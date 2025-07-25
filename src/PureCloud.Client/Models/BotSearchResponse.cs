namespace PureCloud.Client.Models;

/// <summary>
/// BotSearchResponse
/// </summary>
public sealed class BotSearchResponse
{
    /// <summary>
    /// The id of the bot
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The name of the bot
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The provider of the bot
    /// </summary>
    public BotSearchResponseBotType? BotType { get; set; }

    /// <summary>
    /// The description of the bot
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}