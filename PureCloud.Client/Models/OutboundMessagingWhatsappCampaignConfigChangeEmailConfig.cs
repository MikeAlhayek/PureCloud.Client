using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

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
        return this.Equals(obj as OutboundMessagingWhatsappCampaignConfigChangeEmailConfig);
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
                this.EmailColumns == other.EmailColumns ||
                this.EmailColumns != null &&
                this.EmailColumns.SequenceEqual(other.EmailColumns)
            ) &&
            (
                this.ContentTemplate == other.ContentTemplate ||
                this.ContentTemplate != null &&
                this.ContentTemplate.Equals(other.ContentTemplate)
            ) &&
            (
                this.FromAddress == other.FromAddress ||
                this.FromAddress != null &&
                this.FromAddress.Equals(other.FromAddress)
            ) &&
            (
                this.ReplyToAddress == other.ReplyToAddress ||
                this.ReplyToAddress != null &&
                this.ReplyToAddress.Equals(other.ReplyToAddress)
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
            if (this.EmailColumns != null)
            {
                hash = hash * 59 + this.EmailColumns.GetHashCode();
            }

            if (this.ContentTemplate != null)
            {
                hash = hash * 59 + this.ContentTemplate.GetHashCode();
            }

            if (this.FromAddress != null)
            {
                hash = hash * 59 + this.FromAddress.GetHashCode();
            }

            if (this.ReplyToAddress != null)
            {
                hash = hash * 59 + this.ReplyToAddress.GetHashCode();
            }

            return hash;
        }
    }
}
