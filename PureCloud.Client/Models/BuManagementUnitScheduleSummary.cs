using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// BuManagementUnitScheduleSummary
/// </summary>
[DataContract]
public partial class BuManagementUnitScheduleSummary : IEquatable<BuManagementUnitScheduleSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuManagementUnitScheduleSummary" /> class.
    /// </summary>
    /// <param name="ManagementUnit">The management unit to which this summary applies.</param>
    /// <param name="AgentCount">The number of agents from this management unit that are in the schedule.</param>
    /// <param name="StartDate">The start of the schedule change in the management unit. Only populated in schedule update notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndDate">The end of the schedule change in the management unit. Only populated in schedule update notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Agents">The agents in the management unit who are part of this schedule, or in schedule change notifications, the agents that were changed. Note this will come back as an empty list unless the appropriate expand query parameter is passed.</param>
    public BuManagementUnitScheduleSummary(ManagementUnitReference ManagementUnit = null, int? AgentCount = null, DateTime? StartDate = null, DateTime? EndDate = null, List<UserReference> Agents = null)
    {
        this.ManagementUnit = ManagementUnit;
        this.AgentCount = AgentCount;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.Agents = Agents;

    }



    /// <summary>
    /// The management unit to which this summary applies
    /// </summary>
    /// <value>The management unit to which this summary applies</value>
    [DataMember(Name = "managementUnit", EmitDefaultValue = false)]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// The number of agents from this management unit that are in the schedule
    /// </summary>
    /// <value>The number of agents from this management unit that are in the schedule</value>
    [DataMember(Name = "agentCount", EmitDefaultValue = false)]
    public int? AgentCount { get; set; }



    /// <summary>
    /// The start of the schedule change in the management unit. Only populated in schedule update notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start of the schedule change in the management unit. Only populated in schedule update notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The end of the schedule change in the management unit. Only populated in schedule update notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end of the schedule change in the management unit. Only populated in schedule update notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// The agents in the management unit who are part of this schedule, or in schedule change notifications, the agents that were changed. Note this will come back as an empty list unless the appropriate expand query parameter is passed
    /// </summary>
    /// <value>The agents in the management unit who are part of this schedule, or in schedule change notifications, the agents that were changed. Note this will come back as an empty list unless the appropriate expand query parameter is passed</value>
    [DataMember(Name = "agents", EmitDefaultValue = false)]
    public List<UserReference> Agents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuManagementUnitScheduleSummary {\n");

        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  Agents: ").Append(Agents).Append("\n");
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
        return Equals(obj as BuManagementUnitScheduleSummary);
    }

    /// <summary>
    /// Returns true if BuManagementUnitScheduleSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of BuManagementUnitScheduleSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuManagementUnitScheduleSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                Agents == other.Agents ||
                Agents != null &&
                Agents.SequenceEqual(other.Agents)
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
            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            if (AgentCount != null)
            {
                hash = hash * 59 + AgentCount.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (Agents != null)
            {
                hash = hash * 59 + Agents.GetHashCode();
            }

            return hash;
        }
    }
}
