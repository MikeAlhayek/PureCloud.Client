using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationCallbackEventTopicDialerPreview
/// </summary>
[DataContract]
public partial class QueueConversationCallbackEventTopicDialerPreview : IEquatable<QueueConversationCallbackEventTopicDialerPreview>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationCallbackEventTopicDialerPreview" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="ContactId">The contact associated with this preview data pop.</param>
    /// <param name="ContactListId">The contactList associated with this preview data pop..</param>
    /// <param name="CampaignId">The campaignId associated with this preview data pop..</param>
    /// <param name="PhoneNumberColumns">The phone number columns associated with this campaign.</param>
    public QueueConversationCallbackEventTopicDialerPreview(string Id = null, string ContactId = null, string ContactListId = null, string CampaignId = null, List<QueueConversationCallbackEventTopicPhoneNumberColumn> PhoneNumberColumns = null)
    {
        this.Id = Id;
        this.ContactId = ContactId;
        this.ContactListId = ContactListId;
        this.CampaignId = CampaignId;
        this.PhoneNumberColumns = PhoneNumberColumns;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The contact associated with this preview data pop
    /// </summary>
    /// <value>The contact associated with this preview data pop</value>
    [DataMember(Name = "contactId", EmitDefaultValue = false)]
    public string ContactId { get; set; }



    /// <summary>
    /// The contactList associated with this preview data pop.
    /// </summary>
    /// <value>The contactList associated with this preview data pop.</value>
    [DataMember(Name = "contactListId", EmitDefaultValue = false)]
    public string ContactListId { get; set; }



    /// <summary>
    /// The campaignId associated with this preview data pop.
    /// </summary>
    /// <value>The campaignId associated with this preview data pop.</value>
    [DataMember(Name = "campaignId", EmitDefaultValue = false)]
    public string CampaignId { get; set; }



    /// <summary>
    /// The phone number columns associated with this campaign
    /// </summary>
    /// <value>The phone number columns associated with this campaign</value>
    [DataMember(Name = "phoneNumberColumns", EmitDefaultValue = false)]
    public List<QueueConversationCallbackEventTopicPhoneNumberColumn> PhoneNumberColumns { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationCallbackEventTopicDialerPreview {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ContactId: ").Append(ContactId).Append("\n");
        sb.Append("  ContactListId: ").Append(ContactListId).Append("\n");
        sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
        sb.Append("  PhoneNumberColumns: ").Append(PhoneNumberColumns).Append("\n");
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
        return Equals(obj as QueueConversationCallbackEventTopicDialerPreview);
    }

    /// <summary>
    /// Returns true if QueueConversationCallbackEventTopicDialerPreview instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationCallbackEventTopicDialerPreview to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationCallbackEventTopicDialerPreview other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                ContactId == other.ContactId ||
                ContactId != null &&
                ContactId.Equals(other.ContactId)
            ) &&
            (
                ContactListId == other.ContactListId ||
                ContactListId != null &&
                ContactListId.Equals(other.ContactListId)
            ) &&
            (
                CampaignId == other.CampaignId ||
                CampaignId != null &&
                CampaignId.Equals(other.CampaignId)
            ) &&
            (
                PhoneNumberColumns == other.PhoneNumberColumns ||
                PhoneNumberColumns != null &&
                PhoneNumberColumns.SequenceEqual(other.PhoneNumberColumns)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (ContactId != null)
            {
                hash = hash * 59 + ContactId.GetHashCode();
            }

            if (ContactListId != null)
            {
                hash = hash * 59 + ContactListId.GetHashCode();
            }

            if (CampaignId != null)
            {
                hash = hash * 59 + CampaignId.GetHashCode();
            }

            if (PhoneNumberColumns != null)
            {
                hash = hash * 59 + PhoneNumberColumns.GetHashCode();
            }

            return hash;
        }
    }
}
