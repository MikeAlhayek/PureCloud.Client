using System.Text;
using System.Collections.Generic;

namespace PureCloud.Client.Models;

/// <summary>
/// Template notification object.
/// </summary>
public sealed class ConversationContentNotificationTemplate
{
    // The identifier of the message template in 'your-namespace@your-template-id/name' format.
    public string Id { get; set; }

    // Template language.
    public string Language { get; set; }

    // The template header.
    public ConversationNotificationTemplateHeader Header { get; set; }

    // The template body.
    public ConversationNotificationTemplateBody Body { get; set; }

    // Template buttons.
    public IEnumerable<ConversationNotificationTemplateButton> Buttons { get; set; }

    // The template footer.
    public ConversationNotificationTemplateFooter Footer { get; set; }
}
