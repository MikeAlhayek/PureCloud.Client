using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationCallbackEventTopicDialerPreview
/// </summary>
[DataContract]
public partial class ConversationCallbackEventTopicDialerPreview : IEquatable<ConversationCallbackEventTopicDialerPreview>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationCallbackEventTopicDialerPreview" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="ContactId">The contact associated with this preview data pop.</param>
    /// <param name="ContactListId">The contactList associated with this preview data pop..</param>
    /// <param name="CampaignId">The campaignId associated with this preview data pop..</param>
    /// <param name="PhoneNumberColumns">The phone number columns associated with this campaign.</param>
    public ConversationCallbackEventTopicDialerPreview(string Id = null, string ContactId = null, string ContactListId = null, string CampaignId = null, List<ConversationCallbackEventTopicPhoneNumberColumn> PhoneNumberColumns = null)
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
    public List<ConversationCallbackEventTopicPhoneNumberColumn> PhoneNumberColumns { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationCallbackEventTopicDialerPreview {\n");

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
        return this.Equals(obj as ConversationCallbackEventTopicDialerPreview);
    }

    /// <summary>
    /// Returns true if ConversationCallbackEventTopicDialerPreview instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationCallbackEventTopicDialerPreview to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationCallbackEventTopicDialerPreview other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.ContactId == other.ContactId ||
                this.ContactId != null &&
                this.ContactId.Equals(other.ContactId)
            ) &&
            (
                this.ContactListId == other.ContactListId ||
                this.ContactListId != null &&
                this.ContactListId.Equals(other.ContactListId)
            ) &&
            (
                this.CampaignId == other.CampaignId ||
                this.CampaignId != null &&
                this.CampaignId.Equals(other.CampaignId)
            ) &&
            (
                this.PhoneNumberColumns == other.PhoneNumberColumns ||
                this.PhoneNumberColumns != null &&
                this.PhoneNumberColumns.SequenceEqual(other.PhoneNumberColumns)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.ContactId != null)
            {
                hash = hash * 59 + this.ContactId.GetHashCode();
            }

            if (this.ContactListId != null)
            {
                hash = hash * 59 + this.ContactListId.GetHashCode();
            }

            if (this.CampaignId != null)
            {
                hash = hash * 59 + this.CampaignId.GetHashCode();
            }

            if (this.PhoneNumberColumns != null)
            {
                hash = hash * 59 + this.PhoneNumberColumns.GetHashCode();
            }

            return hash;
        }
    }
}
