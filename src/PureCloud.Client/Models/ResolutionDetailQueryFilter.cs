using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ResolutionDetailQueryFilter
/// </summary>

public partial class ResolutionDetailQueryFilter : IEquatable<ResolutionDetailQueryFilter>
{
    /// <summary>
    /// Boolean operation to apply to the provided predicates and clauses
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates and clauses</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum And for "and"
        /// </summary>
        [EnumMember(Value = "and")]
        And,

        /// <summary>
        /// Enum Or for "or"
        /// </summary>
        [EnumMember(Value = "or")]
        Or
    }
    /// <summary>
    /// Boolean operation to apply to the provided predicates and clauses
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates and clauses</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ResolutionDetailQueryFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ResolutionDetailQueryFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ResolutionDetailQueryFilter" /> class.
    /// </summary>
    /// <param name="Type">Boolean operation to apply to the provided predicates and clauses (required).</param>
    /// <param name="Clauses">Boolean &#39;and/or&#39; logic with up to two-levels of nesting.</param>
    /// <param name="Predicates">Like a three-word sentence: (attribute-name) (operator) (target-value)..</param>
    public ResolutionDetailQueryFilter(TypeEnum? Type = null, List<ResolutionDetailQueryClause> Clauses = null, List<ResolutionDetailQueryPredicate> Predicates = null)
    {
        this.Type = Type;
        this.Clauses = Clauses;
        this.Predicates = Predicates;

    }





    /// <summary>
    /// Boolean &#39;and/or&#39; logic with up to two-levels of nesting
    /// </summary>
    /// <value>Boolean &#39;and/or&#39; logic with up to two-levels of nesting</value>
    [JsonPropertyName("clauses")]
    public List<ResolutionDetailQueryClause> Clauses { get; set; }



    /// <summary>
    /// Like a three-word sentence: (attribute-name) (operator) (target-value).
    /// </summary>
    /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value).</value>
    [JsonPropertyName("predicates")]
    public List<ResolutionDetailQueryPredicate> Predicates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResolutionDetailQueryFilter {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Clauses: ").Append(Clauses).Append("\n");
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
        return Equals(obj as ResolutionDetailQueryFilter);
    }

    /// <summary>
    /// Returns true if ResolutionDetailQueryFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of ResolutionDetailQueryFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResolutionDetailQueryFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Clauses == other.Clauses ||
                Clauses != null &&
                Clauses.SequenceEqual(other.Clauses)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Clauses != null)
            {
                hash = hash * 59 + Clauses.GetHashCode();
            }

            if (Predicates != null)
            {
                hash = hash * 59 + Predicates.GetHashCode();
            }

            return hash;
        }
    }
}
