using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Component for a list item.
/// </summary>
public sealed class ListItemComponent
{
    /// <summary>
    /// Type of the component.
    /// </summary>
    /// <value>Type of the component.</value>
    public string Type { get; set; }

    /// <summary>
    /// Text to show as the title of the list item.
    /// </summary>
    /// <value>Text to show as the title of the list item.</value>
    public string Title { get; set; }

    /// <summary>
    /// Text to show in the description of the list item.
    /// </summary>
    /// <value>Text to show in the description of the list item.</value>
    public string Description { get; set; }

    /// <summary>
    /// Actions associated with this list item.
    /// </summary>
    /// <value>Actions associated with this list item.</value>
    public ContentActions Actions { get; set; }
}
