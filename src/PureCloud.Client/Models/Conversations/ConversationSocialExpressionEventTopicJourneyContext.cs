using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationSocialExpressionEventTopicJourneyContext
{
    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    public ConversationSocialExpressionEventTopicJourneyCustomer Customer { get; set; }

    /// <summary>
    /// Gets or Sets CustomerSession
    /// </summary>
    public ConversationSocialExpressionEventTopicJourneyCustomerSession CustomerSession { get; set; }

    /// <summary>
    /// Gets or Sets TriggeringAction
    /// </summary>
    public ConversationSocialExpressionEventTopicJourneyAction TriggeringAction { get; set; }
}
