using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig
{
    /// <summary>
    /// The Contact List columns specifying the phone number to send a message to.
    /// </summary>
    /// <value>The Contact List columns specifying the phone number to send a message to.</value>
    public IEnumerable<string> WhatsAppColumns { get; set; }

    /// <summary>
    /// Gets or Sets Integration
    /// </summary>
    public OutboundMessagingMessagingCampaignConfigChangeIntegrationRef Integration { get; set; }

    /// <summary>
    /// A reference for a Response
    /// </summary>
    /// <value>A reference for a Response</value>
    public OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate { get; set; }
}
