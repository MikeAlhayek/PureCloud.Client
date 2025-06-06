using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateMuAgentWorkPlanRequest
/// </summary>

public partial class UpdateMuAgentWorkPlanRequest : IEquatable<UpdateMuAgentWorkPlanRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateMuAgentWorkPlanRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateMuAgentWorkPlanRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateMuAgentWorkPlanRequest" /> class.
    /// </summary>
    /// <param name="UserId">The agent id for whom the work plan is updated (required).</param>
    /// <param name="WorkPlanId">The current work plan ID for the agent.</param>
    /// <param name="WorkPlanOverrides">The list of work plan overrides for the agent.</param>
    public UpdateMuAgentWorkPlanRequest(string UserId = null, ValueWrapperString WorkPlanId = null, WorkPlanOverrideListWrapperWorkPlanOverrideRequest WorkPlanOverrides = null)
    {
        this.UserId = UserId;
        this.WorkPlanId = WorkPlanId;
        this.WorkPlanOverrides = WorkPlanOverrides;

    }



    /// <summary>
    /// The agent id for whom the work plan is updated
    /// </summary>
    /// <value>The agent id for whom the work plan is updated</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// The current work plan ID for the agent
    /// </summary>
    /// <value>The current work plan ID for the agent</value>
    [JsonPropertyName("workPlanId")]
    public ValueWrapperString WorkPlanId { get; set; }



    /// <summary>
    /// The list of work plan overrides for the agent
    /// </summary>
    /// <value>The list of work plan overrides for the agent</value>
    [JsonPropertyName("workPlanOverrides")]
    public WorkPlanOverrideListWrapperWorkPlanOverrideRequest WorkPlanOverrides { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateMuAgentWorkPlanRequest {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
        sb.Append("  WorkPlanOverrides: ").Append(WorkPlanOverrides).Append("\n");
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
        return Equals(obj as UpdateMuAgentWorkPlanRequest);
    }

    /// <summary>
    /// Returns true if UpdateMuAgentWorkPlanRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateMuAgentWorkPlanRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateMuAgentWorkPlanRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                WorkPlanId == other.WorkPlanId ||
                WorkPlanId != null &&
                WorkPlanId.Equals(other.WorkPlanId)
            ) &&
            (
                WorkPlanOverrides == other.WorkPlanOverrides ||
                WorkPlanOverrides != null &&
                WorkPlanOverrides.Equals(other.WorkPlanOverrides)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (WorkPlanId != null)
            {
                hash = hash * 59 + WorkPlanId.GetHashCode();
            }

            if (WorkPlanOverrides != null)
            {
                hash = hash * 59 + WorkPlanOverrides.GetHashCode();
            }

            return hash;
        }
    }
}
