using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A reference for an SmsPhoneNumber
/// </summary>

public partial class OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef : IEquatable<OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef" /> class.
    /// </summary>
    /// <param name="PhoneNumber">The unique phone number.</param>
    public OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef(string PhoneNumber = null)
    {
        this.PhoneNumber = PhoneNumber;

    }



    /// <summary>
    /// The unique phone number
    /// </summary>
    /// <value>The unique phone number</value>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef {\n");

        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
        return Equals(obj as OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef);
    }

    /// <summary>
    /// Returns true if OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
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
            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            return hash;
        }
    }
}
