using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// An outbound-messaging messaging campaign email Config
/// </summary>
[DataContract]
public partial class OutboundMessagingWhatsappCampaignConfigChangeEmailConfig : IEquatable<OutboundMessagingWhatsappCampaignConfigChangeEmailConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingWhatsappCampaignConfigChangeEmailConfig" /> class.
    /// </summary>
    /// <param name="EmailColumns">The Contact List column specifying the email to send to the contact..</param>
    /// <param name="ContentTemplate">A reference for a Response.</param>
    /// <param name="FromAddress">FromAddress.</param>
    /// <param name="ReplyToAddress">ReplyToAddress.</param>
    public OutboundMessagingWhatsappCampaignConfigChangeEmailConfig(List<string> EmailColumns = null, OutboundMessagingWhatsappCampaignConfigChangeResponseRef ContentTemplate = null, OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress FromAddress = null, OutboundMessagingWhatsappCampaignConfigChangeReplyToEmailAddress ReplyToAddress = null)
    {
        this.EmailColumns = EmailColumns;
        this.ContentTemplate = ContentTemplate;
        this.FromAddress = FromAddress;
        this.ReplyToAddress = ReplyToAddress;

    }



    /// <summary>
    /// The Contact List column specifying the email to send to the contact.
    /// </summary>
    /// <value>The Contact List column specifying the email to send to the contact.</value>
    [DataMember(Name = "emailColumns", EmitDefaultValue = false)]
    public List<string> EmailColumns { get; set; }



    /// <summary>
    /// A reference for a Response
    /// </summary>
    /// <value>A reference for a Response</value>
    [DataMember(Name = "contentTemplate", EmitDefaultValue = false)]
    public OutboundMessagingWhatsappCampaignConfigChangeResponseRef ContentTemplate { get; set; }



    /// <summary>
    /// Gets or Sets FromAddress
    /// </summary>
    [DataMember(Name = "fromAddress", EmitDefaultValue = false)]
    public OutboundMessagingWhatsappCampaignConfigChangeFromEmailAddress FromAddress { get; set; }



    /// <summary>
    /// Gets or Sets ReplyToAddress
    /// </summary>
    [DataMember(Name = "replyToAddress", EmitDefaultValue = false)]
    public OutboundMessagingWhatsappCampaignConfigChangeReplyToEmailAddress ReplyToAddress { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingWhatsappCampaignConfigChangeEmailConfig {\n");

        sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
        sb.Append("  ContentTemplate: ").Append(ContentTemplate).Append("\n");
        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  ReplyToAddress: ").Append(ReplyToAddress).Append("\n");
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
        return Equals(obj as OutboundMessagingWhatsappCampaignConfigChangeEmailConfig);
    }

    /// <summary>
    /// Returns true if OutboundMessagingWhatsappCampaignConfigChangeEmailConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingWhatsappCampaignConfigChangeEmailConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingWhatsappCampaignConfigChangeEmailConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EmailColumns == other.EmailColumns ||
                EmailColumns != null &&
                EmailColumns.SequenceEqual(other.EmailColumns)
            ) &&
            (
                ContentTemplate == other.ContentTemplate ||
                ContentTemplate != null &&
                ContentTemplate.Equals(other.ContentTemplate)
            ) &&
            (
                FromAddress == other.FromAddress ||
                FromAddress != null &&
                FromAddress.Equals(other.FromAddress)
            ) &&
            (
                ReplyToAddress == other.ReplyToAddress ||
                ReplyToAddress != null &&
                ReplyToAddress.Equals(other.ReplyToAddress)
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
            if (EmailColumns != null)
            {
                hash = hash * 59 + EmailColumns.GetHashCode();
            }

            if (ContentTemplate != null)
            {
                hash = hash * 59 + ContentTemplate.GetHashCode();
            }

            if (FromAddress != null)
            {
                hash = hash * 59 + FromAddress.GetHashCode();
            }

            if (ReplyToAddress != null)
            {
                hash = hash * 59 + ReplyToAddress.GetHashCode();
            }

            return hash;
        }
    }
}
