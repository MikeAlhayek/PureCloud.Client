using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanBidGroupUpdate
/// </summary>

public partial class WorkPlanBidGroupUpdate : IEquatable<WorkPlanBidGroupUpdate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanBidGroupUpdate" /> class.
    /// </summary>
    /// <param name="Name">The name of the work plan bid group.</param>
    /// <param name="ManagementUnitId">The management unit ID used for this work plan bid group.</param>
    /// <param name="AgentIds">Agent IDs who participate in this bid group.</param>
    /// <param name="WorkPlans">The list of work plans used in this bid group.</param>
    /// <param name="PlanningGroupIds">The planning group IDs selected in this bid group.</param>
    public WorkPlanBidGroupUpdate(string Name = null, string ManagementUnitId = null, ListWrapperString AgentIds = null, ListWrapperBidGroupWorkPlanRequest WorkPlans = null, ListWrapperString PlanningGroupIds = null)
    {
        this.Name = Name;
        this.ManagementUnitId = ManagementUnitId;
        this.AgentIds = AgentIds;
        this.WorkPlans = WorkPlans;
        this.PlanningGroupIds = PlanningGroupIds;

    }



    /// <summary>
    /// The name of the work plan bid group
    /// </summary>
    /// <value>The name of the work plan bid group</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The management unit ID used for this work plan bid group
    /// </summary>
    /// <value>The management unit ID used for this work plan bid group</value>
    [JsonPropertyName("managementUnitId")]
    public string ManagementUnitId { get; set; }



    /// <summary>
    /// Agent IDs who participate in this bid group
    /// </summary>
    /// <value>Agent IDs who participate in this bid group</value>
    [JsonPropertyName("agentIds")]
    public ListWrapperString AgentIds { get; set; }



    /// <summary>
    /// The list of work plans used in this bid group
    /// </summary>
    /// <value>The list of work plans used in this bid group</value>
    [JsonPropertyName("workPlans")]
    public ListWrapperBidGroupWorkPlanRequest WorkPlans { get; set; }



    /// <summary>
    /// The planning group IDs selected in this bid group
    /// </summary>
    /// <value>The planning group IDs selected in this bid group</value>
    [JsonPropertyName("planningGroupIds")]
    public ListWrapperString PlanningGroupIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanBidGroupUpdate {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
        sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
        sb.Append("  WorkPlans: ").Append(WorkPlans).Append("\n");
        sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
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
        return Equals(obj as WorkPlanBidGroupUpdate);
    }

    /// <summary>
    /// Returns true if WorkPlanBidGroupUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanBidGroupUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanBidGroupUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ManagementUnitId == other.ManagementUnitId ||
                ManagementUnitId != null &&
                ManagementUnitId.Equals(other.ManagementUnitId)
            ) &&
            (
                AgentIds == other.AgentIds ||
                AgentIds != null &&
                AgentIds.Equals(other.AgentIds)
            ) &&
            (
                WorkPlans == other.WorkPlans ||
                WorkPlans != null &&
                WorkPlans.Equals(other.WorkPlans)
            ) &&
            (
                PlanningGroupIds == other.PlanningGroupIds ||
                PlanningGroupIds != null &&
                PlanningGroupIds.Equals(other.PlanningGroupIds)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ManagementUnitId != null)
            {
                hash = hash * 59 + ManagementUnitId.GetHashCode();
            }

            if (AgentIds != null)
            {
                hash = hash * 59 + AgentIds.GetHashCode();
            }

            if (WorkPlans != null)
            {
                hash = hash * 59 + WorkPlans.GetHashCode();
            }

            if (PlanningGroupIds != null)
            {
                hash = hash * 59 + PlanningGroupIds.GetHashCode();
            }

            return hash;
        }
    }
}
