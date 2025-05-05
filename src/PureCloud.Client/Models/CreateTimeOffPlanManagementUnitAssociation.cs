using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateTimeOffPlanManagementUnitAssociation
/// </summary>

public partial class CreateTimeOffPlanManagementUnitAssociation : IEquatable<CreateTimeOffPlanManagementUnitAssociation>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTimeOffPlanManagementUnitAssociation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateTimeOffPlanManagementUnitAssociation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTimeOffPlanManagementUnitAssociation" /> class.
    /// </summary>
    /// <param name="ManagementUnitId">The ID of the management unit to which this time-off plan belongs (required).</param>
    /// <param name="StaffingGroupIds">A IDs of staffing groups to which this time-off plan applies. If not defined, the plan is applied to the management unit.</param>
    public CreateTimeOffPlanManagementUnitAssociation(string ManagementUnitId = null, List<string> StaffingGroupIds = null)
    {
        this.ManagementUnitId = ManagementUnitId;
        this.StaffingGroupIds = StaffingGroupIds;

    }



    /// <summary>
    /// The ID of the management unit to which this time-off plan belongs
    /// </summary>
    /// <value>The ID of the management unit to which this time-off plan belongs</value>
    [JsonPropertyName("managementUnitId")]
    public string ManagementUnitId { get; set; }



    /// <summary>
    /// A IDs of staffing groups to which this time-off plan applies. If not defined, the plan is applied to the management unit
    /// </summary>
    /// <value>A IDs of staffing groups to which this time-off plan applies. If not defined, the plan is applied to the management unit</value>
    [JsonPropertyName("staffingGroupIds")]
    public List<string> StaffingGroupIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateTimeOffPlanManagementUnitAssociation {\n");

        sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
        sb.Append("  StaffingGroupIds: ").Append(StaffingGroupIds).Append("\n");
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
        return Equals(obj as CreateTimeOffPlanManagementUnitAssociation);
    }

    /// <summary>
    /// Returns true if CreateTimeOffPlanManagementUnitAssociation instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateTimeOffPlanManagementUnitAssociation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateTimeOffPlanManagementUnitAssociation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManagementUnitId == other.ManagementUnitId ||
                ManagementUnitId != null &&
                ManagementUnitId.Equals(other.ManagementUnitId)
            ) &&
            (
                StaffingGroupIds == other.StaffingGroupIds ||
                StaffingGroupIds != null &&
                StaffingGroupIds.SequenceEqual(other.StaffingGroupIds)
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
            if (ManagementUnitId != null)
            {
                hash = hash * 59 + ManagementUnitId.GetHashCode();
            }

            if (StaffingGroupIds != null)
            {
                hash = hash * 59 + StaffingGroupIds.GetHashCode();
            }

            return hash;
        }
    }
}
