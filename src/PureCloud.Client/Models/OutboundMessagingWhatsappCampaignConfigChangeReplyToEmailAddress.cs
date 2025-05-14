using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingWhatsappCampaignConfigChangeReplyToEmailAddress
{
    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public OutboundMessagingWhatsappCampaignConfigChangeUriReference Domain { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public OutboundMessagingWhatsappCampaignConfigChangeUriReference Route { get; set; }
}
