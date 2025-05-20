using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationVideoEventTopicConversationDivisionMembership
{
    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public ConversationVideoEventTopicDomainEntityRef Division { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ConversationVideoEventTopicDivisionEntityRef> Entities { get; set; }
}
