namespace PureCloud.Client.Models;

/// <summary>
/// Information related to a successful launch of a bot flow. The ID will be used in subsequent turn requests of the bot flow.
/// </summary>
public sealed class TextBotFlowLaunchResponse
{
    /// <summary>
    /// The session ID of the bot flow, used to send to subsequent turn requests
    /// </summary>
    public string Id { get; set; }
}
