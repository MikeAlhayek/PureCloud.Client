using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationScreenShareEventTopicConversationDivisionMembership
{
    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public ConversationScreenShareEventTopicDomainEntityRef Division { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ConversationScreenShareEventTopicDivisionEntityRef> Entities { get; set; }
}
