using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingEmailCampaignConfigChangeSmsPhoneNumberRef
{
    /// <summary>
    /// The unique phone number
    /// </summary>
    /// <value>The unique phone number</value>
    public string PhoneNumber { get; set; }
}
