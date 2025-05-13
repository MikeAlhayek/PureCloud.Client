using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress
{
    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public OutboundMessagingMessagingCampaignConfigChangeUriReference Domain { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public OutboundMessagingMessagingCampaignConfigChangeUriReference Route { get; set; }
}
