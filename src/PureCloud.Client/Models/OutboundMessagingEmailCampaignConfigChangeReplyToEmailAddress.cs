using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// An outbound-messaging messaging campaign email address
/// </summary>

public partial class OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress : IEquatable<OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress" /> class.
    /// </summary>
    /// <param name="Domain">A UriReference for a resource.</param>
    /// <param name="Route">A UriReference for a resource.</param>
    public OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress(OutboundMessagingEmailCampaignConfigChangeUriReference Domain = null, OutboundMessagingEmailCampaignConfigChangeUriReference Route = null)
    {
        this.Domain = Domain;
        this.Route = Route;

    }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("domain")]
    public OutboundMessagingEmailCampaignConfigChangeUriReference Domain { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("route")]
    public OutboundMessagingEmailCampaignConfigChangeUriReference Route { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress {\n");

        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Route: ").Append(Route).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress);
    }

    /// <summary>
    /// Returns true if OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingEmailCampaignConfigChangeReplyToEmailAddress other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
            ) &&
            (
                Route == other.Route ||
                Route != null &&
                Route.Equals(other.Route)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            if (Route != null)
            {
                hash = hash * 59 + Route.GetHashCode();
            }

            return hash;
        }
    }
}
