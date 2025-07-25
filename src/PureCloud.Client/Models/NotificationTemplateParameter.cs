using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NotificationTemplateParameter
{
    /// <summary>
    /// Parameter name.
    /// </summary>
    /// <value>Parameter name.</value>
    public string Name { get; set; }

    /// <summary>
    /// Parameter text value.
    /// </summary>
    /// <value>Parameter text value.</value>
    public string Text { get; set; }
}
