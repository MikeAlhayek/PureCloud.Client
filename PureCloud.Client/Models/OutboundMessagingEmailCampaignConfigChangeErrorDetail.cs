using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingEmailCampaignConfigChangeErrorDetail
/// </summary>

public partial class OutboundMessagingEmailCampaignConfigChangeErrorDetail : IEquatable<OutboundMessagingEmailCampaignConfigChangeErrorDetail>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingEmailCampaignConfigChangeErrorDetail" /> class.
    /// </summary>
    /// <param name="Error">The name of the error code..</param>
    /// <param name="Details">The additional information regarding the error message..</param>
    public OutboundMessagingEmailCampaignConfigChangeErrorDetail(string Error = null, string Details = null)
    {
        this.Error = Error;
        this.Details = Details;

    }



    /// <summary>
    /// The name of the error code.
    /// </summary>
    /// <value>The name of the error code.</value>
    [JsonPropertyName("error")]
    public string Error { get; set; }



    /// <summary>
    /// The additional information regarding the error message.
    /// </summary>
    /// <value>The additional information regarding the error message.</value>
    [JsonPropertyName("details")]
    public string Details { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingEmailCampaignConfigChangeErrorDetail {\n");

        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  Details: ").Append(Details).Append("\n");
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
        return Equals(obj as OutboundMessagingEmailCampaignConfigChangeErrorDetail);
    }

    /// <summary>
    /// Returns true if OutboundMessagingEmailCampaignConfigChangeErrorDetail instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingEmailCampaignConfigChangeErrorDetail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingEmailCampaignConfigChangeErrorDetail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
            ) &&
            (
                Details == other.Details ||
                Details != null &&
                Details.Equals(other.Details)
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
            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (Details != null)
            {
                hash = hash * 59 + Details.GetHashCode();
            }

            return hash;
        }
    }
}
