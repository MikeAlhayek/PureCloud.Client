using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NotificationTemplateBody
{
    /// <summary>
    /// Body text. For WhatsApp, ignored.
    /// </summary>
    /// <value>Body text. For WhatsApp, ignored.</value>
    public string Text { get; set; }

    /// <summary>
    /// Template parameters for placeholders in template.
    /// </summary>
    /// <value>Template parameters for placeholders in template.</value>
    public IEnumerable<NotificationTemplateParameter> Parameters { get; set; }
}
