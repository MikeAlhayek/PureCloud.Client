using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Template parameters for placeholders in template.
/// </summary>
public sealed class ConversationNotificationTemplateParameter
{
    // Parameter name.
    public string Name { get; set; }

    // Parameter text value.
    public string Text { get; set; }
}
