using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CommonRuleConditions
/// </summary>
[DataContract]
public partial class CommonRuleConditions : IEquatable<CommonRuleConditions>
{
    /// <summary>
    /// the logic operator performed.
    /// </summary>
    /// <value>the logic operator performed.</value>
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
        /// Enum And for "And"
        /// </summary>
        [EnumMember(Value = "And")]
        And,

        /// <summary>
        /// Enum Or for "Or"
        /// </summary>
        [EnumMember(Value = "Or")]
        Or,

        /// <summary>
        /// Enum Not for "Not"
        /// </summary>
        [EnumMember(Value = "Not")]
        Not
    }
    /// <summary>
    /// the logic operator performed.
    /// </summary>
    /// <value>the logic operator performed.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRuleConditions" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CommonRuleConditions() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRuleConditions" /> class.
    /// </summary>
    /// <param name="Clauses">The list of predicates groups to be evaluated.</param>
    /// <param name="Predicates">The list of rule metric predicates to be evaluated. (required).</param>
    /// <param name="Type">the logic operator performed. (required).</param>
    /// <param name="Id">The id..</param>
    public CommonRuleConditions(List<CommonRuleConditions> Clauses = null, List<CommonRulePredicate> Predicates = null, TypeEnum? Type = null, string Id = null)
    {
        this.Clauses = Clauses;
        this.Predicates = Predicates;
        this.Type = Type;
        this.Id = Id;

    }



    /// <summary>
    /// The list of predicates groups to be evaluated
    /// </summary>
    /// <value>The list of predicates groups to be evaluated</value>
    [DataMember(Name = "clauses", EmitDefaultValue = false)]
    public List<CommonRuleConditions> Clauses { get; set; }



    /// <summary>
    /// The list of rule metric predicates to be evaluated.
    /// </summary>
    /// <value>The list of rule metric predicates to be evaluated.</value>
    [DataMember(Name = "predicates", EmitDefaultValue = false)]
    public List<CommonRulePredicate> Predicates { get; set; }





    /// <summary>
    /// The id.
    /// </summary>
    /// <value>The id.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CommonRuleConditions {\n");

        sb.Append("  Clauses: ").Append(Clauses).Append("\n");
        sb.Append("  Predicates: ").Append(Predicates).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as CommonRuleConditions);
    }

    /// <summary>
    /// Returns true if CommonRuleConditions instances are equal
    /// </summary>
    /// <param name="other">Instance of CommonRuleConditions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CommonRuleConditions other)
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
                Predicates == other.Predicates ||
                Predicates != null &&
                Predicates.SequenceEqual(other.Predicates)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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

            if (Predicates != null)
            {
                hash = hash * 59 + Predicates.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}
