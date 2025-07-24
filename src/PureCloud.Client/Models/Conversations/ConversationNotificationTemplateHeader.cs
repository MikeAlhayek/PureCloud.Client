using System.Text;
using System.Collections.Generic;

namespace PureCloud.Client.Models;

/// <summary>
/// Template header object.
/// </summary>
public sealed class ConversationNotificationTemplateHeader
{
    // Template header type.
    public Type? Type { get; set; }

    // Header text. For WhatsApp, ignored.
    public string Text { get; set; }

    // Media template header image.
    public ConversationContentAttachment Media { get; set; }

    // Template parameters for placeholders in template.
    public IEnumerable<ConversationNotificationTemplateParameter> Parameters { get; set; }
}
