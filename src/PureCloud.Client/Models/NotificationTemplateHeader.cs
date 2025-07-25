using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NotificationTemplateHeader
{
    /// <summary>
    /// Template header type.
    /// </summary>
    /// <value>Template header type.</value>
    public NotificationTemplateHeaderTypeEnum? Type { get; set; }

    /// <summary>
    /// Header text. For WhatsApp, ignored.
    /// </summary>
    /// <value>Header text. For WhatsApp, ignored.</value>
    public string Text { get; set; }

    /// <summary>
    /// Media template header image.
    /// </summary>
    /// <value>Media template header image.</value>
    public ContentAttachment Media { get; set; }

    /// <summary>
    /// Template parameters for placeholders in template.
    /// </summary>
    /// <value>Template parameters for placeholders in template.</value>
    public IEnumerable<NotificationTemplateParameter> Parameters { get; set; }
}
