using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// User reaction to public message.
/// </summary>
public sealed class ContentReaction
{
    /// <summary>
    /// Type of reaction.
    /// </summary>
    /// <value>Type of reaction.</value>
    public ReactionType? ReactionType { get; set; }

    /// <summary>
    /// Number of users that reacted this way to the message.
    /// </summary>
    /// <value>Number of users that reacted this way to the message.</value>
    public int? Count { get; set; }
}
