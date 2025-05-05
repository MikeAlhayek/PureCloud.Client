using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// An outbound-messaging messaging campaign email address
/// </summary>

public partial class OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress : IEquatable<OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress" /> class.
    /// </summary>
    /// <param name="FriendlyName">The friendly name of the email address..</param>
    /// <param name="LocalPart">The local part of the email address..</param>
    /// <param name="Domain">A UriReference for a resource.</param>
    public OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress(string FriendlyName = null, string LocalPart = null, OutboundMessagingWhatsappCampaignConfigChangeUriReference Domain = null)
    {
        this.FriendlyName = FriendlyName;
        this.LocalPart = LocalPart;
        this.Domain = Domain;

    }



    /// <summary>
    /// The friendly name of the email address.
    /// </summary>
    /// <value>The friendly name of the email address.</value>
    [JsonPropertyName("friendlyName")]
    public string FriendlyName { get; set; }



    /// <summary>
    /// The local part of the email address.
    /// </summary>
    /// <value>The local part of the email address.</value>
    [JsonPropertyName("localPart")]
    public string LocalPart { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("domain")]
    public OutboundMessagingWhatsappCampaignConfigChangeUriReference Domain { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress {\n");

        sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
        sb.Append("  LocalPart: ").Append(LocalPart).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
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
        return Equals(obj as OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress);
    }

    /// <summary>
    /// Returns true if OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FriendlyName == other.FriendlyName ||
                FriendlyName != null &&
                FriendlyName.Equals(other.FriendlyName)
            ) &&
            (
                LocalPart == other.LocalPart ||
                LocalPart != null &&
                LocalPart.Equals(other.LocalPart)
            ) &&
            (
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
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
            if (FriendlyName != null)
            {
                hash = hash * 59 + FriendlyName.GetHashCode();
            }

            if (LocalPart != null)
            {
                hash = hash * 59 + LocalPart.GetHashCode();
            }

            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            return hash;
        }
    }
}
