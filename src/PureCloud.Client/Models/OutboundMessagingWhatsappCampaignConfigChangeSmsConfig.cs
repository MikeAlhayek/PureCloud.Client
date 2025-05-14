using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingWhatsappCampaignConfigChangeSmsConfig
{
    /// <summary>
    /// The Contact List column specifying the message to send to the contact.
    /// </summary>
    /// <value>The Contact List column specifying the message to send to the contact.</value>
    public string MessageColumn { get; set; }

    /// <summary>
    /// The Contact List column specifying the phone number to send a message to.
    /// </summary>
    /// <value>The Contact List column specifying the phone number to send a message to.</value>
    public string PhoneColumn { get; set; }

    /// <summary>
    /// Gets or Sets SenderSmsPhoneNumber
    /// </summary>
    public OutboundMessagingWhatsappCampaignConfigChangeSmsPhoneNumberRef SenderSmsPhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets ContentTemplate
    /// </summary>
    public OutboundMessagingWhatsappCampaignConfigChangeResponseRef ContentTemplate { get; set; }
}
