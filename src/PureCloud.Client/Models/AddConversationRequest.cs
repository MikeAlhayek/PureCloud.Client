using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AddConversationRequest
{
    /// <summary>
    /// The id of the conversation to add
    /// </summary>
    /// <value>The id of the conversation to add</value>
    public string ConversationId { get; set; }
}
