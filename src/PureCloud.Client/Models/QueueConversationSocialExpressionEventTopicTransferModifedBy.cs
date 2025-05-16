using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationSocialExpressionEventTopicTransferModifedBy
{
    /// <summary>
    /// The id of the user if the updater is an internal user.
    /// </summary>
    /// <value>The id of the user if the updater is an internal user.</value>
    public string Id { get; set; }

    /// <summary>
    /// The URI for the user if the updater is an internal user.
    /// </summary>
    /// <value>The URI for the user if the updater is an internal user.</value>
    public string SelfUri { get; set; }
}
