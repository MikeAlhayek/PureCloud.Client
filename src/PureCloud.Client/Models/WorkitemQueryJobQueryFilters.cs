using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemQueryJobQueryFilters
/// </summary>

public partial class WorkitemQueryJobQueryFilters : IEquatable<WorkitemQueryJobQueryFilters>
{
    /// <summary>
    /// Name of the attribute to filter.
    /// </summary>
    /// <value>Name of the attribute to filter.</value>
    
    public enum NameEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Customfields for "customFields"
        /// </summary>
        [EnumMember(Value = "customFields")]
        Customfields
    }
    /// <summary>
    /// Query filter logical operator to join criteria.
    /// </summary>
    /// <value>Query filter logical operator to join criteria.</value>
    
    public enum OperatorEnum
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
    /// Name of the attribute to filter.
    /// </summary>
    /// <value>Name of the attribute to filter.</value>
    [JsonPropertyName("name")]
    public NameEnum? Name { get; set; }
    /// <summary>
    /// Query filter logical operator to join criteria.
    /// </summary>
    /// <value>Query filter logical operator to join criteria.</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemQueryJobQueryFilters" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkitemQueryJobQueryFilters() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemQueryJobQueryFilters" /> class.
    /// </summary>
    /// <param name="Name">Name of the attribute to filter. (required).</param>
    /// <param name="Operator">Query filter logical operator to join criteria..</param>
    /// <param name="Criteria">Query filter criteria. (required).</param>
    public WorkitemQueryJobQueryFilters(NameEnum? Name = null, OperatorEnum? Operator = null, List<WorkitemQueryJobQueryFiltersCriteria> Criteria = null)
    {
        this.Name = Name;
        this.Operator = Operator;
        this.Criteria = Criteria;

    }







    /// <summary>
    /// Query filter criteria.
    /// </summary>
    /// <value>Query filter criteria.</value>
    [JsonPropertyName("criteria")]
    public List<WorkitemQueryJobQueryFiltersCriteria> Criteria { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemQueryJobQueryFilters {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
        return Equals(obj as WorkitemQueryJobQueryFilters);
    }

    /// <summary>
    /// Returns true if WorkitemQueryJobQueryFilters instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemQueryJobQueryFilters to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemQueryJobQueryFilters other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Criteria == other.Criteria ||
                Criteria != null &&
                Criteria.SequenceEqual(other.Criteria)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Criteria != null)
            {
                hash = hash * 59 + Criteria.GetHashCode();
            }

            return hash;
        }
    }
}
