using System.Runtime.Serialization;
using System.Text;
using System.Collections.Generic;

namespace PureCloud.Client.Models;

/// <summary>
/// Template button object
/// </summary>
public sealed class ConversationNotificationTemplateButton
{
    // Specifies the type of the button.
    public Type? Type { get; set; }

    // Button text message.
    public string Text { get; set; }

    // Index of the button in the list.
    public long? Index { get; set; }

    // Button phone number.
    public string PhoneNumber { get; set; }

    // Button URL link.
    public string Url { get; set; }

    // Template parameters for placeholders in the button.
    public IEnumerable<ConversationNotificationTemplateParameter> Parameters { get; set; }
}
