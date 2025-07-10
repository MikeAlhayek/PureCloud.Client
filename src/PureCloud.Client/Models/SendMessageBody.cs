using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SendMessageBody
{   /// <summary>
    /// The body of the message
    /// </summary>
    /// <value>The body of the message</value>
    public string Message { get; set; }

    /// <summary>
    /// user ids to be notified
    /// </summary>
    /// <value>user ids to be notified</value>
    public IEnumerable<string> Mentions { get; set; }

    /// <summary>
    /// The thread id of the message
    /// </summary>
    /// <value>The thread id of the message</value>
    public string ThreadId { get; set; }
}
