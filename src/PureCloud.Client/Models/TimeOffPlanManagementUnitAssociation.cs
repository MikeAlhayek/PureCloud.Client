using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffPlanManagementUnitAssociation
/// </summary>

public partial class TimeOffPlanManagementUnitAssociation : IEquatable<TimeOffPlanManagementUnitAssociation>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffPlanManagementUnitAssociation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TimeOffPlanManagementUnitAssociation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffPlanManagementUnitAssociation" /> class.
    /// </summary>
    /// <param name="ManagementUnit">Management unit to which this time-off plan belongs (required).</param>
    /// <param name="StaffingGroups">Staffing groups to which this time-off plan applies. If not defined, the plan applies to the management unit.</param>
    public TimeOffPlanManagementUnitAssociation(ManagementUnitReference ManagementUnit = null, List<StaffingGroupReference> StaffingGroups = null)
    {
        this.ManagementUnit = ManagementUnit;
        this.StaffingGroups = StaffingGroups;

    }



    /// <summary>
    /// Management unit to which this time-off plan belongs
    /// </summary>
    /// <value>Management unit to which this time-off plan belongs</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// Staffing groups to which this time-off plan applies. If not defined, the plan applies to the management unit
    /// </summary>
    /// <value>Staffing groups to which this time-off plan applies. If not defined, the plan applies to the management unit</value>
    [JsonPropertyName("staffingGroups")]
    public List<StaffingGroupReference> StaffingGroups { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffPlanManagementUnitAssociation {\n");

        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  StaffingGroups: ").Append(StaffingGroups).Append("\n");
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
        return Equals(obj as TimeOffPlanManagementUnitAssociation);
    }

    /// <summary>
    /// Returns true if TimeOffPlanManagementUnitAssociation instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffPlanManagementUnitAssociation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffPlanManagementUnitAssociation other)
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
                StaffingGroups == other.StaffingGroups ||
                StaffingGroups != null &&
                StaffingGroups.SequenceEqual(other.StaffingGroups)
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

            if (StaffingGroups != null)
            {
                hash = hash * 59 + StaffingGroups.GetHashCode();
            }

            return hash;
        }
    }
}
