using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes
/// </summary>
[DataContract]
public partial class OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes : IEquatable<OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes" /> class.
    /// </summary>
    /// <param name="EmailSubject">EmailSubject.</param>
    /// <param name="ConfiguredEmailAddress">ConfiguredEmailAddress.</param>
    /// <param name="ContactEmailAddress">ContactEmailAddress.</param>
    /// <param name="ReplyToAddress">ReplyToAddress.</param>
    /// <param name="ContactEmailColumnName">ContactEmailColumnName.</param>
    public OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes(string EmailSubject = null, string ConfiguredEmailAddress = null, string ContactEmailAddress = null, string ReplyToAddress = null, string ContactEmailColumnName = null)
    {
        this.EmailSubject = EmailSubject;
        this.ConfiguredEmailAddress = ConfiguredEmailAddress;
        this.ContactEmailAddress = ContactEmailAddress;
        this.ReplyToAddress = ReplyToAddress;
        this.ContactEmailColumnName = ContactEmailColumnName;

    }



    /// <summary>
    /// Gets or Sets EmailSubject
    /// </summary>
    [DataMember(Name = "emailSubject", EmitDefaultValue = false)]
    public string EmailSubject { get; set; }



    /// <summary>
    /// Gets or Sets ConfiguredEmailAddress
    /// </summary>
    [DataMember(Name = "configuredEmailAddress", EmitDefaultValue = false)]
    public string ConfiguredEmailAddress { get; set; }



    /// <summary>
    /// Gets or Sets ContactEmailAddress
    /// </summary>
    [DataMember(Name = "contactEmailAddress", EmitDefaultValue = false)]
    public string ContactEmailAddress { get; set; }



    /// <summary>
    /// Gets or Sets ReplyToAddress
    /// </summary>
    [DataMember(Name = "replyToAddress", EmitDefaultValue = false)]
    public string ReplyToAddress { get; set; }



    /// <summary>
    /// Gets or Sets ContactEmailColumnName
    /// </summary>
    [DataMember(Name = "contactEmailColumnName", EmitDefaultValue = false)]
    public string ContactEmailColumnName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes {\n");

        sb.Append("  EmailSubject: ").Append(EmailSubject).Append("\n");
        sb.Append("  ConfiguredEmailAddress: ").Append(ConfiguredEmailAddress).Append("\n");
        sb.Append("  ContactEmailAddress: ").Append(ContactEmailAddress).Append("\n");
        sb.Append("  ReplyToAddress: ").Append(ReplyToAddress).Append("\n");
        sb.Append("  ContactEmailColumnName: ").Append(ContactEmailColumnName).Append("\n");
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
        return Equals(obj as OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes);
    }

    /// <summary>
    /// Returns true if OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EmailSubject == other.EmailSubject ||
                EmailSubject != null &&
                EmailSubject.Equals(other.EmailSubject)
            ) &&
            (
                ConfiguredEmailAddress == other.ConfiguredEmailAddress ||
                ConfiguredEmailAddress != null &&
                ConfiguredEmailAddress.Equals(other.ConfiguredEmailAddress)
            ) &&
            (
                ContactEmailAddress == other.ContactEmailAddress ||
                ContactEmailAddress != null &&
                ContactEmailAddress.Equals(other.ContactEmailAddress)
            ) &&
            (
                ReplyToAddress == other.ReplyToAddress ||
                ReplyToAddress != null &&
                ReplyToAddress.Equals(other.ReplyToAddress)
            ) &&
            (
                ContactEmailColumnName == other.ContactEmailColumnName ||
                ContactEmailColumnName != null &&
                ContactEmailColumnName.Equals(other.ContactEmailColumnName)
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
            if (EmailSubject != null)
            {
                hash = hash * 59 + EmailSubject.GetHashCode();
            }

            if (ConfiguredEmailAddress != null)
            {
                hash = hash * 59 + ConfiguredEmailAddress.GetHashCode();
            }

            if (ContactEmailAddress != null)
            {
                hash = hash * 59 + ContactEmailAddress.GetHashCode();
            }

            if (ReplyToAddress != null)
            {
                hash = hash * 59 + ReplyToAddress.GetHashCode();
            }

            if (ContactEmailColumnName != null)
            {
                hash = hash * 59 + ContactEmailColumnName.GetHashCode();
            }

            return hash;
        }
    }
}
