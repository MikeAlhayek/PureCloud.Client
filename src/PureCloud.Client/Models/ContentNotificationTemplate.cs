using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContentNotificationTemplate
{
    /// <summary>
    /// The messaging provider template ID. For WhatsApp, &#39;namespace@name&#39;.
    /// </summary>
    /// <value>The messaging provider template ID. For WhatsApp, &#39;namespace@name&#39;.</value>
    public string Id { get; set; }

    /// <summary>
    /// Template language.
    /// </summary>
    /// <value>Template language.</value>
    public string Language { get; set; }

    /// <summary>
    /// The template header.
    /// </summary>
    public NotificationTemplateHeader Header { get; set; }

    /// <summary>
    /// The template body.
    /// </summary>
    /// <value>The template body.</value>
    public NotificationTemplateBody Body { get; set; }

    /// <summary>
    /// Template buttons
    /// </summary>
    /// <value>Template buttons</value>
    public IEnumerable<NotificationTemplateButton> Buttons { get; set; }

    /// <summary>
    /// The template footer.
    /// </summary>
    /// <value>The template footer.</value>
    public NotificationTemplateFooter Footer { get; set; }
}
