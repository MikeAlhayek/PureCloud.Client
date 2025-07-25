namespace PureCloud.Client.Models;

/// <summary>
/// Deprecated, should use Card.
/// </summary>
public sealed class ContentGeneric
{
    /// <summary>
    /// Text to show in the title.
    /// </summary>
    /// <value>Text to show in the title.</value>
    public string Title { get; set; }

    /// <summary>
    /// Text to show in the description.
    /// </summary>
    /// <value>Text to show in the description.</value>
    public string Description { get; set; }

    /// <summary>
    /// URL of an image.
    /// </summary>
    /// <value>URL of an image.</value>
    public string Image { get; set; }

    /// <summary>
    /// URL of a video.
    /// </summary>
    /// <value>URL of a video.</value>
    public string Video { get; set; }

    /// <summary>
    /// Actions to be taken (Deprecated).
    /// </summary>
    /// <value>Actions to be taken (Deprecated).</value>
    public ContentActions Actions { get; set; }

    /// <summary>
    /// An array of component objects.
    /// </summary>
    /// <value>An array of component objects.</value>
    public IEnumerable<ButtonComponent> Components { get; set; }
}
