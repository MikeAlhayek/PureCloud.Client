using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress
{
    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public OutboundMessagingEmailCampaignConfigChangeUriReference Domain { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public OutboundMessagingEmailCampaignConfigChangeUriReference Route { get; set; }
}
