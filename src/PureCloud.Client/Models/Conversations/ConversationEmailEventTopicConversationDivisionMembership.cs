using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationEmailEventTopicConversationDivisionMembership
{
    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public ConversationEmailEventTopicDomainEntityRef Division { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ConversationEmailEventTopicDivisionEntityRef> Entities { get; set; }
}
