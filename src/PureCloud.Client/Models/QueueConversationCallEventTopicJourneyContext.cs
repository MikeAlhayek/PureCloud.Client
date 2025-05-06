using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationCallEventTopicJourneyContext
{
    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    public QueueConversationCallEventTopicJourneyCustomer Customer { get; set; }

    /// <summary>
    /// Gets or Sets CustomerSession
    /// </summary>
    public QueueConversationCallEventTopicJourneyCustomerSession CustomerSession { get; set; }

    /// <summary>
    /// Gets or Sets TriggeringAction
    /// </summary>
    public QueueConversationCallEventTopicJourneyAction TriggeringAction { get; set; }
}
