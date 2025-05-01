using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignProgress
/// </summary>
[DataContract]
public partial class CampaignProgress : IEquatable<CampaignProgress>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignProgress" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CampaignProgress() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignProgress" /> class.
    /// </summary>
    /// <param name="Campaign">Identifier of the campaign (required).</param>
    /// <param name="ContactList">Identifier of the contact list (required).</param>
    public CampaignProgress(DomainEntityRef Campaign = null, DomainEntityRef ContactList = null)
    {
        this.Campaign = Campaign;
        this.ContactList = ContactList;

    }



    /// <summary>
    /// Identifier of the campaign
    /// </summary>
    /// <value>Identifier of the campaign</value>
    [DataMember(Name = "campaign", EmitDefaultValue = false)]
    public DomainEntityRef Campaign { get; set; }



    /// <summary>
    /// Identifier of the contact list
    /// </summary>
    /// <value>Identifier of the contact list</value>
    [DataMember(Name = "contactList", EmitDefaultValue = false)]
    public DomainEntityRef ContactList { get; set; }



    /// <summary>
    /// Number of contacts called during the campaign
    /// </summary>
    /// <value>Number of contacts called during the campaign</value>
    [DataMember(Name = "numberOfContactsCalled", EmitDefaultValue = false)]
    public long? NumberOfContactsCalled { get; private set; }



    /// <summary>
    /// Number of contacts messaged during the campaign
    /// </summary>
    /// <value>Number of contacts messaged during the campaign</value>
    [DataMember(Name = "numberOfContactsMessaged", EmitDefaultValue = false)]
    public long? NumberOfContactsMessaged { get; private set; }



    /// <summary>
    /// Total number of contacts in the campaign
    /// </summary>
    /// <value>Total number of contacts in the campaign</value>
    [DataMember(Name = "totalNumberOfContacts", EmitDefaultValue = false)]
    public long? TotalNumberOfContacts { get; private set; }



    /// <summary>
    /// Percentage of contacts processed during the campaign
    /// </summary>
    /// <value>Percentage of contacts processed during the campaign</value>
    [DataMember(Name = "percentage", EmitDefaultValue = false)]
    public long? Percentage { get; private set; }



    /// <summary>
    /// Number of contacts skipped during the campaign
    /// </summary>
    /// <value>Number of contacts skipped during the campaign</value>
    [DataMember(Name = "numberOfContactsSkipped", EmitDefaultValue = false)]
    public Dictionary<string, int?> NumberOfContactsSkipped { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignProgress {\n");

        sb.Append("  Campaign: ").Append(Campaign).Append("\n");
        sb.Append("  ContactList: ").Append(ContactList).Append("\n");
        sb.Append("  NumberOfContactsCalled: ").Append(NumberOfContactsCalled).Append("\n");
        sb.Append("  NumberOfContactsMessaged: ").Append(NumberOfContactsMessaged).Append("\n");
        sb.Append("  TotalNumberOfContacts: ").Append(TotalNumberOfContacts).Append("\n");
        sb.Append("  Percentage: ").Append(Percentage).Append("\n");
        sb.Append("  NumberOfContactsSkipped: ").Append(NumberOfContactsSkipped).Append("\n");
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
        return Equals(obj as CampaignProgress);
    }

    /// <summary>
    /// Returns true if CampaignProgress instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignProgress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignProgress other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Campaign == other.Campaign ||
                Campaign != null &&
                Campaign.Equals(other.Campaign)
            ) &&
            (
                ContactList == other.ContactList ||
                ContactList != null &&
                ContactList.Equals(other.ContactList)
            ) &&
            (
                NumberOfContactsCalled == other.NumberOfContactsCalled ||
                NumberOfContactsCalled != null &&
                NumberOfContactsCalled.Equals(other.NumberOfContactsCalled)
            ) &&
            (
                NumberOfContactsMessaged == other.NumberOfContactsMessaged ||
                NumberOfContactsMessaged != null &&
                NumberOfContactsMessaged.Equals(other.NumberOfContactsMessaged)
            ) &&
            (
                TotalNumberOfContacts == other.TotalNumberOfContacts ||
                TotalNumberOfContacts != null &&
                TotalNumberOfContacts.Equals(other.TotalNumberOfContacts)
            ) &&
            (
                Percentage == other.Percentage ||
                Percentage != null &&
                Percentage.Equals(other.Percentage)
            ) &&
            (
                NumberOfContactsSkipped == other.NumberOfContactsSkipped ||
                NumberOfContactsSkipped != null &&
                NumberOfContactsSkipped.SequenceEqual(other.NumberOfContactsSkipped)
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
            if (Campaign != null)
            {
                hash = hash * 59 + Campaign.GetHashCode();
            }

            if (ContactList != null)
            {
                hash = hash * 59 + ContactList.GetHashCode();
            }

            if (NumberOfContactsCalled != null)
            {
                hash = hash * 59 + NumberOfContactsCalled.GetHashCode();
            }

            if (NumberOfContactsMessaged != null)
            {
                hash = hash * 59 + NumberOfContactsMessaged.GetHashCode();
            }

            if (TotalNumberOfContacts != null)
            {
                hash = hash * 59 + TotalNumberOfContacts.GetHashCode();
            }

            if (Percentage != null)
            {
                hash = hash * 59 + Percentage.GetHashCode();
            }

            if (NumberOfContactsSkipped != null)
            {
                hash = hash * 59 + NumberOfContactsSkipped.GetHashCode();
            }

            return hash;
        }
    }
}
