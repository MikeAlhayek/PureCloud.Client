using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactBulkSearchCriteria
/// </summary>

public partial class ContactBulkSearchCriteria : IEquatable<ContactBulkSearchCriteria>
{
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
    /// How to join clauses together.
    /// </summary>
    /// <value>How to join clauses together.</value>
    [JsonPropertyName("filterType")]
    public FilterTypeEnum? FilterType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactBulkSearchCriteria" /> class.
    /// </summary>
    /// <param name="Clauses">Groups of conditions to filter the contacts by..</param>
    /// <param name="FilterType">How to join clauses together..</param>
    public ContactBulkSearchCriteria(List<ContactListFilterClause> Clauses = null, FilterTypeEnum? FilterType = null)
    {
        this.Clauses = Clauses;
        this.FilterType = FilterType;

    }



    /// <summary>
    /// Groups of conditions to filter the contacts by.
    /// </summary>
    /// <value>Groups of conditions to filter the contacts by.</value>
    [JsonPropertyName("clauses")]
    public List<ContactListFilterClause> Clauses { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactBulkSearchCriteria {\n");

        sb.Append("  Clauses: ").Append(Clauses).Append("\n");
        sb.Append("  FilterType: ").Append(FilterType).Append("\n");
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
        return Equals(obj as ContactBulkSearchCriteria);
    }

    /// <summary>
    /// Returns true if ContactBulkSearchCriteria instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactBulkSearchCriteria to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactBulkSearchCriteria other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Clauses == other.Clauses ||
                Clauses != null &&
                Clauses.SequenceEqual(other.Clauses)
            ) &&
            (
                FilterType == other.FilterType ||
                FilterType != null &&
                FilterType.Equals(other.FilterType)
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
            if (Clauses != null)
            {
                hash = hash * 59 + Clauses.GetHashCode();
            }

            if (FilterType != null)
            {
                hash = hash * 59 + FilterType.GetHashCode();
            }

            return hash;
        }
    }
}
