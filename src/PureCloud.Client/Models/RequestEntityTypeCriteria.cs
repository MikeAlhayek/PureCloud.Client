using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RequestEntityTypeCriteria
/// </summary>

public partial class RequestEntityTypeCriteria : IEquatable<RequestEntityTypeCriteria>
{
    /// <summary>
    /// The comparison operator.
    /// </summary>
    /// <value>The comparison operator.</value>
    
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
        /// Enum Containsall for "containsAll"
        /// </summary>
        [EnumMember(Value = "containsAll")]
        Containsall,

        /// <summary>
        /// Enum Containsany for "containsAny"
        /// </summary>
        [EnumMember(Value = "containsAny")]
        Containsany,

        /// <summary>
        /// Enum Notcontainsall for "notContainsAll"
        /// </summary>
        [EnumMember(Value = "notContainsAll")]
        Notcontainsall,

        /// <summary>
        /// Enum Notcontainsany for "notContainsAny"
        /// </summary>
        [EnumMember(Value = "notContainsAny")]
        Notcontainsany,

        /// <summary>
        /// Enum Equal for "equal"
        /// </summary>
        [EnumMember(Value = "equal")]
        Equal,

        /// <summary>
        /// Enum Notequal for "notEqual"
        /// </summary>
        [EnumMember(Value = "notEqual")]
        Notequal,

        /// <summary>
        /// Enum Greaterthan for "greaterThan"
        /// </summary>
        [EnumMember(Value = "greaterThan")]
        Greaterthan,

        /// <summary>
        /// Enum Greaterthanorequal for "greaterThanOrEqual"
        /// </summary>
        [EnumMember(Value = "greaterThanOrEqual")]
        Greaterthanorequal,

        /// <summary>
        /// Enum Lessthan for "lessThan"
        /// </summary>
        [EnumMember(Value = "lessThan")]
        Lessthan,

        /// <summary>
        /// Enum Lessthanorequal for "lessThanOrEqual"
        /// </summary>
        [EnumMember(Value = "lessThanOrEqual")]
        Lessthanorequal,

        /// <summary>
        /// Enum Startswith for "startsWith"
        /// </summary>
        [EnumMember(Value = "startsWith")]
        Startswith,

        /// <summary>
        /// Enum Endswith for "endsWith"
        /// </summary>
        [EnumMember(Value = "endsWith")]
        Endswith
    }
    /// <summary>
    /// The entity to match the pattern against.
    /// </summary>
    /// <value>The entity to match the pattern against.</value>
    
    public enum EntityTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Visit for "visit"
        /// </summary>
        [EnumMember(Value = "visit")]
        Visit
    }
    /// <summary>
    /// The comparison operator.
    /// </summary>
    /// <value>The comparison operator.</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// The entity to match the pattern against.
    /// </summary>
    /// <value>The entity to match the pattern against.</value>
    [JsonPropertyName("entityType")]
    public EntityTypeEnum? EntityType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RequestEntityTypeCriteria" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RequestEntityTypeCriteria() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RequestEntityTypeCriteria" /> class.
    /// </summary>
    /// <param name="Key">The criteria key. (required).</param>
    /// <param name="Values">The criteria values. (required).</param>
    /// <param name="ShouldIgnoreCase">Should criteria be case insensitive..</param>
    /// <param name="Operator">The comparison operator..</param>
    /// <param name="EntityType">The entity to match the pattern against. (required).</param>
    public RequestEntityTypeCriteria(string Key = null, List<string> Values = null, bool? ShouldIgnoreCase = null, OperatorEnum? Operator = null, EntityTypeEnum? EntityType = null)
    {
        this.Key = Key;
        this.Values = Values;
        this.ShouldIgnoreCase = ShouldIgnoreCase;
        this.Operator = Operator;
        this.EntityType = EntityType;

    }



    /// <summary>
    /// The criteria key.
    /// </summary>
    /// <value>The criteria key.</value>
    [JsonPropertyName("key")]
    public string Key { get; set; }



    /// <summary>
    /// The criteria values.
    /// </summary>
    /// <value>The criteria values.</value>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; }



    /// <summary>
    /// Should criteria be case insensitive.
    /// </summary>
    /// <value>Should criteria be case insensitive.</value>
    [JsonPropertyName("shouldIgnoreCase")]
    public bool? ShouldIgnoreCase { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RequestEntityTypeCriteria {\n");

        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  ShouldIgnoreCase: ").Append(ShouldIgnoreCase).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
        return Equals(obj as RequestEntityTypeCriteria);
    }

    /// <summary>
    /// Returns true if RequestEntityTypeCriteria instances are equal
    /// </summary>
    /// <param name="other">Instance of RequestEntityTypeCriteria to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RequestEntityTypeCriteria other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Key == other.Key ||
                Key != null &&
                Key.Equals(other.Key)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
            ) &&
            (
                ShouldIgnoreCase == other.ShouldIgnoreCase ||
                ShouldIgnoreCase != null &&
                ShouldIgnoreCase.Equals(other.ShouldIgnoreCase)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
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
            if (Key != null)
            {
                hash = hash * 59 + Key.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            if (ShouldIgnoreCase != null)
            {
                hash = hash * 59 + ShouldIgnoreCase.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            return hash;
        }
    }
}
