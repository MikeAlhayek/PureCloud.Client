using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NotificationTemplateButton
{
    /// <summary>
    /// Specifies the type of the button.
    /// </summary>
    /// <value>Specifies the type of the button.</value>
    public NotificationTemplateButtonTypeEnum? Type { get; set; }

    /// <summary>
    /// Button text message.
    /// </summary>
    /// <value>Button text message.</value>
    public string Text { get; set; }

    /// <summary>
    /// index of the button in the list.
    /// </summary>
    /// <value>index of the button in the list.</value>
    public long? Index { get; set; }

    /// <summary>
    /// Button phone number.
    /// </summary>
    /// <value>Button phone number.</value>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Button URL link.
    /// </summary>
    /// <value>Button URL link.</value>
    public string Url { get; set; }

    /// <summary>
    /// Template parameters for placeholders in the button.
    /// </summary>
    /// <value>Template parameters for placeholders in the button.</value>
    public IEnumerable<NotificationTemplateParameter> Parameters { get; set; }
}
