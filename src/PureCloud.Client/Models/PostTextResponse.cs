namespace PureCloud.Client.Models;

/// <summary>
/// PostTextResponse
/// </summary>
public sealed class PostTextResponse
{
    /// <summary>
    /// The state of the bot after completion of the request
    /// </summary>
    public PostTextResponseBotState? BotState { get; set; }

    /// <summary>
    /// The list of messages to respond with, if any
    /// </summary>
    public IEnumerable<PostTextMessage> ReplyMessages { get; set; }

    /// <summary>
    /// The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected.
    /// </summary>
    public string IntentName { get; set; }

    /// <summary>
    /// Data parameters detected and filled by the bot.
    /// </summary>
    public Dictionary<string, string> Slots { get; set; }

    /// <summary>
    /// The optional ID specified in the request
    /// </summary>
    public string BotCorrelationId { get; set; }

    /// <summary>
    /// Raw data response from AWS (if called)
    /// </summary>
    public Dictionary<string, object> AmazonLex { get; set; }

    /// <summary>
    /// Raw data response from Google Dialogflow (if called)
    /// </summary>
    public Dictionary<string, object> GoogleDialogFlow { get; set; }

    /// <summary>
    /// Raw data response from Genesys' Dialogengine (if called)
    /// </summary>
    public Dictionary<string, object> GenesysDialogEngine { get; set; }

    /// <summary>
    /// Raw data response from Genesys' BotConnector (if called)
    /// </summary>
    public Dictionary<string, object> GenesysBotConnector { get; set; }

    /// <summary>
    /// Raw data response from Nuance Mix Dlg (if called)
    /// </summary>
    public Dictionary<string, object> NuanceMixDlg { get; set; }
}