using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffPlanBusinessUnitAssociation
/// </summary>

public partial class TimeOffPlanBusinessUnitAssociation : IEquatable<TimeOffPlanBusinessUnitAssociation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffPlanBusinessUnitAssociation" /> class.
    /// </summary>
    /// <param name="ManagementUnits">Management units to which this time-off plan applies. This must not be set if staffingGroups is populated.</param>
    /// <param name="StaffingGroups">Staffing groups to which this time-off plan applies. This must not be set if managementUnits is populated.</param>
    public TimeOffPlanBusinessUnitAssociation(List<ManagementUnitReference> ManagementUnits = null, List<StaffingGroupReference> StaffingGroups = null)
    {
        this.ManagementUnits = ManagementUnits;
        this.StaffingGroups = StaffingGroups;

    }



    /// <summary>
    /// Management units to which this time-off plan applies. This must not be set if staffingGroups is populated
    /// </summary>
    /// <value>Management units to which this time-off plan applies. This must not be set if staffingGroups is populated</value>
    [JsonPropertyName("managementUnits")]
    public List<ManagementUnitReference> ManagementUnits { get; set; }



    /// <summary>
    /// Staffing groups to which this time-off plan applies. This must not be set if managementUnits is populated
    /// </summary>
    /// <value>Staffing groups to which this time-off plan applies. This must not be set if managementUnits is populated</value>
    [JsonPropertyName("staffingGroups")]
    public List<StaffingGroupReference> StaffingGroups { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffPlanBusinessUnitAssociation {\n");

        sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
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
        return Equals(obj as TimeOffPlanBusinessUnitAssociation);
    }

    /// <summary>
    /// Returns true if TimeOffPlanBusinessUnitAssociation instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffPlanBusinessUnitAssociation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffPlanBusinessUnitAssociation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManagementUnits == other.ManagementUnits ||
                ManagementUnits != null &&
                ManagementUnits.SequenceEqual(other.ManagementUnits)
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
            if (ManagementUnits != null)
            {
                hash = hash * 59 + ManagementUnits.GetHashCode();
            }

            if (StaffingGroups != null)
            {
                hash = hash * 59 + StaffingGroups.GetHashCode();
            }

            return hash;
        }
    }
}
