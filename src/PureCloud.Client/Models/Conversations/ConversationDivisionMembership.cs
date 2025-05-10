namespace PureCloud.Client.Models;

public sealed class ConversationDivisionMembership
{
    /// <summary>
    /// A division the conversation belongs to.
    /// </summary>
    /// <value>A division the conversation belongs to.</value>
    public DomainEntityRef Division { get; set; }

    /// <summary>
    /// The entities on the conversation within the division. These are the users, queues, work flows, etc. that can be on conversations and and be assigned to different divisions.
    /// </summary>
    /// <value>The entities on the conversation within the division. These are the users, queues, work flows, etc. that can be on conversations and and be assigned to different divisions.</value>
    public IEnumerable<DivisionEntityRef> Entities { get; set; }
}
