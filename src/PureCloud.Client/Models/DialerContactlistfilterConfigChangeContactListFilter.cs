using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerContactlistfilterConfigChangeContactListFilter
/// </summary>

public partial class DialerContactlistfilterConfigChangeContactListFilter : IEquatable<DialerContactlistfilterConfigChangeContactListFilter>
{
    /// <summary>
    /// Contact list filter type
    /// </summary>
    /// <value>Contact list filter type</value>
    
    public enum FilterTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum And for "AND"
        /// </summary>
        [EnumMember(Value = "AND")]
        And,

        /// <summary>
        /// Enum Or for "OR"
        /// </summary>
        [EnumMember(Value = "OR")]
        Or
    }
    /// <summary>
    /// Contact list filter type
    /// </summary>
    /// <value>Contact list filter type</value>
    [JsonPropertyName("filterType")]
    public FilterTypeEnum? FilterType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContactlistfilterConfigChangeContactListFilter" /> class.
    /// </summary>
    /// <param name="ContactList">ContactList.</param>
    /// <param name="ContactListColumns">The list of contact list columns.</param>
    /// <param name="Clauses">Clauses.</param>
    /// <param name="FilterType">Contact list filter type.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    public DialerContactlistfilterConfigChangeContactListFilter(DialerContactlistfilterConfigChangeUriReference ContactList = null, List<string> ContactListColumns = null, List<DialerContactlistfilterConfigChangeFilterClause> Clauses = null, FilterTypeEnum? FilterType = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
    {
        this.ContactList = ContactList;
        this.ContactListColumns = ContactListColumns;
        this.Clauses = Clauses;
        this.FilterType = FilterType;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;

    }



    /// <summary>
    /// Gets or Sets ContactList
    /// </summary>
    [JsonPropertyName("contactList")]
    public DialerContactlistfilterConfigChangeUriReference ContactList { get; set; }



    /// <summary>
    /// The list of contact list columns
    /// </summary>
    /// <value>The list of contact list columns</value>
    [JsonPropertyName("contactListColumns")]
    public List<string> ContactListColumns { get; set; }



    /// <summary>
    /// Gets or Sets Clauses
    /// </summary>
    [JsonPropertyName("clauses")]
    public List<DialerContactlistfilterConfigChangeFilterClause> Clauses { get; set; }





    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerContactlistfilterConfigChangeContactListFilter {\n");

        sb.Append("  ContactList: ").Append(ContactList).Append("\n");
        sb.Append("  ContactListColumns: ").Append(ContactListColumns).Append("\n");
        sb.Append("  Clauses: ").Append(Clauses).Append("\n");
        sb.Append("  FilterType: ").Append(FilterType).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as DialerContactlistfilterConfigChangeContactListFilter);
    }

    /// <summary>
    /// Returns true if DialerContactlistfilterConfigChangeContactListFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerContactlistfilterConfigChangeContactListFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerContactlistfilterConfigChangeContactListFilter other)
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
                ContactListColumns == other.ContactListColumns ||
                ContactListColumns != null &&
                ContactListColumns.SequenceEqual(other.ContactListColumns)
            ) &&
            (
                Clauses == other.Clauses ||
                Clauses != null &&
                Clauses.SequenceEqual(other.Clauses)
            ) &&
            (
                FilterType == other.FilterType ||
                FilterType != null &&
                FilterType.Equals(other.FilterType)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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

            if (ContactListColumns != null)
            {
                hash = hash * 59 + ContactListColumns.GetHashCode();
            }

            if (Clauses != null)
            {
                hash = hash * 59 + Clauses.GetHashCode();
            }

            if (FilterType != null)
            {
                hash = hash * 59 + FilterType.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
