using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NotificationTemplateFooter
{
    /// <summary>
    /// Footer text. For WhatsApp, ignored.
    /// </summary>
    /// <value>Footer text. For WhatsApp, ignored.</value>
    public string Text { get; set; }
}
