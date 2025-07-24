using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// An ephemeral story.
/// </summary>
public sealed class ConversationContentStory
{
    // Type of ephemeral story attachment.
    public Type? Type { get; set; }

    // URL to the ephemeral story.
    public string Url { get; set; }

    // ID of the ephemeral story being replied to.
    public string ReplyToId { get; set; }
}
