using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentWorkPlanBiddingPreferenceRequest
/// </summary>

public partial class AgentWorkPlanBiddingPreferenceRequest : IEquatable<AgentWorkPlanBiddingPreferenceRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanBiddingPreferenceRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentWorkPlanBiddingPreferenceRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanBiddingPreferenceRequest" /> class.
    /// </summary>
    /// <param name="WorkPlanId">The ID of the work plan that belongs to agent&#39;s bid group (required).</param>
    /// <param name="Priority">The agent&#39;s priority for this work plan, with 1 being the best priority. Null if priority is not set for the work plan.</param>
    public AgentWorkPlanBiddingPreferenceRequest(string WorkPlanId = null, int? Priority = null)
    {
        this.WorkPlanId = WorkPlanId;
        this.Priority = Priority;

    }



    /// <summary>
    /// The ID of the work plan that belongs to agent&#39;s bid group
    /// </summary>
    /// <value>The ID of the work plan that belongs to agent&#39;s bid group</value>
    [JsonPropertyName("workPlanId")]
    public string WorkPlanId { get; set; }



    /// <summary>
    /// The agent&#39;s priority for this work plan, with 1 being the best priority. Null if priority is not set for the work plan
    /// </summary>
    /// <value>The agent&#39;s priority for this work plan, with 1 being the best priority. Null if priority is not set for the work plan</value>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentWorkPlanBiddingPreferenceRequest {\n");

        sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
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
        return Equals(obj as AgentWorkPlanBiddingPreferenceRequest);
    }

    /// <summary>
    /// Returns true if AgentWorkPlanBiddingPreferenceRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentWorkPlanBiddingPreferenceRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentWorkPlanBiddingPreferenceRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WorkPlanId == other.WorkPlanId ||
                WorkPlanId != null &&
                WorkPlanId.Equals(other.WorkPlanId)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
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
            if (WorkPlanId != null)
            {
                hash = hash * 59 + WorkPlanId.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            return hash;
        }
    }
}
