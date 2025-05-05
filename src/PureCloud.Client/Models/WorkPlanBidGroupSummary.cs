using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanBidGroupSummary
/// </summary>

public partial class WorkPlanBidGroupSummary : IEquatable<WorkPlanBidGroupSummary>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanBidGroupSummary" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkPlanBidGroupSummary() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanBidGroupSummary" /> class.
    /// </summary>
    /// <param name="Name">The name assigned to this bid group (required).</param>
    /// <param name="ManagementUnit">The management unit this bid group belongs to (required).</param>
    /// <param name="AgentCount">The number of agents in this bid group (required).</param>
    /// <param name="WorkPlanCount">The number of work plans in this bid group (required).</param>
    /// <param name="PlanningGroupCount">The number of planning groups in this bid group (required).</param>
    public WorkPlanBidGroupSummary(string Name = null, ManagementUnitReference ManagementUnit = null, int? AgentCount = null, int? WorkPlanCount = null, int? PlanningGroupCount = null)
    {
        this.Name = Name;
        this.ManagementUnit = ManagementUnit;
        this.AgentCount = AgentCount;
        this.WorkPlanCount = WorkPlanCount;
        this.PlanningGroupCount = PlanningGroupCount;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name assigned to this bid group
    /// </summary>
    /// <value>The name assigned to this bid group</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The management unit this bid group belongs to
    /// </summary>
    /// <value>The management unit this bid group belongs to</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// The number of agents in this bid group
    /// </summary>
    /// <value>The number of agents in this bid group</value>
    [JsonPropertyName("agentCount")]
    public int? AgentCount { get; set; }



    /// <summary>
    /// The number of work plans in this bid group
    /// </summary>
    /// <value>The number of work plans in this bid group</value>
    [JsonPropertyName("workPlanCount")]
    public int? WorkPlanCount { get; set; }



    /// <summary>
    /// The number of planning groups in this bid group
    /// </summary>
    /// <value>The number of planning groups in this bid group</value>
    [JsonPropertyName("planningGroupCount")]
    public int? PlanningGroupCount { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanBidGroupSummary {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
        sb.Append("  WorkPlanCount: ").Append(WorkPlanCount).Append("\n");
        sb.Append("  PlanningGroupCount: ").Append(PlanningGroupCount).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as WorkPlanBidGroupSummary);
    }

    /// <summary>
    /// Returns true if WorkPlanBidGroupSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanBidGroupSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanBidGroupSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
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
                AgentCount == other.AgentCount ||
                AgentCount != null &&
                AgentCount.Equals(other.AgentCount)
            ) &&
            (
                WorkPlanCount == other.WorkPlanCount ||
                WorkPlanCount != null &&
                WorkPlanCount.Equals(other.WorkPlanCount)
            ) &&
            (
                PlanningGroupCount == other.PlanningGroupCount ||
                PlanningGroupCount != null &&
                PlanningGroupCount.Equals(other.PlanningGroupCount)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            if (AgentCount != null)
            {
                hash = hash * 59 + AgentCount.GetHashCode();
            }

            if (WorkPlanCount != null)
            {
                hash = hash * 59 + WorkPlanCount.GetHashCode();
            }

            if (PlanningGroupCount != null)
            {
                hash = hash * 59 + PlanningGroupCount.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
