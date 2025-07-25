namespace PureCloud.Client.Models;

/// <summary>
/// An ephemeral story.
/// </summary>
public sealed class ContentStory
{
    /// <summary>
    /// Type of ephemeral story attachment.
    /// </summary>
    /// <value>Type of ephemeral story attachment.</value>
    public ContentStoryType? Type { get; set; }

    /// <summary>
    /// URL to the ephemeral story.
    /// </summary>
    /// <value>URL to the ephemeral story.</value>
    public string Url { get; set; }

    /// <summary>
    /// ID of the ephemeral story being replied to.
    /// </summary>
    /// <value>ID of the ephemeral story being replied to.</value>
    public string ReplyToId { get; set; }
}
