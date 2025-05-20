using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationMessageEventTopicJourneyContext
{
    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    public ConversationMessageEventTopicJourneyCustomer Customer { get; set; }

    /// <summary>
    /// Gets or Sets CustomerSession
    /// </summary>
    public ConversationMessageEventTopicJourneyCustomerSession CustomerSession { get; set; }

    /// <summary>
    /// Gets or Sets TriggeringAction
    /// </summary>
    public ConversationMessageEventTopicJourneyAction TriggeringAction { get; set; }
}
