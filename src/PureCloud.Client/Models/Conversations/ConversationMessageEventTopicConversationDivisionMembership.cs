using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationMessageEventTopicConversationDivisionMembership
{
    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public ConversationMessageEventTopicDomainEntityRef Division { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ConversationMessageEventTopicDivisionEntityRef> Entities { get; set; }
}
