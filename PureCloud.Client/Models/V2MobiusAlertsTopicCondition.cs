using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2MobiusAlertsTopicCondition
/// </summary>
[DataContract]
public partial class V2MobiusAlertsTopicCondition : IEquatable<V2MobiusAlertsTopicCondition>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
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
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2MobiusAlertsTopicCondition" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Clauses">Clauses.</param>
    /// <param name="Predicates">Predicates.</param>
    /// <param name="Type">Type.</param>
    public V2MobiusAlertsTopicCondition(Guid? Id = null, List<V2MobiusAlertsTopicCondition> Clauses = null, List<V2MobiusAlertsTopicConditionRulePredicate> Predicates = null, TypeEnum? Type = null)
    {
        this.Id = Id;
        this.Clauses = Clauses;
        this.Predicates = Predicates;
        this.Type = Type;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets Clauses
    /// </summary>
    [DataMember(Name = "clauses", EmitDefaultValue = false)]
    public List<V2MobiusAlertsTopicCondition> Clauses { get; set; }



    /// <summary>
    /// Gets or Sets Predicates
    /// </summary>
    [DataMember(Name = "predicates", EmitDefaultValue = false)]
    public List<V2MobiusAlertsTopicConditionRulePredicate> Predicates { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2MobiusAlertsTopicCondition {\n");

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
        return this.Equals(obj as V2MobiusAlertsTopicCondition);
    }

    /// <summary>
    /// Returns true if V2MobiusAlertsTopicCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of V2MobiusAlertsTopicCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2MobiusAlertsTopicCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Clauses == other.Clauses ||
                this.Clauses != null &&
                this.Clauses.SequenceEqual(other.Clauses)
            ) &&
            (
                this.Predicates == other.Predicates ||
                this.Predicates != null &&
                this.Predicates.SequenceEqual(other.Predicates)
            ) &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Clauses != null)
            {
                hash = hash * 59 + this.Clauses.GetHashCode();
            }

            if (this.Predicates != null)
            {
                hash = hash * 59 + this.Predicates.GetHashCode();
            }

            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            return hash;
        }
    }
}
