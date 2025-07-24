namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaDetailMessageContainer
/// </summary>
public sealed class SocialMediaDetailMessageContainer
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets NormalizedMessage
    /// </summary>
    public ConversationNormalizedMessage NormalizedMessage { get; set; }

    /// <summary>
    /// Gets or Sets EscalationInfo
    /// </summary>
    public SocialMediaMessageEscalationInfo EscalationInfo { get; set; }
}