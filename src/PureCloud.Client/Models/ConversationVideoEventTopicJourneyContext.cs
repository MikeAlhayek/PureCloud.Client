using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationVideoEventTopicJourneyContext
{
    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    public ConversationVideoEventTopicJourneyCustomer Customer { get; set; }

    /// <summary>
    /// Gets or Sets CustomerSession
    /// </summary>
    public ConversationVideoEventTopicJourneyCustomerSession CustomerSession { get; set; }

    /// <summary>
    /// Gets or Sets TriggeringAction
    /// </summary>
    public ConversationVideoEventTopicJourneyAction TriggeringAction { get; set; }
}
