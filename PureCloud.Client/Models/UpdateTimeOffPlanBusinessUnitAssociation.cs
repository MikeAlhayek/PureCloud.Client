using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateTimeOffPlanBusinessUnitAssociation
/// </summary>
[DataContract]
public partial class UpdateTimeOffPlanBusinessUnitAssociation : IEquatable<UpdateTimeOffPlanBusinessUnitAssociation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateTimeOffPlanBusinessUnitAssociation" /> class.
    /// </summary>
    /// <param name="ManagementUnitIds">The IDs of management units to which this time-off plan applies. This must not be set if staffingGroupIds is populated.</param>
    /// <param name="StaffingGroupIds">The IDs of staffing groups to which this time-off plan applies. This must not be set if managementUnitIds is populated.</param>
    public UpdateTimeOffPlanBusinessUnitAssociation(SetWrapperString ManagementUnitIds = null, SetWrapperString StaffingGroupIds = null)
    {
        this.ManagementUnitIds = ManagementUnitIds;
        this.StaffingGroupIds = StaffingGroupIds;

    }



    /// <summary>
    /// The IDs of management units to which this time-off plan applies. This must not be set if staffingGroupIds is populated
    /// </summary>
    /// <value>The IDs of management units to which this time-off plan applies. This must not be set if staffingGroupIds is populated</value>
    [DataMember(Name = "managementUnitIds", EmitDefaultValue = false)]
    public SetWrapperString ManagementUnitIds { get; set; }



    /// <summary>
    /// The IDs of staffing groups to which this time-off plan applies. This must not be set if managementUnitIds is populated
    /// </summary>
    /// <value>The IDs of staffing groups to which this time-off plan applies. This must not be set if managementUnitIds is populated</value>
    [DataMember(Name = "staffingGroupIds", EmitDefaultValue = false)]
    public SetWrapperString StaffingGroupIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateTimeOffPlanBusinessUnitAssociation {\n");

        sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
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
        return Equals(obj as UpdateTimeOffPlanBusinessUnitAssociation);
    }

    /// <summary>
    /// Returns true if UpdateTimeOffPlanBusinessUnitAssociation instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateTimeOffPlanBusinessUnitAssociation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateTimeOffPlanBusinessUnitAssociation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManagementUnitIds == other.ManagementUnitIds ||
                ManagementUnitIds != null &&
                ManagementUnitIds.Equals(other.ManagementUnitIds)
            ) &&
            (
                StaffingGroupIds == other.StaffingGroupIds ||
                StaffingGroupIds != null &&
                StaffingGroupIds.Equals(other.StaffingGroupIds)
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
            if (ManagementUnitIds != null)
            {
                hash = hash * 59 + ManagementUnitIds.GetHashCode();
            }

            if (StaffingGroupIds != null)
            {
                hash = hash * 59 + StaffingGroupIds.GetHashCode();
            }

            return hash;
        }
    }
}
