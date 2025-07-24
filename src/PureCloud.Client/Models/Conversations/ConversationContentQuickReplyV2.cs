using System.Text;
using System.Collections.Generic;

namespace PureCloud.Client.Models;

/// <summary>
/// Quick reply object V2.
/// </summary>
public sealed class ConversationContentQuickReplyV2
{
    // Text to show as the title of the quick reply.
    public string Title { get; set; }

    // An array of quick reply objects.
    public IEnumerable<ConversationContentQuickReply> Actions { get; set; }
}
