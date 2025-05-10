namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// A subset of the Journey System&#39;s tracked customer session data at a point-in-time (for external linkage and internal usage/context)
/// </summary>

public sealed class ConversationEventTopicJourneyCustomerSession
{
    /// <summary>
    /// An ID of a Customer/User&#39;s session within the Journey System at a point-in-time
    /// </summary>
    /// <value>An ID of a Customer/User&#39;s session within the Journey System at a point-in-time</value>
    public string Id { get; set; }

    /// <summary>
    /// The type of the Customer/User&#39;s session within the Journey System (e.g. web, app)
    /// </summary>
    /// <value>The type of the Customer/User&#39;s session within the Journey System (e.g. web, app)</value>
    public string Type { get; set; }
}
