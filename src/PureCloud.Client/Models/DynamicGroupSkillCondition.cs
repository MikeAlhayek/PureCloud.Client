using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DynamicGroupSkillCondition
/// </summary>

public partial class DynamicGroupSkillCondition : IEquatable<DynamicGroupSkillCondition>
{
    /// <summary>
    /// Operator that will be applied to the conditions
    /// </summary>
    /// <value>Operator that will be applied to the conditions</value>
    
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
    [JsonPropertyName("operation")]
    public OperationEnum? Operation { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicGroupSkillCondition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DynamicGroupSkillCondition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicGroupSkillCondition" /> class.
    /// </summary>
    /// <param name="RoutingSkillConditions">Routing skill conditions that will be used for building the query (required).</param>
    /// <param name="LanguageSkillConditions">Routing skill conditions that will be used for building the query (required).</param>
    /// <param name="Operation">Operator that will be applied to the conditions (required).</param>
    public DynamicGroupSkillCondition(List<DynamicGroupRoutingSkillCondition> RoutingSkillConditions = null, List<DynamicGroupLanguageSkillCondition> LanguageSkillConditions = null, OperationEnum? Operation = null)
    {
        this.RoutingSkillConditions = RoutingSkillConditions;
        this.LanguageSkillConditions = LanguageSkillConditions;
        this.Operation = Operation;

    }



    /// <summary>
    /// Routing skill conditions that will be used for building the query
    /// </summary>
    /// <value>Routing skill conditions that will be used for building the query</value>
    [JsonPropertyName("routingSkillConditions")]
    public List<DynamicGroupRoutingSkillCondition> RoutingSkillConditions { get; set; }



    /// <summary>
    /// Routing skill conditions that will be used for building the query
    /// </summary>
    /// <value>Routing skill conditions that will be used for building the query</value>
    [JsonPropertyName("languageSkillConditions")]
    public List<DynamicGroupLanguageSkillCondition> LanguageSkillConditions { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DynamicGroupSkillCondition {\n");

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
        return Equals(obj as DynamicGroupSkillCondition);
    }

    /// <summary>
    /// Returns true if DynamicGroupSkillCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of DynamicGroupSkillCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DynamicGroupSkillCondition other)
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
