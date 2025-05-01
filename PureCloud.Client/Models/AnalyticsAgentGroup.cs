using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsAgentGroup
/// </summary>
[DataContract]
public partial class AnalyticsAgentGroup : IEquatable<AnalyticsAgentGroup>
{
    /// <summary>
    /// Conditional group routing agent group type
    /// </summary>
    /// <value>Conditional group routing agent group type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AgentGroupTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Group for "Group"
        /// </summary>
        [EnumMember(Value = "Group")]
        Group,

        /// <summary>
        /// Enum Skillgroup for "SkillGroup"
        /// </summary>
        [EnumMember(Value = "SkillGroup")]
        Skillgroup,

        /// <summary>
        /// Enum Team for "Team"
        /// </summary>
        [EnumMember(Value = "Team")]
        Team
    }
    /// <summary>
    /// Conditional group routing agent group type
    /// </summary>
    /// <value>Conditional group routing agent group type</value>
    [DataMember(Name = "agentGroupType", EmitDefaultValue = false)]
    public AgentGroupTypeEnum? AgentGroupType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsAgentGroup" /> class.
    /// </summary>
    /// <param name="AgentGroupId">Conditional group routing agent group identifier.</param>
    /// <param name="AgentGroupType">Conditional group routing agent group type.</param>
    public AnalyticsAgentGroup(string AgentGroupId = null, AgentGroupTypeEnum? AgentGroupType = null)
    {
        this.AgentGroupId = AgentGroupId;
        this.AgentGroupType = AgentGroupType;

    }



    /// <summary>
    /// Conditional group routing agent group identifier
    /// </summary>
    /// <value>Conditional group routing agent group identifier</value>
    [DataMember(Name = "agentGroupId", EmitDefaultValue = false)]
    public string AgentGroupId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsAgentGroup {\n");

        sb.Append("  AgentGroupId: ").Append(AgentGroupId).Append("\n");
        sb.Append("  AgentGroupType: ").Append(AgentGroupType).Append("\n");
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
        return Equals(obj as AnalyticsAgentGroup);
    }

    /// <summary>
    /// Returns true if AnalyticsAgentGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsAgentGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsAgentGroup other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AgentGroupId == other.AgentGroupId ||
                AgentGroupId != null &&
                AgentGroupId.Equals(other.AgentGroupId)
            ) &&
            (
                AgentGroupType == other.AgentGroupType ||
                AgentGroupType != null &&
                AgentGroupType.Equals(other.AgentGroupType)
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
            if (AgentGroupId != null)
            {
                hash = hash * 59 + AgentGroupId.GetHashCode();
            }

            if (AgentGroupType != null)
            {
                hash = hash * 59 + AgentGroupType.GetHashCode();
            }

            return hash;
        }
    }
}
