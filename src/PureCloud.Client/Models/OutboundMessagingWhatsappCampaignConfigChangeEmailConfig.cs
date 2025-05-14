using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingWhatsappCampaignConfigChangeEmailConfig
{
    /// <summary>
    /// The Contact List column specifying the email to send to the contact.
    /// </summary>
    /// <value>The Contact List column specifying the email to send to the contact.</value>
    public IEnumerable<string> EmailColumns { get; set; }

    /// <summary>
    /// A reference for a Response
    /// </summary>
    /// <value>A reference for a Response</value>
    public OutboundMessagingWhatsappCampaignConfigChangeResponseRef ContentTemplate { get; set; }

    /// <summary>
    /// Gets or Sets FromAddress
    /// </summary>
    public OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress FromAddress { get; set; }

    /// <summary>
    /// Gets or Sets ReplyToAddress
    /// </summary>
    public OutboundMessagingWhatsappCampaignConfigChangeReplyToEmailAddress ReplyToAddress { get; set; }
}
