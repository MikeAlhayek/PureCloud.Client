using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationCallEventTopicConversationDivisionMembership
{
    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public QueueConversationCallEventTopicDomainEntityRef Division { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<QueueConversationCallEventTopicDivisionEntityRef> Entities { get; set; }
}
