using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationUserDisposition
{
    /// <summary>
    /// User-defined wrap-up code for the conversation.
    /// </summary>
    /// <value>User-defined wrap-up code for the conversation.</value>
    public string Code { get; set; }

    /// <summary>
    /// Text entered by the user to describe the call or disposition.
    /// </summary>
    /// <value>Text entered by the user to describe the call or disposition.</value>
    public string Notes { get; set; }

    /// <summary>
    /// The user that wrapped up the conversation.
    /// </summary>
    /// <value>The user that wrapped up the conversation.</value>
    public AddressableEntityRef User { get; set; }
}
