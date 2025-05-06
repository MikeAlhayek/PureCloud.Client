using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationCallEventTopicConversationDivisionMembership
{
    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public ConversationCallEventTopicDomainEntityRef Division { get; set; }


    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ConversationCallEventTopicDivisionEntityRef> Entities { get; set; }
}
