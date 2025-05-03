using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentWorkPlanListResponse
/// </summary>

public partial class AgentWorkPlanListResponse : IEquatable<AgentWorkPlanListResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanListResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentWorkPlanListResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanListResponse" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="ManagementUnit">The management unit of the work plans (required).</param>
    public AgentWorkPlanListResponse(List<AgentWorkPlan> Entities = null, ManagementUnitReference ManagementUnit = null)
    {
        this.Entities = Entities;
        this.ManagementUnit = ManagementUnit;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<AgentWorkPlan> Entities { get; set; }



    /// <summary>
    /// The management unit of the work plans
    /// </summary>
    /// <value>The management unit of the work plans</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentWorkPlanListResponse {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
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
        return Equals(obj as AgentWorkPlanListResponse);
    }

    /// <summary>
    /// Returns true if AgentWorkPlanListResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentWorkPlanListResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentWorkPlanListResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            return hash;
        }
    }
}
