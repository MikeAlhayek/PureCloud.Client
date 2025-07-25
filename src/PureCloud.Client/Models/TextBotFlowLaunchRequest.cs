namespace PureCloud.Client.Models;

/// <summary>
/// Settings for launching an instance of a bot flow.
/// </summary>
public sealed class TextBotFlowLaunchRequest
{
    /// <summary>
    /// Specifies which Bot Flow to launch.
    /// </summary>
    public TextBotFlow Flow { get; set; }

    /// <summary>
    /// The ID of the external session that is associated with the bot flow.
    /// </summary>
    public string ExternalSessionId { get; set; }

    /// <summary>
    /// A conversation ID to associate with the bot flow, if available.
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Input values to the flow. Valid values are defined by the flow's input JSON schema.
    /// </summary>
    public TextBotInputOutputData InputData { get; set; }

    /// <summary>
    /// Channel information relevant to the bot flow.
    /// </summary>
    public TextBotChannel Channel { get; set; }

    /// <summary>
    /// The language that the bot will use in the session. Validated against list of supported languages and if the value is omitted or is invalid, the default language will be used.
    /// </summary>
    public string Language { get; set; }
}