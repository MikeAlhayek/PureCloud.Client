namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).
/// </summary>

public sealed class ConversationEventTopicJourneyContext
{
    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    public ConversationEventTopicJourneyCustomer Customer { get; set; }

    /// <summary>
    /// Gets or Sets CustomerSession
    /// </summary>
    public ConversationEventTopicJourneyCustomerSession CustomerSession { get; set; }

    /// <summary>
    /// Gets or Sets TriggeringAction
    /// </summary>
    public ConversationEventTopicJourneyAction TriggeringAction { get; set; }
}
