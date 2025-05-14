using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingEmailCampaignConfigChangeFromEmailAddress
{
    /// <summary>
    /// The friendly name of the email address.
    /// </summary>
    /// <value>The friendly name of the email address.</value>
    public string FriendlyName { get; set; }

    /// <summary>
    /// The local part of the email address.
    /// </summary>
    /// <value>The local part of the email address.</value>
    public string LocalPart { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public OutboundMessagingEmailCampaignConfigChangeUriReference Domain { get; set; }
}
