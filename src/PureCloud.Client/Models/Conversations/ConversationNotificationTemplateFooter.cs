using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Template footer object.
/// </summary>
public sealed class ConversationNotificationTemplateFooter
{
    // Footer text. For WhatsApp, ignored.
    public string Text { get; set; }
}
