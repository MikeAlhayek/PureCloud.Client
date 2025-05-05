namespace PureCloud.Client.Models;

public sealed class ConversationEventTopicConversationDivisionMembership
{
    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public ConversationEventTopicDomainEntityRef Division { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ConversationEventTopicDivisionEntityRef> Entities { get; set; }
}
