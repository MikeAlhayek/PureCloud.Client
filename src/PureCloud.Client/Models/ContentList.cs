using System.Text;
using System.Text.Json.Serialization;
using System.Linq;

namespace PureCloud.Client.Models;

public sealed class ContentList
{
    /// <summary>
    /// The type of list this instance represents.
    /// </summary>
    /// <value>The type of list this instance represents.</value>
    public ContentListListTypeEnum? ListType { get; set; }

    /// <summary>
    /// A unique ID assigned to this rich message content.
    /// </summary>
    /// <value>A unique ID assigned to this rich message content.</value>
    public string Id { get; set; }

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
    /// Label for Submit button.
    /// </summary>
    /// <value>Label for Submit button.</value>
    public string SubmitLabel { get; set; }

    /// <summary>
    /// The list actions (Deprecated).
    /// </summary>
    /// <value>The list actions (Deprecated).</value>
    public ContentActions Actions { get; set; }

    /// <summary>
    /// An array of component objects.
    /// </summary>
    /// <value>An array of component objects.</value>
    public IEnumerable<ListItemComponent> Components { get; set; }
}
