using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MessageInfo
{
    /// <summary>
    /// Key that can be used to localize the message.
    /// </summary>
    /// <value>Key that can be used to localize the message.</value>
    public string LocalizableMessageCode { get; set; }

    /// <summary>
    /// Description of the message.
    /// </summary>
    /// <value>Description of the message.</value>
    public string Message { get; set; }

    /// <summary>
    /// Message with template fields for variable replacement.
    /// </summary>
    /// <value>Message with template fields for variable replacement.</value>
    public string MessageWithParams { get; set; }

    /// <summary>
    /// Map with fields for variable replacement.
    /// </summary>
    /// <value>Map with fields for variable replacement.</value>
    public Dictionary<string, string> MessageParams { get; set; }
}
