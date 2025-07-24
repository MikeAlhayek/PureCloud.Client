using System.Text;
using System.Collections.Generic;

namespace PureCloud.Client.Models;

/// <summary>
/// Template body object.
/// </summary>
public sealed class ConversationNotificationTemplateBody
{
    // Body text. For WhatsApp, ignored.
    public string Text { get; set; }

    // Template parameters for placeholders in template.
    public IEnumerable<ConversationNotificationTemplateParameter> Parameters { get; set; }
}
