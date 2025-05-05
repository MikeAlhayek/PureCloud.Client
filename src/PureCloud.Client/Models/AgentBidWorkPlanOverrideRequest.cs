using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentBidWorkPlanOverrideRequest
/// </summary>

public partial class AgentBidWorkPlanOverrideRequest : IEquatable<AgentBidWorkPlanOverrideRequest>
{
    /// <summary>
    /// The reason for overriding the assigned work plan. This must be null if overrideWorkPlanId is not specified
    /// </summary>
    /// <value>The reason for overriding the assigned work plan. This must be null if overrideWorkPlanId is not specified</value>
    
    public enum OverrideReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unabletobid for "UnableToBid"
        /// </summary>
        [EnumMember(Value = "UnableToBid")]
        Unabletobid,

        /// <summary>
        /// Enum Changeofcircumstance for "ChangeOfCircumstance"
        /// </summary>
        [EnumMember(Value = "ChangeOfCircumstance")]
        Changeofcircumstance,

        /// <summary>
        /// Enum Newhire for "NewHire"
        /// </summary>
        [EnumMember(Value = "NewHire")]
        Newhire,

        /// <summary>
        /// Enum Employeemove for "EmployeeMove"
        /// </summary>
        [EnumMember(Value = "EmployeeMove")]
        Employeemove
    }
    /// <summary>
    /// The reason for overriding the assigned work plan. This must be null if overrideWorkPlanId is not specified
    /// </summary>
    /// <value>The reason for overriding the assigned work plan. This must be null if overrideWorkPlanId is not specified</value>
    [JsonPropertyName("overrideReason")]
    public OverrideReasonEnum? OverrideReason { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentBidWorkPlanOverrideRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentBidWorkPlanOverrideRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentBidWorkPlanOverrideRequest" /> class.
    /// </summary>
    /// <param name="AgentId">The ID of agent (required).</param>
    /// <param name="OverrideWorkPlanId">The ID of the work plan that overrides the assigned work plan for the agent.</param>
    /// <param name="OverrideReason">The reason for overriding the assigned work plan. This must be null if overrideWorkPlanId is not specified.</param>
    public AgentBidWorkPlanOverrideRequest(string AgentId = null, string OverrideWorkPlanId = null, OverrideReasonEnum? OverrideReason = null)
    {
        this.AgentId = AgentId;
        this.OverrideWorkPlanId = OverrideWorkPlanId;
        this.OverrideReason = OverrideReason;

    }



    /// <summary>
    /// The ID of agent
    /// </summary>
    /// <value>The ID of agent</value>
    [JsonPropertyName("agentId")]
    public string AgentId { get; set; }



    /// <summary>
    /// The ID of the work plan that overrides the assigned work plan for the agent
    /// </summary>
    /// <value>The ID of the work plan that overrides the assigned work plan for the agent</value>
    [JsonPropertyName("overrideWorkPlanId")]
    public string OverrideWorkPlanId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentBidWorkPlanOverrideRequest {\n");

        sb.Append("  AgentId: ").Append(AgentId).Append("\n");
        sb.Append("  OverrideWorkPlanId: ").Append(OverrideWorkPlanId).Append("\n");
        sb.Append("  OverrideReason: ").Append(OverrideReason).Append("\n");
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
        return Equals(obj as AgentBidWorkPlanOverrideRequest);
    }

    /// <summary>
    /// Returns true if AgentBidWorkPlanOverrideRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentBidWorkPlanOverrideRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentBidWorkPlanOverrideRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AgentId == other.AgentId ||
                AgentId != null &&
                AgentId.Equals(other.AgentId)
            ) &&
            (
                OverrideWorkPlanId == other.OverrideWorkPlanId ||
                OverrideWorkPlanId != null &&
                OverrideWorkPlanId.Equals(other.OverrideWorkPlanId)
            ) &&
            (
                OverrideReason == other.OverrideReason ||
                OverrideReason != null &&
                OverrideReason.Equals(other.OverrideReason)
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
            if (AgentId != null)
            {
                hash = hash * 59 + AgentId.GetHashCode();
            }

            if (OverrideWorkPlanId != null)
            {
                hash = hash * 59 + OverrideWorkPlanId.GetHashCode();
            }

            if (OverrideReason != null)
            {
                hash = hash * 59 + OverrideReason.GetHashCode();
            }

            return hash;
        }
    }
}
