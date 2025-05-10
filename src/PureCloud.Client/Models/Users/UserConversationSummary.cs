namespace PureCloud.Client.Models.Users;

/// <summary>
/// UserConversationSummary
/// </summary>

public sealed class UserConversationSummary
{
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets Call
    /// </summary>
    public MediaSummary Call { get; set; }

    /// <summary>
    /// Gets or Sets Callback
    /// </summary>
    public MediaSummary Callback { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    public MediaSummary Email { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public MediaSummary Message { get; set; }

    /// <summary>
    /// Gets or Sets Chat
    /// </summary>
    public MediaSummary Chat { get; set; }

    /// <summary>
    /// Gets or Sets SocialExpression
    /// </summary>
    public MediaSummary SocialExpression { get; set; }

    /// <summary>
    /// Gets or Sets Video
    /// </summary>
    public MediaSummary Video { get; set; }
}
