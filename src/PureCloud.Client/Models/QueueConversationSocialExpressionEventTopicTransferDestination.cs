using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationSocialExpressionEventTopicTransferDestination
{
    /// <summary>
    /// The id of the user if the command destination is a user.
    /// </summary>
    /// <value>The id of the user if the command destination is a user.</value>
    public string UserId { get; set; }

    /// <summary>
    /// The destination address if the command destination is an endpoint.
    /// </summary>
    /// <value>The destination address if the command destination is an endpoint.</value>
    public string Address { get; set; }
}
