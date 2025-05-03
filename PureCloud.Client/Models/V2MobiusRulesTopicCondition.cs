using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2MobiusRulesTopicCondition
/// </summary>

public partial class V2MobiusRulesTopicCondition : IEquatable<V2MobiusRulesTopicCondition>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
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
        Not,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2MobiusRulesTopicCondition" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Clauses">Clauses.</param>
    /// <param name="Predicates">Predicates.</param>
    /// <param name="Type">Type.</param>
    public V2MobiusRulesTopicCondition(Guid? Id = null, List<V2MobiusRulesTopicCondition> Clauses = null, List<V2MobiusRulesTopicConditionRulePredicate> Predicates = null, TypeEnum? Type = null)
    {
        this.Id = Id;
        this.Clauses = Clauses;
        this.Predicates = Predicates;
        this.Type = Type;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets Clauses
    /// </summary>
    [JsonPropertyName("clauses")]
    public List<V2MobiusRulesTopicCondition> Clauses { get; set; }



    /// <summary>
    /// Gets or Sets Predicates
    /// </summary>
    [JsonPropertyName("predicates")]
    public List<V2MobiusRulesTopicConditionRulePredicate> Predicates { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2MobiusRulesTopicCondition {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Clauses: ").Append(Clauses).Append("\n");
        sb.Append("  Predicates: ").Append(Predicates).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as V2MobiusRulesTopicCondition);
    }

    /// <summary>
    /// Returns true if V2MobiusRulesTopicCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of V2MobiusRulesTopicCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2MobiusRulesTopicCondition other)
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

            return hash;
        }
    }
}
