using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanBidGroup
/// </summary>

public partial class WorkPlanBidGroup : IEquatable<WorkPlanBidGroup>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanBidGroup" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkPlanBidGroup() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanBidGroup" /> class.
    /// </summary>
    /// <param name="Name">The name of the work plan bid group (required).</param>
    /// <param name="ManagementUnit">The management unit this bid group belongs to (required).</param>
    /// <param name="Agents">The list of agents who participate in this bid group (required).</param>
    /// <param name="WorkPlans">The list of work plans used in this bid group (required).</param>
    /// <param name="PlanningGroups">The list of planning groups selected in this bid group (required).</param>
    public WorkPlanBidGroup(string Name = null, ManagementUnitReference ManagementUnit = null, List<UserReference> Agents = null, List<BidGroupWorkPlanResponse> WorkPlans = null, List<PlanningGroupReference> PlanningGroups = null)
    {
        this.Name = Name;
        this.ManagementUnit = ManagementUnit;
        this.Agents = Agents;
        this.WorkPlans = WorkPlans;
        this.PlanningGroups = PlanningGroups;

    }



    /// <summary>
    /// The name of the work plan bid group
    /// </summary>
    /// <value>The name of the work plan bid group</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The management unit this bid group belongs to
    /// </summary>
    /// <value>The management unit this bid group belongs to</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// The list of agents who participate in this bid group
    /// </summary>
    /// <value>The list of agents who participate in this bid group</value>
    [JsonPropertyName("agents")]
    public List<UserReference> Agents { get; set; }



    /// <summary>
    /// The list of work plans used in this bid group
    /// </summary>
    /// <value>The list of work plans used in this bid group</value>
    [JsonPropertyName("workPlans")]
    public List<BidGroupWorkPlanResponse> WorkPlans { get; set; }



    /// <summary>
    /// The list of planning groups selected in this bid group
    /// </summary>
    /// <value>The list of planning groups selected in this bid group</value>
    [JsonPropertyName("planningGroups")]
    public List<PlanningGroupReference> PlanningGroups { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanBidGroup {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  Agents: ").Append(Agents).Append("\n");
        sb.Append("  WorkPlans: ").Append(WorkPlans).Append("\n");
        sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
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
        return Equals(obj as WorkPlanBidGroup);
    }

    /// <summary>
    /// Returns true if WorkPlanBidGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanBidGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanBidGroup other)
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
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
            ) &&
            (
                Agents == other.Agents ||
                Agents != null &&
                Agents.SequenceEqual(other.Agents)
            ) &&
            (
                WorkPlans == other.WorkPlans ||
                WorkPlans != null &&
                WorkPlans.SequenceEqual(other.WorkPlans)
            ) &&
            (
                PlanningGroups == other.PlanningGroups ||
                PlanningGroups != null &&
                PlanningGroups.SequenceEqual(other.PlanningGroups)
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

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            if (Agents != null)
            {
                hash = hash * 59 + Agents.GetHashCode();
            }

            if (WorkPlans != null)
            {
                hash = hash * 59 + WorkPlans.GetHashCode();
            }

            if (PlanningGroups != null)
            {
                hash = hash * 59 + PlanningGroups.GetHashCode();
            }

            return hash;
        }
    }
}
