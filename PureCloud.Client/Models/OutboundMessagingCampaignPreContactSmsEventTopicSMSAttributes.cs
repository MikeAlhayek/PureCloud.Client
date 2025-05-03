using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes
/// </summary>

public partial class OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes : IEquatable<OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes" /> class.
    /// </summary>
    /// <param name="ContactPhoneNumber">ContactPhoneNumber.</param>
    /// <param name="ContactPhoneNumberColumnName">ContactPhoneNumberColumnName.</param>
    /// <param name="ConfiguredSenderPhoneNumber">ConfiguredSenderPhoneNumber.</param>
    /// <param name="SenderPhoneNumber">SenderPhoneNumber.</param>
    public OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes(string ContactPhoneNumber = null, string ContactPhoneNumberColumnName = null, string ConfiguredSenderPhoneNumber = null, string SenderPhoneNumber = null)
    {
        this.ContactPhoneNumber = ContactPhoneNumber;
        this.ContactPhoneNumberColumnName = ContactPhoneNumberColumnName;
        this.ConfiguredSenderPhoneNumber = ConfiguredSenderPhoneNumber;
        this.SenderPhoneNumber = SenderPhoneNumber;

    }



    /// <summary>
    /// Gets or Sets ContactPhoneNumber
    /// </summary>
    [JsonPropertyName("contactPhoneNumber")]
    public string ContactPhoneNumber { get; set; }



    /// <summary>
    /// Gets or Sets ContactPhoneNumberColumnName
    /// </summary>
    [JsonPropertyName("contactPhoneNumberColumnName")]
    public string ContactPhoneNumberColumnName { get; set; }



    /// <summary>
    /// Gets or Sets ConfiguredSenderPhoneNumber
    /// </summary>
    [JsonPropertyName("configuredSenderPhoneNumber")]
    public string ConfiguredSenderPhoneNumber { get; set; }



    /// <summary>
    /// Gets or Sets SenderPhoneNumber
    /// </summary>
    [JsonPropertyName("senderPhoneNumber")]
    public string SenderPhoneNumber { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes {\n");

        sb.Append("  ContactPhoneNumber: ").Append(ContactPhoneNumber).Append("\n");
        sb.Append("  ContactPhoneNumberColumnName: ").Append(ContactPhoneNumberColumnName).Append("\n");
        sb.Append("  ConfiguredSenderPhoneNumber: ").Append(ConfiguredSenderPhoneNumber).Append("\n");
        sb.Append("  SenderPhoneNumber: ").Append(SenderPhoneNumber).Append("\n");
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
        return Equals(obj as OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes);
    }

    /// <summary>
    /// Returns true if OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingCampaignPreContactSmsEventTopicSMSAttributes other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContactPhoneNumber == other.ContactPhoneNumber ||
                ContactPhoneNumber != null &&
                ContactPhoneNumber.Equals(other.ContactPhoneNumber)
            ) &&
            (
                ContactPhoneNumberColumnName == other.ContactPhoneNumberColumnName ||
                ContactPhoneNumberColumnName != null &&
                ContactPhoneNumberColumnName.Equals(other.ContactPhoneNumberColumnName)
            ) &&
            (
                ConfiguredSenderPhoneNumber == other.ConfiguredSenderPhoneNumber ||
                ConfiguredSenderPhoneNumber != null &&
                ConfiguredSenderPhoneNumber.Equals(other.ConfiguredSenderPhoneNumber)
            ) &&
            (
                SenderPhoneNumber == other.SenderPhoneNumber ||
                SenderPhoneNumber != null &&
                SenderPhoneNumber.Equals(other.SenderPhoneNumber)
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
            if (ContactPhoneNumber != null)
            {
                hash = hash * 59 + ContactPhoneNumber.GetHashCode();
            }

            if (ContactPhoneNumberColumnName != null)
            {
                hash = hash * 59 + ContactPhoneNumberColumnName.GetHashCode();
            }

            if (ConfiguredSenderPhoneNumber != null)
            {
                hash = hash * 59 + ConfiguredSenderPhoneNumber.GetHashCode();
            }

            if (SenderPhoneNumber != null)
            {
                hash = hash * 59 + SenderPhoneNumber.GetHashCode();
            }

            return hash;
        }
    }
}
