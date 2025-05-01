using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RateLimitAggregateQueryClause
/// </summary>
[DataContract]
public partial class RateLimitAggregateQueryClause : IEquatable<RateLimitAggregateQueryClause>
{
    /// <summary>
    /// Boolean operation to apply to the provided predicates
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Boolean operation to apply to the provided predicates
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RateLimitAggregateQueryClause" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RateLimitAggregateQueryClause() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RateLimitAggregateQueryClause" /> class.
    /// </summary>
    /// <param name="Type">Boolean operation to apply to the provided predicates (required).</param>
    /// <param name="Predicates">Like a three-word sentence: (attribute-name) (operator) (target-value). (required).</param>
    public RateLimitAggregateQueryClause(TypeEnum? Type = null, List<RateLimitAggregateQueryPredicate> Predicates = null)
    {
        this.Type = Type;
        this.Predicates = Predicates;

    }





    /// <summary>
    /// Like a three-word sentence: (attribute-name) (operator) (target-value).
    /// </summary>
    /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value).</value>
    [DataMember(Name = "predicates", EmitDefaultValue = false)]
    public List<RateLimitAggregateQueryPredicate> Predicates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RateLimitAggregateQueryClause {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as RateLimitAggregateQueryClause);
    }

    /// <summary>
    /// Returns true if RateLimitAggregateQueryClause instances are equal
    /// </summary>
    /// <param name="other">Instance of RateLimitAggregateQueryClause to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RateLimitAggregateQueryClause other)
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

            if (Predicates != null)
            {
                hash = hash * 59 + Predicates.GetHashCode();
            }

            return hash;
        }
    }
}
