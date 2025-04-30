using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// DialerContactlistfilterConfigChangeContactListFilter
/// </summary>
[DataContract]
public partial class DialerContactlistfilterConfigChangeContactListFilter : IEquatable<DialerContactlistfilterConfigChangeContactListFilter>
{
    /// <summary>
    /// Contact list filter type
    /// </summary>
    /// <value>Contact list filter type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "filterType", EmitDefaultValue = false)]
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
    public DialerContactlistfilterConfigChangeContactListFilter(DialerContactlistfilterConfigChangeUriReference ContactList = null, List<string> ContactListColumns = null, List<DialerContactlistfilterConfigChangeFilterClause> Clauses = null, FilterTypeEnum? FilterType = null, Dictionary<string, Object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
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
    [DataMember(Name = "contactList", EmitDefaultValue = false)]
    public DialerContactlistfilterConfigChangeUriReference ContactList { get; set; }



    /// <summary>
    /// The list of contact list columns
    /// </summary>
    /// <value>The list of contact list columns</value>
    [DataMember(Name = "contactListColumns", EmitDefaultValue = false)]
    public List<string> ContactListColumns { get; set; }



    /// <summary>
    /// Gets or Sets Clauses
    /// </summary>
    [DataMember(Name = "clauses", EmitDefaultValue = false)]
    public List<DialerContactlistfilterConfigChangeFilterClause> Clauses { get; set; }





    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, Object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
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
        return this.Equals(obj as DialerContactlistfilterConfigChangeContactListFilter);
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
                this.ContactList == other.ContactList ||
                this.ContactList != null &&
                this.ContactList.Equals(other.ContactList)
            ) &&
            (
                this.ContactListColumns == other.ContactListColumns ||
                this.ContactListColumns != null &&
                this.ContactListColumns.SequenceEqual(other.ContactListColumns)
            ) &&
            (
                this.Clauses == other.Clauses ||
                this.Clauses != null &&
                this.Clauses.SequenceEqual(other.Clauses)
            ) &&
            (
                this.FilterType == other.FilterType ||
                this.FilterType != null &&
                this.FilterType.Equals(other.FilterType)
            ) &&
            (
                this.AdditionalProperties == other.AdditionalProperties ||
                this.AdditionalProperties != null &&
                this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.DateCreated == other.DateCreated ||
                this.DateCreated != null &&
                this.DateCreated.Equals(other.DateCreated)
            ) &&
            (
                this.DateModified == other.DateModified ||
                this.DateModified != null &&
                this.DateModified.Equals(other.DateModified)
            ) &&
            (
                this.Version == other.Version ||
                this.Version != null &&
                this.Version.Equals(other.Version)
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
            if (this.ContactList != null)
            {
                hash = hash * 59 + this.ContactList.GetHashCode();
            }

            if (this.ContactListColumns != null)
            {
                hash = hash * 59 + this.ContactListColumns.GetHashCode();
            }

            if (this.Clauses != null)
            {
                hash = hash * 59 + this.Clauses.GetHashCode();
            }

            if (this.FilterType != null)
            {
                hash = hash * 59 + this.FilterType.GetHashCode();
            }

            if (this.AdditionalProperties != null)
            {
                hash = hash * 59 + this.AdditionalProperties.GetHashCode();
            }

            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.DateCreated != null)
            {
                hash = hash * 59 + this.DateCreated.GetHashCode();
            }

            if (this.DateModified != null)
            {
                hash = hash * 59 + this.DateModified.GetHashCode();
            }

            if (this.Version != null)
            {
                hash = hash * 59 + this.Version.GetHashCode();
            }

            return hash;
        }
    }
}
