using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Message content element containing text only.
/// </summary>
public sealed class ConversationContentText
{
    // Type of text content (Deprecated).
    public Type? Type { get; set; }

    // Text to be shown for this content element.
    public string Body { get; set; }
}
