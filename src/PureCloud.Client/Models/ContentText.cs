namespace PureCloud.Client.Models;

/// <summary>
/// Message content element containing text only.
/// </summary>
public sealed class ContentText
{
    /// <summary>
    /// Type of text content.
    /// </summary>
    /// <value>Type of text content.</value>
    public ContentTextType? Type { get; set; }

    /// <summary>
    /// Text to be shown for this content element.
    /// </summary>
    /// <value>Text to be shown for this content element.</value>
    public string Body { get; set; }
}
