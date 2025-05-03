using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// StaffingRequirementsPlanningGroupData
/// </summary>

public partial class StaffingRequirementsPlanningGroupData : IEquatable<StaffingRequirementsPlanningGroupData>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="StaffingRequirementsPlanningGroupData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected StaffingRequirementsPlanningGroupData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="StaffingRequirementsPlanningGroupData" /> class.
    /// </summary>
    /// <param name="PlanningGroupId">The ID of the planning group to which this data applies (required).</param>
    /// <param name="StaffingRequirementsPerInterval">Staffing requirements per interval for this week forecast (required).</param>
    public StaffingRequirementsPlanningGroupData(string PlanningGroupId = null, List<double?> StaffingRequirementsPerInterval = null)
    {
        this.PlanningGroupId = PlanningGroupId;
        this.StaffingRequirementsPerInterval = StaffingRequirementsPerInterval;

    }



    /// <summary>
    /// The ID of the planning group to which this data applies
    /// </summary>
    /// <value>The ID of the planning group to which this data applies</value>
    [JsonPropertyName("planningGroupId")]
    public string PlanningGroupId { get; set; }



    /// <summary>
    /// Staffing requirements per interval for this week forecast
    /// </summary>
    /// <value>Staffing requirements per interval for this week forecast</value>
    [JsonPropertyName("staffingRequirementsPerInterval")]
    public List<double?> StaffingRequirementsPerInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StaffingRequirementsPlanningGroupData {\n");

        sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
        sb.Append("  StaffingRequirementsPerInterval: ").Append(StaffingRequirementsPerInterval).Append("\n");
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
        return Equals(obj as StaffingRequirementsPlanningGroupData);
    }

    /// <summary>
    /// Returns true if StaffingRequirementsPlanningGroupData instances are equal
    /// </summary>
    /// <param name="other">Instance of StaffingRequirementsPlanningGroupData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(StaffingRequirementsPlanningGroupData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PlanningGroupId == other.PlanningGroupId ||
                PlanningGroupId != null &&
                PlanningGroupId.Equals(other.PlanningGroupId)
            ) &&
            (
                StaffingRequirementsPerInterval == other.StaffingRequirementsPerInterval ||
                StaffingRequirementsPerInterval != null &&
                StaffingRequirementsPerInterval.SequenceEqual(other.StaffingRequirementsPerInterval)
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
            if (PlanningGroupId != null)
            {
                hash = hash * 59 + PlanningGroupId.GetHashCode();
            }

            if (StaffingRequirementsPerInterval != null)
            {
                hash = hash * 59 + StaffingRequirementsPerInterval.GetHashCode();
            }

            return hash;
        }
    }
}
