using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class ContentCard
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
    /// The default button action.
    /// </summary>
    /// <value>The default button action.</value>
    public ContentCardAction DefaultAction { get; set; }

    /// <summary>
    /// An array of action objects.
    /// </summary>
    /// <value>An array of action objects.</value>
    public IEnumerable<ContentCardAction> Actions { get; set; }
}
