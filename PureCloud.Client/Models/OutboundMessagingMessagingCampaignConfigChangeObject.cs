using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingMessagingCampaignConfigChangeObject
/// </summary>

public partial class OutboundMessagingMessagingCampaignConfigChangeObject : IEquatable<OutboundMessagingMessagingCampaignConfigChangeObject>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeObject" /> class.
    /// </summary>
    public OutboundMessagingMessagingCampaignConfigChangeObject()
    {

    }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingMessagingCampaignConfigChangeObject {\n");

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
        return Equals(obj as OutboundMessagingMessagingCampaignConfigChangeObject);
    }

    /// <summary>
    /// Returns true if OutboundMessagingMessagingCampaignConfigChangeObject instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeObject to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingMessagingCampaignConfigChangeObject other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true && false;
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
            return hash;
        }
    }
}
