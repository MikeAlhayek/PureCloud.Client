using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactListFilterClause
/// </summary>

public partial class ContactListFilterClause : IEquatable<ContactListFilterClause>
{
    /// <summary>
    /// How to join predicates together.
    /// </summary>
    /// <value>How to join predicates together.</value>
    
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
    /// How to join predicates together.
    /// </summary>
    /// <value>How to join predicates together.</value>
    [JsonPropertyName("filterType")]
    public FilterTypeEnum? FilterType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactListFilterClause" /> class.
    /// </summary>
    /// <param name="FilterType">How to join predicates together..</param>
    /// <param name="Predicates">Conditions to filter the contacts by..</param>
    public ContactListFilterClause(FilterTypeEnum? FilterType = null, List<ContactListFilterPredicate> Predicates = null)
    {
        this.FilterType = FilterType;
        this.Predicates = Predicates;

    }





    /// <summary>
    /// Conditions to filter the contacts by.
    /// </summary>
    /// <value>Conditions to filter the contacts by.</value>
    [JsonPropertyName("predicates")]
    public List<ContactListFilterPredicate> Predicates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactListFilterClause {\n");

        sb.Append("  FilterType: ").Append(FilterType).Append("\n");
        sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
        return Equals(obj as ContactListFilterClause);
    }

    /// <summary>
    /// Returns true if ContactListFilterClause instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactListFilterClause to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactListFilterClause other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FilterType == other.FilterType ||
                FilterType != null &&
                FilterType.Equals(other.FilterType)
            ) &&
            (
                Predicates == other.Predicates ||
                Predicates != null &&
                Predicates.SequenceEqual(other.Predicates)
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
            if (FilterType != null)
            {
                hash = hash * 59 + FilterType.GetHashCode();
            }

            if (Predicates != null)
            {
                hash = hash * 59 + Predicates.GetHashCode();
            }

            return hash;
        }
    }
}
