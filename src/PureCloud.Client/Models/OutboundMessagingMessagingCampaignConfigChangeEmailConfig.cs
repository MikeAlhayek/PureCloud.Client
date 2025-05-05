using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// An outbound-messaging messaging campaign email Config
/// </summary>

public partial class OutboundMessagingMessagingCampaignConfigChangeEmailConfig : IEquatable<OutboundMessagingMessagingCampaignConfigChangeEmailConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeEmailConfig" /> class.
    /// </summary>
    /// <param name="EmailColumns">The Contact List column specifying the email to send to the contact..</param>
    /// <param name="ContentTemplate">A reference for a Response.</param>
    /// <param name="FromAddress">FromAddress.</param>
    /// <param name="ReplyToAddress">ReplyToAddress.</param>
    public OutboundMessagingMessagingCampaignConfigChangeEmailConfig(List<string> EmailColumns = null, OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate = null, OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress FromAddress = null, OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress ReplyToAddress = null)
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
    [JsonPropertyName("emailColumns")]
    public List<string> EmailColumns { get; set; }



    /// <summary>
    /// A reference for a Response
    /// </summary>
    /// <value>A reference for a Response</value>
    [JsonPropertyName("contentTemplate")]
    public OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate { get; set; }



    /// <summary>
    /// Gets or Sets FromAddress
    /// </summary>
    [JsonPropertyName("fromAddress")]
    public OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress FromAddress { get; set; }



    /// <summary>
    /// Gets or Sets ReplyToAddress
    /// </summary>
    [JsonPropertyName("replyToAddress")]
    public OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress ReplyToAddress { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingMessagingCampaignConfigChangeEmailConfig {\n");

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
        return Equals(obj as OutboundMessagingMessagingCampaignConfigChangeEmailConfig);
    }

    /// <summary>
    /// Returns true if OutboundMessagingMessagingCampaignConfigChangeEmailConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeEmailConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingMessagingCampaignConfigChangeEmailConfig other)
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
