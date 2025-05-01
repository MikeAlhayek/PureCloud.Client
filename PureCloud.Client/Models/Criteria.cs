using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Criteria
/// </summary>
[DataContract]
public partial class Criteria : IEquatable<Criteria>
{
    /// <summary>
    /// The comparison operator.
    /// </summary>
    /// <value>The comparison operator.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// The comparison operator.
    /// </summary>
    /// <value>The comparison operator.</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Criteria" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Criteria() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Criteria" /> class.
    /// </summary>
    /// <param name="Key">The criteria key. (required).</param>
    /// <param name="Values">The criteria values. (required).</param>
    /// <param name="ShouldIgnoreCase">Should criteria be case insensitive. (required).</param>
    /// <param name="Operator">The comparison operator. (required).</param>
    public Criteria(string Key = null, List<string> Values = null, bool? ShouldIgnoreCase = null, OperatorEnum? Operator = null)
    {
        this.Key = Key;
        this.Values = Values;
        this.ShouldIgnoreCase = ShouldIgnoreCase;
        this.Operator = Operator;

    }



    /// <summary>
    /// The criteria key.
    /// </summary>
    /// <value>The criteria key.</value>
    [DataMember(Name = "key", EmitDefaultValue = false)]
    public string Key { get; set; }



    /// <summary>
    /// The criteria values.
    /// </summary>
    /// <value>The criteria values.</value>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<string> Values { get; set; }



    /// <summary>
    /// Should criteria be case insensitive.
    /// </summary>
    /// <value>Should criteria be case insensitive.</value>
    [DataMember(Name = "shouldIgnoreCase", EmitDefaultValue = false)]
    public bool? ShouldIgnoreCase { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Criteria {\n");

        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  ShouldIgnoreCase: ").Append(ShouldIgnoreCase).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
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
        return Equals(obj as Criteria);
    }

    /// <summary>
    /// Returns true if Criteria instances are equal
    /// </summary>
    /// <param name="other">Instance of Criteria to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Criteria other)
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

            return hash;
        }
    }
}
