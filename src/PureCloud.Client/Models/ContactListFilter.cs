using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactListFilter
/// </summary>

public partial class ContactListFilter : IEquatable<ContactListFilter>
{
    /// <summary>
    /// The source type the filter is based on.
    /// </summary>
    /// <value>The source type the filter is based on.</value>
    
    public enum SourceTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Contactlist for "ContactList"
        /// </summary>
        [EnumMember(Value = "ContactList")]
        Contactlist,

        /// <summary>
        /// Enum Contactlisttemplate for "ContactListTemplate"
        /// </summary>
        [EnumMember(Value = "ContactListTemplate")]
        Contactlisttemplate
    }
    /// <summary>
    /// How to join clauses together.
    /// </summary>
    /// <value>How to join clauses together.</value>
    
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
    /// The source type the filter is based on.
    /// </summary>
    /// <value>The source type the filter is based on.</value>
    [JsonPropertyName("sourceType")]
    public SourceTypeEnum? SourceType { get; set; }
    /// <summary>
    /// How to join clauses together.
    /// </summary>
    /// <value>How to join clauses together.</value>
    [JsonPropertyName("filterType")]
    public FilterTypeEnum? FilterType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactListFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactListFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactListFilter" /> class.
    /// </summary>
    /// <param name="Name">The name of the list. (required).</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="ContactList">The contact list the filter is based on. Required if sourceType is ContactList.</param>
    /// <param name="ContactListTemplate">The contact list template the filter is based on. Required if sourceType is ContactListTemplate.</param>
    /// <param name="SourceType">The source type the filter is based on..</param>
    /// <param name="Clauses">Groups of conditions to filter the contacts by..</param>
    /// <param name="FilterType">How to join clauses together..</param>
    public ContactListFilter(string Name = null, int? Version = null, DomainEntityRef ContactList = null, DomainEntityRef ContactListTemplate = null, SourceTypeEnum? SourceType = null, List<ContactListFilterClause> Clauses = null, FilterTypeEnum? FilterType = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.ContactList = ContactList;
        this.ContactListTemplate = ContactListTemplate;
        this.SourceType = SourceType;
        this.Clauses = Clauses;
        this.FilterType = FilterType;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the list.
    /// </summary>
    /// <value>The name of the list.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The contact list the filter is based on. Required if sourceType is ContactList
    /// </summary>
    /// <value>The contact list the filter is based on. Required if sourceType is ContactList</value>
    [JsonPropertyName("contactList")]
    public DomainEntityRef ContactList { get; set; }



    /// <summary>
    /// The contact list template the filter is based on. Required if sourceType is ContactListTemplate
    /// </summary>
    /// <value>The contact list template the filter is based on. Required if sourceType is ContactListTemplate</value>
    [JsonPropertyName("contactListTemplate")]
    public DomainEntityRef ContactListTemplate { get; set; }





    /// <summary>
    /// Groups of conditions to filter the contacts by.
    /// </summary>
    /// <value>Groups of conditions to filter the contacts by.</value>
    [JsonPropertyName("clauses")]
    public List<ContactListFilterClause> Clauses { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactListFilter {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ContactList: ").Append(ContactList).Append("\n");
        sb.Append("  ContactListTemplate: ").Append(ContactListTemplate).Append("\n");
        sb.Append("  SourceType: ").Append(SourceType).Append("\n");
        sb.Append("  Clauses: ").Append(Clauses).Append("\n");
        sb.Append("  FilterType: ").Append(FilterType).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as ContactListFilter);
    }

    /// <summary>
    /// Returns true if ContactListFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactListFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactListFilter other)
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
            ) &&
            (
                ContactList == other.ContactList ||
                ContactList != null &&
                ContactList.Equals(other.ContactList)
            ) &&
            (
                ContactListTemplate == other.ContactListTemplate ||
                ContactListTemplate != null &&
                ContactListTemplate.Equals(other.ContactListTemplate)
            ) &&
            (
                SourceType == other.SourceType ||
                SourceType != null &&
                SourceType.Equals(other.SourceType)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (ContactList != null)
            {
                hash = hash * 59 + ContactList.GetHashCode();
            }

            if (ContactListTemplate != null)
            {
                hash = hash * 59 + ContactListTemplate.GetHashCode();
            }

            if (SourceType != null)
            {
                hash = hash * 59 + SourceType.GetHashCode();
            }

            if (Clauses != null)
            {
                hash = hash * 59 + Clauses.GetHashCode();
            }

            if (FilterType != null)
            {
                hash = hash * 59 + FilterType.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
