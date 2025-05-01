using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactBulkEditRequest
/// </summary>
[DataContract]
public partial class ContactBulkEditRequest : IEquatable<ContactBulkEditRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactBulkEditRequest" /> class.
    /// </summary>
    /// <param name="ContactListFilterId">Contact List Filter ID..</param>
    /// <param name="Criteria">Criteria to filter the contacts by..</param>
    /// <param name="ContactIds">Contact IDs to be bulk edited..</param>
    /// <param name="Contact">Contact object with details of fields used for patching..</param>
    public ContactBulkEditRequest(string ContactListFilterId = null, ContactBulkSearchCriteria Criteria = null, List<string> ContactIds = null, DialerContact Contact = null)
    {
        this.ContactListFilterId = ContactListFilterId;
        this.Criteria = Criteria;
        this.ContactIds = ContactIds;
        this.Contact = Contact;

    }



    /// <summary>
    /// Contact List Filter ID.
    /// </summary>
    /// <value>Contact List Filter ID.</value>
    [DataMember(Name = "contactListFilterId", EmitDefaultValue = false)]
    public string ContactListFilterId { get; set; }



    /// <summary>
    /// Criteria to filter the contacts by.
    /// </summary>
    /// <value>Criteria to filter the contacts by.</value>
    [DataMember(Name = "criteria", EmitDefaultValue = false)]
    public ContactBulkSearchCriteria Criteria { get; set; }



    /// <summary>
    /// Contact IDs to be bulk edited.
    /// </summary>
    /// <value>Contact IDs to be bulk edited.</value>
    [DataMember(Name = "contactIds", EmitDefaultValue = false)]
    public List<string> ContactIds { get; set; }



    /// <summary>
    /// Contact object with details of fields used for patching.
    /// </summary>
    /// <value>Contact object with details of fields used for patching.</value>
    [DataMember(Name = "contact", EmitDefaultValue = false)]
    public DialerContact Contact { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactBulkEditRequest {\n");

        sb.Append("  ContactListFilterId: ").Append(ContactListFilterId).Append("\n");
        sb.Append("  Criteria: ").Append(Criteria).Append("\n");
        sb.Append("  ContactIds: ").Append(ContactIds).Append("\n");
        sb.Append("  Contact: ").Append(Contact).Append("\n");
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
        return Equals(obj as ContactBulkEditRequest);
    }

    /// <summary>
    /// Returns true if ContactBulkEditRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactBulkEditRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactBulkEditRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContactListFilterId == other.ContactListFilterId ||
                ContactListFilterId != null &&
                ContactListFilterId.Equals(other.ContactListFilterId)
            ) &&
            (
                Criteria == other.Criteria ||
                Criteria != null &&
                Criteria.Equals(other.Criteria)
            ) &&
            (
                ContactIds == other.ContactIds ||
                ContactIds != null &&
                ContactIds.SequenceEqual(other.ContactIds)
            ) &&
            (
                Contact == other.Contact ||
                Contact != null &&
                Contact.Equals(other.Contact)
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
            if (ContactListFilterId != null)
            {
                hash = hash * 59 + ContactListFilterId.GetHashCode();
            }

            if (Criteria != null)
            {
                hash = hash * 59 + Criteria.GetHashCode();
            }

            if (ContactIds != null)
            {
                hash = hash * 59 + ContactIds.GetHashCode();
            }

            if (Contact != null)
            {
                hash = hash * 59 + Contact.GetHashCode();
            }

            return hash;
        }
    }
}
