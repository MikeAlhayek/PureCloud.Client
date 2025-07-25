using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContentQuickReplyV2
{
    /// <summary>
    /// Text to show as the title of the quick reply.
    /// </summary>
    /// <value>Text to show as the title of the quick reply.</value>
    public string Title { get; set; }

    /// <summary>
    /// An array of quick reply objects.
    /// </summary>
    /// <value>An array of quick reply objects.</value>
    public IEnumerable<ContentQuickReply> Actions { get; set; }
}
