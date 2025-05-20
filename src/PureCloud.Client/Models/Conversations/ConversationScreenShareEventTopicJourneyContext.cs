using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationScreenShareEventTopicJourneyContext
{
    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    public ConversationScreenShareEventTopicJourneyCustomer Customer { get; set; }

    /// <summary>
    /// Gets or Sets CustomerSession
    /// </summary>
    public ConversationScreenShareEventTopicJourneyCustomerSession CustomerSession { get; set; }

    /// <summary>
    /// Gets or Sets TriggeringAction
    /// </summary>
    public ConversationScreenShareEventTopicJourneyAction TriggeringAction { get; set; }
}
