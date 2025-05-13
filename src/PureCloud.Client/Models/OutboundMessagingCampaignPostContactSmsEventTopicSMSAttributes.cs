using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes
{
    /// <summary>
    /// Gets or Sets ContactPhoneNumber
    /// </summary>
    public string ContactPhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets ContactPhoneNumberColumnName
    /// </summary>
    public string ContactPhoneNumberColumnName { get; set; }

    /// <summary>
    /// Gets or Sets ConfiguredSenderPhoneNumber
    /// </summary>
    public string ConfiguredSenderPhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets SenderPhoneNumber
    /// </summary>
    public string SenderPhoneNumber { get; set; }
}
