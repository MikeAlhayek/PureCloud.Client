using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningModuleRuleParts
/// </summary>
[DataContract]
public partial class LearningModuleRuleParts : IEquatable<LearningModuleRuleParts>
{
    /// <summary>
    /// The learning module rule operation
    /// </summary>
    /// <value>The learning module rule operation</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Include for "Include"
        /// </summary>
        [EnumMember(Value = "Include")]
        Include,

        /// <summary>
        /// Enum Exclude for "Exclude"
        /// </summary>
        [EnumMember(Value = "Exclude")]
        Exclude
    }
    /// <summary>
    /// The learning module rule selector
    /// </summary>
    /// <value>The learning module rule selector</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SelectorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Acdskills for "AcdSkills"
        /// </summary>
        [EnumMember(Value = "AcdSkills")]
        Acdskills,

        /// <summary>
        /// Enum Agentname for "AgentName"
        /// </summary>
        [EnumMember(Value = "AgentName")]
        Agentname,

        /// <summary>
        /// Enum Division for "Division"
        /// </summary>
        [EnumMember(Value = "Division")]
        Division,

        /// <summary>
        /// Enum Group for "Group"
        /// </summary>
        [EnumMember(Value = "Group")]
        Group,

        /// <summary>
        /// Enum Location for "Location"
        /// </summary>
        [EnumMember(Value = "Location")]
        Location,

        /// <summary>
        /// Enum Queue for "Queue"
        /// </summary>
        [EnumMember(Value = "Queue")]
        Queue,

        /// <summary>
        /// Enum Role for "Role"
        /// </summary>
        [EnumMember(Value = "Role")]
        Role,

        /// <summary>
        /// Enum Team for "Team"
        /// </summary>
        [EnumMember(Value = "Team")]
        Team,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User
    }
    /// <summary>
    /// The learning module rule operation
    /// </summary>
    /// <value>The learning module rule operation</value>
    [DataMember(Name = "operation", EmitDefaultValue = false)]
    public OperationEnum? Operation { get; set; }
    /// <summary>
    /// The learning module rule selector
    /// </summary>
    /// <value>The learning module rule selector</value>
    [DataMember(Name = "selector", EmitDefaultValue = false)]
    public SelectorEnum? Selector { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleRuleParts" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningModuleRuleParts() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleRuleParts" /> class.
    /// </summary>
    /// <param name="Operation">The learning module rule operation (required).</param>
    /// <param name="Selector">The learning module rule selector (required).</param>
    /// <param name="Value">The value of rules (required).</param>
    /// <param name="Order">The order of rules in learning module rule (required).</param>
    public LearningModuleRuleParts(OperationEnum? Operation = null, SelectorEnum? Selector = null, List<string> Value = null, int? Order = null)
    {
        this.Operation = Operation;
        this.Selector = Selector;
        this.Value = Value;
        this.Order = Order;

    }







    /// <summary>
    /// The value of rules
    /// </summary>
    /// <value>The value of rules</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public List<string> Value { get; set; }



    /// <summary>
    /// The order of rules in learning module rule
    /// </summary>
    /// <value>The order of rules in learning module rule</value>
    [DataMember(Name = "order", EmitDefaultValue = false)]
    public int? Order { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModuleRuleParts {\n");

        sb.Append("  Operation: ").Append(Operation).Append("\n");
        sb.Append("  Selector: ").Append(Selector).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
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
        return Equals(obj as LearningModuleRuleParts);
    }

    /// <summary>
    /// Returns true if LearningModuleRuleParts instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModuleRuleParts to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModuleRuleParts other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Operation == other.Operation ||
                Operation != null &&
                Operation.Equals(other.Operation)
            ) &&
            (
                Selector == other.Selector ||
                Selector != null &&
                Selector.Equals(other.Selector)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.SequenceEqual(other.Value)
            ) &&
            (
                Order == other.Order ||
                Order != null &&
                Order.Equals(other.Order)
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
            if (Operation != null)
            {
                hash = hash * 59 + Operation.GetHashCode();
            }

            if (Selector != null)
            {
                hash = hash * 59 + Selector.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Order != null)
            {
                hash = hash * 59 + Order.GetHashCode();
            }

            return hash;
        }
    }
}
