using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models.Conversations;

public sealed class ConversationCallEventTopicJourneyContext
{
    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    public ConversationCallEventTopicJourneyCustomer Customer { get; set; }


    /// <summary>
    /// Gets or Sets CustomerSession
    /// </summary>
    public ConversationCallEventTopicJourneyCustomerSession CustomerSession { get; set; }


    /// <summary>
    /// Gets or Sets TriggeringAction
    /// </summary>
    public ConversationCallEventTopicJourneyAction TriggeringAction { get; set; }
}
