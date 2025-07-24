using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RecordingTemplateButton
{
    /// <summary>
    /// Specifies the type of the button.
    /// </summary>
    /// <value>Specifies the type of the button.</value>
    public RecordingTemplateButtonTypeEnum? Type { get; set; }

    /// <summary>
    /// Button text message.
    /// </summary>
    /// <value>Button text message.</value>
    public string Text { get; set; }

    /// <summary>
    /// Index of the button in the list.
    /// </summary>
    /// <value>Index of the button in the list.</value>
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
    /// Indicates if the button is selected by end customer.
    /// </summary>
    /// <value>Indicates if the button is selected by end customer.</value>
    public bool? IsSelected { get; set; }
}
