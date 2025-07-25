using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ButtonComponent
{
    /// <summary>
    /// Text to show inside the button.
    /// </summary>
    /// <value>Text to show inside the button.</value>
    public string Title { get; set; }

    /// <summary>
    /// The button actions (Deprecated).
    /// </summary>
    /// <value>The button actions (Deprecated).</value>
    public ContentActions Actions { get; set; }
}
