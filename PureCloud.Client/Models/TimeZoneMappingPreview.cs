using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeZoneMappingPreview
/// </summary>
[DataContract]
public partial class TimeZoneMappingPreview : IEquatable<TimeZoneMappingPreview>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeZoneMappingPreview" /> class.
    /// </summary>
    /// <param name="ContactList">The associated ContactList.</param>
    /// <param name="ContactsPerTimeZone">The number of contacts per time zone that mapped to only that time zone.</param>
    /// <param name="ContactsMappedUsingZipCode">The number of contacts per time zone that mapped to only that time zone and were mapped using the zip code column.</param>
    /// <param name="ContactsMappedToASingleZone">The total number of contacts that mapped to a single time zone.</param>
    /// <param name="ContactsMappedToASingleZoneUsingZipCode">The total number of contacts that mapped to a single time zone and were mapped using the zip code column.</param>
    /// <param name="ContactsMappedToMultipleZones">The total number of contacts that mapped to multiple time zones.</param>
    /// <param name="ContactsMappedToMultipleZonesUsingZipCode">The total number of contacts that mapped to multiple time zones and were mapped using the zip code column.</param>
    /// <param name="ContactsInDefaultWindow">The total number of contacts that will be dialed during the default window.</param>
    /// <param name="ContactListSize">The total number of contacts in the contact list.</param>
    public TimeZoneMappingPreview(DomainEntityRef ContactList = null, Dictionary<string, long?> ContactsPerTimeZone = null, Dictionary<string, long?> ContactsMappedUsingZipCode = null, long? ContactsMappedToASingleZone = null, long? ContactsMappedToASingleZoneUsingZipCode = null, long? ContactsMappedToMultipleZones = null, long? ContactsMappedToMultipleZonesUsingZipCode = null, long? ContactsInDefaultWindow = null, long? ContactListSize = null)
    {
        this.ContactList = ContactList;
        this.ContactsPerTimeZone = ContactsPerTimeZone;
        this.ContactsMappedUsingZipCode = ContactsMappedUsingZipCode;
        this.ContactsMappedToASingleZone = ContactsMappedToASingleZone;
        this.ContactsMappedToASingleZoneUsingZipCode = ContactsMappedToASingleZoneUsingZipCode;
        this.ContactsMappedToMultipleZones = ContactsMappedToMultipleZones;
        this.ContactsMappedToMultipleZonesUsingZipCode = ContactsMappedToMultipleZonesUsingZipCode;
        this.ContactsInDefaultWindow = ContactsInDefaultWindow;
        this.ContactListSize = ContactListSize;

    }



    /// <summary>
    /// The associated ContactList
    /// </summary>
    /// <value>The associated ContactList</value>
    [DataMember(Name = "contactList", EmitDefaultValue = false)]
    public DomainEntityRef ContactList { get; set; }



    /// <summary>
    /// The number of contacts per time zone that mapped to only that time zone
    /// </summary>
    /// <value>The number of contacts per time zone that mapped to only that time zone</value>
    [DataMember(Name = "contactsPerTimeZone", EmitDefaultValue = false)]
    public Dictionary<string, long?> ContactsPerTimeZone { get; set; }



    /// <summary>
    /// The number of contacts per time zone that mapped to only that time zone and were mapped using the zip code column
    /// </summary>
    /// <value>The number of contacts per time zone that mapped to only that time zone and were mapped using the zip code column</value>
    [DataMember(Name = "contactsMappedUsingZipCode", EmitDefaultValue = false)]
    public Dictionary<string, long?> ContactsMappedUsingZipCode { get; set; }



    /// <summary>
    /// The total number of contacts that mapped to a single time zone
    /// </summary>
    /// <value>The total number of contacts that mapped to a single time zone</value>
    [DataMember(Name = "contactsMappedToASingleZone", EmitDefaultValue = false)]
    public long? ContactsMappedToASingleZone { get; set; }



    /// <summary>
    /// The total number of contacts that mapped to a single time zone and were mapped using the zip code column
    /// </summary>
    /// <value>The total number of contacts that mapped to a single time zone and were mapped using the zip code column</value>
    [DataMember(Name = "contactsMappedToASingleZoneUsingZipCode", EmitDefaultValue = false)]
    public long? ContactsMappedToASingleZoneUsingZipCode { get; set; }



    /// <summary>
    /// The total number of contacts that mapped to multiple time zones
    /// </summary>
    /// <value>The total number of contacts that mapped to multiple time zones</value>
    [DataMember(Name = "contactsMappedToMultipleZones", EmitDefaultValue = false)]
    public long? ContactsMappedToMultipleZones { get; set; }



    /// <summary>
    /// The total number of contacts that mapped to multiple time zones and were mapped using the zip code column
    /// </summary>
    /// <value>The total number of contacts that mapped to multiple time zones and were mapped using the zip code column</value>
    [DataMember(Name = "contactsMappedToMultipleZonesUsingZipCode", EmitDefaultValue = false)]
    public long? ContactsMappedToMultipleZonesUsingZipCode { get; set; }



    /// <summary>
    /// The total number of contacts that will be dialed during the default window
    /// </summary>
    /// <value>The total number of contacts that will be dialed during the default window</value>
    [DataMember(Name = "contactsInDefaultWindow", EmitDefaultValue = false)]
    public long? ContactsInDefaultWindow { get; set; }



    /// <summary>
    /// The total number of contacts in the contact list
    /// </summary>
    /// <value>The total number of contacts in the contact list</value>
    [DataMember(Name = "contactListSize", EmitDefaultValue = false)]
    public long? ContactListSize { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeZoneMappingPreview {\n");

        sb.Append("  ContactList: ").Append(ContactList).Append("\n");
        sb.Append("  ContactsPerTimeZone: ").Append(ContactsPerTimeZone).Append("\n");
        sb.Append("  ContactsMappedUsingZipCode: ").Append(ContactsMappedUsingZipCode).Append("\n");
        sb.Append("  ContactsMappedToASingleZone: ").Append(ContactsMappedToASingleZone).Append("\n");
        sb.Append("  ContactsMappedToASingleZoneUsingZipCode: ").Append(ContactsMappedToASingleZoneUsingZipCode).Append("\n");
        sb.Append("  ContactsMappedToMultipleZones: ").Append(ContactsMappedToMultipleZones).Append("\n");
        sb.Append("  ContactsMappedToMultipleZonesUsingZipCode: ").Append(ContactsMappedToMultipleZonesUsingZipCode).Append("\n");
        sb.Append("  ContactsInDefaultWindow: ").Append(ContactsInDefaultWindow).Append("\n");
        sb.Append("  ContactListSize: ").Append(ContactListSize).Append("\n");
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
        return Equals(obj as TimeZoneMappingPreview);
    }

    /// <summary>
    /// Returns true if TimeZoneMappingPreview instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeZoneMappingPreview to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeZoneMappingPreview other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContactList == other.ContactList ||
                ContactList != null &&
                ContactList.Equals(other.ContactList)
            ) &&
            (
                ContactsPerTimeZone == other.ContactsPerTimeZone ||
                ContactsPerTimeZone != null &&
                ContactsPerTimeZone.SequenceEqual(other.ContactsPerTimeZone)
            ) &&
            (
                ContactsMappedUsingZipCode == other.ContactsMappedUsingZipCode ||
                ContactsMappedUsingZipCode != null &&
                ContactsMappedUsingZipCode.SequenceEqual(other.ContactsMappedUsingZipCode)
            ) &&
            (
                ContactsMappedToASingleZone == other.ContactsMappedToASingleZone ||
                ContactsMappedToASingleZone != null &&
                ContactsMappedToASingleZone.Equals(other.ContactsMappedToASingleZone)
            ) &&
            (
                ContactsMappedToASingleZoneUsingZipCode == other.ContactsMappedToASingleZoneUsingZipCode ||
                ContactsMappedToASingleZoneUsingZipCode != null &&
                ContactsMappedToASingleZoneUsingZipCode.Equals(other.ContactsMappedToASingleZoneUsingZipCode)
            ) &&
            (
                ContactsMappedToMultipleZones == other.ContactsMappedToMultipleZones ||
                ContactsMappedToMultipleZones != null &&
                ContactsMappedToMultipleZones.Equals(other.ContactsMappedToMultipleZones)
            ) &&
            (
                ContactsMappedToMultipleZonesUsingZipCode == other.ContactsMappedToMultipleZonesUsingZipCode ||
                ContactsMappedToMultipleZonesUsingZipCode != null &&
                ContactsMappedToMultipleZonesUsingZipCode.Equals(other.ContactsMappedToMultipleZonesUsingZipCode)
            ) &&
            (
                ContactsInDefaultWindow == other.ContactsInDefaultWindow ||
                ContactsInDefaultWindow != null &&
                ContactsInDefaultWindow.Equals(other.ContactsInDefaultWindow)
            ) &&
            (
                ContactListSize == other.ContactListSize ||
                ContactListSize != null &&
                ContactListSize.Equals(other.ContactListSize)
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
            if (ContactList != null)
            {
                hash = hash * 59 + ContactList.GetHashCode();
            }

            if (ContactsPerTimeZone != null)
            {
                hash = hash * 59 + ContactsPerTimeZone.GetHashCode();
            }

            if (ContactsMappedUsingZipCode != null)
            {
                hash = hash * 59 + ContactsMappedUsingZipCode.GetHashCode();
            }

            if (ContactsMappedToASingleZone != null)
            {
                hash = hash * 59 + ContactsMappedToASingleZone.GetHashCode();
            }

            if (ContactsMappedToASingleZoneUsingZipCode != null)
            {
                hash = hash * 59 + ContactsMappedToASingleZoneUsingZipCode.GetHashCode();
            }

            if (ContactsMappedToMultipleZones != null)
            {
                hash = hash * 59 + ContactsMappedToMultipleZones.GetHashCode();
            }

            if (ContactsMappedToMultipleZonesUsingZipCode != null)
            {
                hash = hash * 59 + ContactsMappedToMultipleZonesUsingZipCode.GetHashCode();
            }

            if (ContactsInDefaultWindow != null)
            {
                hash = hash * 59 + ContactsInDefaultWindow.GetHashCode();
            }

            if (ContactListSize != null)
            {
                hash = hash * 59 + ContactListSize.GetHashCode();
            }

            return hash;
        }
    }
}
