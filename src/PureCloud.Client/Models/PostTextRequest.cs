namespace PureCloud.Client.Models;

/// <summary>
/// PostTextRequest
/// </summary>
public sealed class PostTextRequest
{
    /// <summary>
    /// ID of the bot to send the text to.
    /// </summary>
    public string BotId { get; set; }

    /// <summary>
    /// Alias/Version of the bot
    /// </summary>
    public string BotAlias { get; set; }

    /// <summary>
    /// the integration service id for the bot's credentials
    /// </summary>
    public string IntegrationId { get; set; }

    /// <summary>
    /// GUID for this bot's session
    /// </summary>
    public string BotSessionId { get; set; }

    /// <summary>
    /// Message to send to the bot
    /// </summary>
    public PostTextMessage PostTextMessage { get; set; }

    /// <summary>
    /// The launguage code the bot will run under
    /// </summary>
    public string LanguageCode { get; set; }

    /// <summary>
    /// Override timeout for the bot session. This should be greater than 10 minutes.
    /// </summary>
    public int? BotSessionTimeoutMinutes { get; set; }

    /// <summary>
    /// The channels this bot is utilizing
    /// </summary>
    public IEnumerable<PostTextRequestBotChannels> BotChannels { get; set; }

    /// <summary>
    /// Id for tracking the activity - this will be returned in the response
    /// </summary>
    public string BotCorrelationId { get; set; }

    /// <summary>
    /// If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics
    /// </summary>
    public PostTextRequestMessagingPlatformType? MessagingPlatformType { get; set; }

    /// <summary>
    /// Provider specific settings, if any
    /// </summary>
    public AmazonLexRequest AmazonLexRequest { get; set; }

    /// <summary>
    /// Provider specific settings, if any
    /// </summary>
    public GoogleDialogflowCustomSettings GoogleDialogflow { get; set; }

    /// <summary>
    /// Provider specific settings, if any
    /// </summary>
    public GenesysBotConnector GenesysBotConnector { get; set; }

    /// <summary>
    /// Provider specific settings, if any
    /// </summary>
    public NuanceMixDlgSettings NuanceMixDlg { get; set; }
}