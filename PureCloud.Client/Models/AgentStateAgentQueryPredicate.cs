using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentStateAgentQueryPredicate
/// </summary>
[DataContract]
public partial class AgentStateAgentQueryPredicate : IEquatable<AgentStateAgentQueryPredicate>
{
    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DimensionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Activequeueid for "activeQueueId"
        /// </summary>
        [EnumMember(Value = "activeQueueId")]
        Activequeueid,

        /// <summary>
        /// Enum Assignedskillid for "assignedSkillId"
        /// </summary>
        [EnumMember(Value = "assignedSkillId")]
        Assignedskillid,

        /// <summary>
        /// Enum Assignedlanguageid for "assignedLanguageId"
        /// </summary>
        [EnumMember(Value = "assignedLanguageId")]
        Assignedlanguageid,

        /// <summary>
        /// Enum Divisionid for "divisionId"
        /// </summary>
        [EnumMember(Value = "divisionId")]
        Divisionid,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid,

        /// <summary>
        /// Enum Managerid for "managerId"
        /// </summary>
        [EnumMember(Value = "managerId")]
        Managerid
    }
    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    [DataMember(Name = "dimension", EmitDefaultValue = false)]
    public DimensionEnum? Dimension { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentStateAgentQueryPredicate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentStateAgentQueryPredicate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentStateAgentQueryPredicate" /> class.
    /// </summary>
    /// <param name="Dimension">Left hand side for dimension predicates (required).</param>
    /// <param name="Value">Right hand side for dimension predicates (required).</param>
    public AgentStateAgentQueryPredicate(DimensionEnum? Dimension = null, string Value = null)
    {
        this.Dimension = Dimension;
        this.Value = Value;

    }





    /// <summary>
    /// Right hand side for dimension predicates
    /// </summary>
    /// <value>Right hand side for dimension predicates</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentStateAgentQueryPredicate {\n");

        sb.Append("  Dimension: ").Append(Dimension).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as AgentStateAgentQueryPredicate);
    }

    /// <summary>
    /// Returns true if AgentStateAgentQueryPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentStateAgentQueryPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentStateAgentQueryPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Dimension == other.Dimension ||
                Dimension != null &&
                Dimension.Equals(other.Dimension)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (Dimension != null)
            {
                hash = hash * 59 + Dimension.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
