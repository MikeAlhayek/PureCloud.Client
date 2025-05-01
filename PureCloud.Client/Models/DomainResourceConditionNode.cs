using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainResourceConditionNode
/// </summary>
[DataContract]
public partial class DomainResourceConditionNode : IEquatable<DomainResourceConditionNode>
{
    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
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
        /// Enum Eq for "EQ"
        /// </summary>
        [EnumMember(Value = "EQ")]
        Eq,

        /// <summary>
        /// Enum In for "IN"
        /// </summary>
        [EnumMember(Value = "IN")]
        In,

        /// <summary>
        /// Enum Ge for "GE"
        /// </summary>
        [EnumMember(Value = "GE")]
        Ge,

        /// <summary>
        /// Enum Gt for "GT"
        /// </summary>
        [EnumMember(Value = "GT")]
        Gt,

        /// <summary>
        /// Enum Le for "LE"
        /// </summary>
        [EnumMember(Value = "LE")]
        Le,

        /// <summary>
        /// Enum Lt for "LT"
        /// </summary>
        [EnumMember(Value = "LT")]
        Lt
    }
    /// <summary>
    /// Gets or Sets Conjunction
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ConjunctionEnum
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
    /// Gets or Sets Operator
    /// </summary>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Gets or Sets Conjunction
    /// </summary>
    [DataMember(Name = "conjunction", EmitDefaultValue = false)]
    public ConjunctionEnum? Conjunction { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainResourceConditionNode" /> class.
    /// </summary>
    /// <param name="VariableName">VariableName.</param>
    /// <param name="Operator">Operator.</param>
    /// <param name="Operands">Operands.</param>
    /// <param name="Conjunction">Conjunction.</param>
    /// <param name="Terms">Terms.</param>
    public DomainResourceConditionNode(string VariableName = null, OperatorEnum? Operator = null, List<DomainResourceConditionValue> Operands = null, ConjunctionEnum? Conjunction = null, List<DomainResourceConditionNode> Terms = null)
    {
        this.VariableName = VariableName;
        this.Operator = Operator;
        this.Operands = Operands;
        this.Conjunction = Conjunction;
        this.Terms = Terms;

    }



    /// <summary>
    /// Gets or Sets VariableName
    /// </summary>
    [DataMember(Name = "variableName", EmitDefaultValue = false)]
    public string VariableName { get; set; }





    /// <summary>
    /// Gets or Sets Operands
    /// </summary>
    [DataMember(Name = "operands", EmitDefaultValue = false)]
    public List<DomainResourceConditionValue> Operands { get; set; }





    /// <summary>
    /// Gets or Sets Terms
    /// </summary>
    [DataMember(Name = "terms", EmitDefaultValue = false)]
    public List<DomainResourceConditionNode> Terms { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainResourceConditionNode {\n");

        sb.Append("  VariableName: ").Append(VariableName).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Operands: ").Append(Operands).Append("\n");
        sb.Append("  Conjunction: ").Append(Conjunction).Append("\n");
        sb.Append("  Terms: ").Append(Terms).Append("\n");
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
        return Equals(obj as DomainResourceConditionNode);
    }

    /// <summary>
    /// Returns true if DomainResourceConditionNode instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainResourceConditionNode to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainResourceConditionNode other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                VariableName == other.VariableName ||
                VariableName != null &&
                VariableName.Equals(other.VariableName)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Operands == other.Operands ||
                Operands != null &&
                Operands.SequenceEqual(other.Operands)
            ) &&
            (
                Conjunction == other.Conjunction ||
                Conjunction != null &&
                Conjunction.Equals(other.Conjunction)
            ) &&
            (
                Terms == other.Terms ||
                Terms != null &&
                Terms.SequenceEqual(other.Terms)
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
            if (VariableName != null)
            {
                hash = hash * 59 + VariableName.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Operands != null)
            {
                hash = hash * 59 + Operands.GetHashCode();
            }

            if (Conjunction != null)
            {
                hash = hash * 59 + Conjunction.GetHashCode();
            }

            if (Terms != null)
            {
                hash = hash * 59 + Terms.GetHashCode();
            }

            return hash;
        }
    }
}
