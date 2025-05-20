using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserConversationsEventUserConversationSummary
{
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets Call
    /// </summary>
    public UserConversationsEventMediaSummary Call { get; set; }

    /// <summary>
    /// Gets or Sets Callback
    /// </summary>
    public UserConversationsEventMediaSummary Callback { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    public UserConversationsEventMediaSummary Email { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public UserConversationsEventMediaSummary Message { get; set; }

    /// <summary>
    /// Gets or Sets Chat
    /// </summary>
    public UserConversationsEventMediaSummary Chat { get; set; }

    /// <summary>
    /// Gets or Sets SocialExpression
    /// </summary>
    public UserConversationsEventMediaSummary SocialExpression { get; set; }

    /// <summary>
    /// Gets or Sets Video
    /// </summary>
    public UserConversationsEventMediaSummary Video { get; set; }
}
