using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Quick reply object.
/// </summary>
public sealed class ConversationContentQuickReply
{
    // Specifies the type of action that is triggered upon clicking the quick reply.
    public Action Action { get; set; }

    // Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.
    public string Text { get; set; }

    // Content of the payload included in the quick reply response. Could be an ID identifying the quick reply response.
    public string Payload { get; set; }

    // URL of an image associated with the quick reply.
    public string Image { get; set; }
}
