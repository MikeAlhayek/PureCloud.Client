using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SkillGroupCondition
/// </summary>
[DataContract]
public partial class SkillGroupCondition : IEquatable<SkillGroupCondition>
{
    /// <summary>
    /// Operator that will be applied to the conditions
    /// </summary>
    /// <value>Operator that will be applied to the conditions</value>
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
        /// Enum And for "And"
        /// </summary>
        [EnumMember(Value = "And")]
        And,

        /// <summary>
        /// Enum Not for "Not"
        /// </summary>
        [EnumMember(Value = "Not")]
        Not,

        /// <summary>
        /// Enum Or for "Or"
        /// </summary>
        [EnumMember(Value = "Or")]
        Or
    }
    /// <summary>
    /// Operator that will be applied to the conditions
    /// </summary>
    /// <value>Operator that will be applied to the conditions</value>
    [DataMember(Name = "operation", EmitDefaultValue = false)]
    public OperationEnum? Operation { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SkillGroupCondition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SkillGroupCondition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SkillGroupCondition" /> class.
    /// </summary>
    /// <param name="RoutingSkillConditions">Routing skill conditions that will be used for building the query (required).</param>
    /// <param name="LanguageSkillConditions">Routing skill conditions that will be used for building the query (required).</param>
    /// <param name="Operation">Operator that will be applied to the conditions (required).</param>
    public SkillGroupCondition(List<SkillGroupRoutingCondition> RoutingSkillConditions = null, List<SkillGroupLanguageCondition> LanguageSkillConditions = null, OperationEnum? Operation = null)
    {
        this.RoutingSkillConditions = RoutingSkillConditions;
        this.LanguageSkillConditions = LanguageSkillConditions;
        this.Operation = Operation;

    }



    /// <summary>
    /// Routing skill conditions that will be used for building the query
    /// </summary>
    /// <value>Routing skill conditions that will be used for building the query</value>
    [DataMember(Name = "routingSkillConditions", EmitDefaultValue = false)]
    public List<SkillGroupRoutingCondition> RoutingSkillConditions { get; set; }



    /// <summary>
    /// Routing skill conditions that will be used for building the query
    /// </summary>
    /// <value>Routing skill conditions that will be used for building the query</value>
    [DataMember(Name = "languageSkillConditions", EmitDefaultValue = false)]
    public List<SkillGroupLanguageCondition> LanguageSkillConditions { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SkillGroupCondition {\n");

        sb.Append("  RoutingSkillConditions: ").Append(RoutingSkillConditions).Append("\n");
        sb.Append("  LanguageSkillConditions: ").Append(LanguageSkillConditions).Append("\n");
        sb.Append("  Operation: ").Append(Operation).Append("\n");
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
        return Equals(obj as SkillGroupCondition);
    }

    /// <summary>
    /// Returns true if SkillGroupCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of SkillGroupCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SkillGroupCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RoutingSkillConditions == other.RoutingSkillConditions ||
                RoutingSkillConditions != null &&
                RoutingSkillConditions.SequenceEqual(other.RoutingSkillConditions)
            ) &&
            (
                LanguageSkillConditions == other.LanguageSkillConditions ||
                LanguageSkillConditions != null &&
                LanguageSkillConditions.SequenceEqual(other.LanguageSkillConditions)
            ) &&
            (
                Operation == other.Operation ||
                Operation != null &&
                Operation.Equals(other.Operation)
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
            if (RoutingSkillConditions != null)
            {
                hash = hash * 59 + RoutingSkillConditions.GetHashCode();
            }

            if (LanguageSkillConditions != null)
            {
                hash = hash * 59 + LanguageSkillConditions.GetHashCode();
            }

            if (Operation != null)
            {
                hash = hash * 59 + Operation.GetHashCode();
            }

            return hash;
        }
    }
}
