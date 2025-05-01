using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// An outbound-messaging messaging campaign SMS Config
/// </summary>
[DataContract]
public partial class OutboundMessagingMessagingCampaignConfigChangeSmsConfig : IEquatable<OutboundMessagingMessagingCampaignConfigChangeSmsConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeSmsConfig" /> class.
    /// </summary>
    /// <param name="MessageColumn">The Contact List column specifying the message to send to the contact..</param>
    /// <param name="PhoneColumn">The Contact List column specifying the phone number to send a message to..</param>
    /// <param name="SenderSmsPhoneNumber">SenderSmsPhoneNumber.</param>
    /// <param name="ContentTemplate">ContentTemplate.</param>
    public OutboundMessagingMessagingCampaignConfigChangeSmsConfig(string MessageColumn = null, string PhoneColumn = null, OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef SenderSmsPhoneNumber = null, OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate = null)
    {
        this.MessageColumn = MessageColumn;
        this.PhoneColumn = PhoneColumn;
        this.SenderSmsPhoneNumber = SenderSmsPhoneNumber;
        this.ContentTemplate = ContentTemplate;

    }



    /// <summary>
    /// The Contact List column specifying the message to send to the contact.
    /// </summary>
    /// <value>The Contact List column specifying the message to send to the contact.</value>
    [DataMember(Name = "messageColumn", EmitDefaultValue = false)]
    public string MessageColumn { get; set; }



    /// <summary>
    /// The Contact List column specifying the phone number to send a message to.
    /// </summary>
    /// <value>The Contact List column specifying the phone number to send a message to.</value>
    [DataMember(Name = "phoneColumn", EmitDefaultValue = false)]
    public string PhoneColumn { get; set; }



    /// <summary>
    /// Gets or Sets SenderSmsPhoneNumber
    /// </summary>
    [DataMember(Name = "senderSmsPhoneNumber", EmitDefaultValue = false)]
    public OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef SenderSmsPhoneNumber { get; set; }



    /// <summary>
    /// Gets or Sets ContentTemplate
    /// </summary>
    [DataMember(Name = "contentTemplate", EmitDefaultValue = false)]
    public OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingMessagingCampaignConfigChangeSmsConfig {\n");

        sb.Append("  MessageColumn: ").Append(MessageColumn).Append("\n");
        sb.Append("  PhoneColumn: ").Append(PhoneColumn).Append("\n");
        sb.Append("  SenderSmsPhoneNumber: ").Append(SenderSmsPhoneNumber).Append("\n");
        sb.Append("  ContentTemplate: ").Append(ContentTemplate).Append("\n");
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
        return Equals(obj as OutboundMessagingMessagingCampaignConfigChangeSmsConfig);
    }

    /// <summary>
    /// Returns true if OutboundMessagingMessagingCampaignConfigChangeSmsConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeSmsConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingMessagingCampaignConfigChangeSmsConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MessageColumn == other.MessageColumn ||
                MessageColumn != null &&
                MessageColumn.Equals(other.MessageColumn)
            ) &&
            (
                PhoneColumn == other.PhoneColumn ||
                PhoneColumn != null &&
                PhoneColumn.Equals(other.PhoneColumn)
            ) &&
            (
                SenderSmsPhoneNumber == other.SenderSmsPhoneNumber ||
                SenderSmsPhoneNumber != null &&
                SenderSmsPhoneNumber.Equals(other.SenderSmsPhoneNumber)
            ) &&
            (
                ContentTemplate == other.ContentTemplate ||
                ContentTemplate != null &&
                ContentTemplate.Equals(other.ContentTemplate)
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
            if (MessageColumn != null)
            {
                hash = hash * 59 + MessageColumn.GetHashCode();
            }

            if (PhoneColumn != null)
            {
                hash = hash * 59 + PhoneColumn.GetHashCode();
            }

            if (SenderSmsPhoneNumber != null)
            {
                hash = hash * 59 + SenderSmsPhoneNumber.GetHashCode();
            }

            if (ContentTemplate != null)
            {
                hash = hash * 59 + ContentTemplate.GetHashCode();
            }

            return hash;
        }
    }
}
