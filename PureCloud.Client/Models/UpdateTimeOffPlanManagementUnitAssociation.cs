using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateTimeOffPlanManagementUnitAssociation
/// </summary>
[DataContract]
public partial class UpdateTimeOffPlanManagementUnitAssociation : IEquatable<UpdateTimeOffPlanManagementUnitAssociation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateTimeOffPlanManagementUnitAssociation" /> class.
    /// </summary>
    /// <param name="StaffingGroupIds">The IDs of staffing groups to which this time-off plan applies. If not defined, the plan is applied to the management unit.</param>
    public UpdateTimeOffPlanManagementUnitAssociation(SetWrapperString StaffingGroupIds = null)
    {
        this.StaffingGroupIds = StaffingGroupIds;

    }



    /// <summary>
    /// The IDs of staffing groups to which this time-off plan applies. If not defined, the plan is applied to the management unit
    /// </summary>
    /// <value>The IDs of staffing groups to which this time-off plan applies. If not defined, the plan is applied to the management unit</value>
    [DataMember(Name = "staffingGroupIds", EmitDefaultValue = false)]
    public SetWrapperString StaffingGroupIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateTimeOffPlanManagementUnitAssociation {\n");

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
        return Equals(obj as UpdateTimeOffPlanManagementUnitAssociation);
    }

    /// <summary>
    /// Returns true if UpdateTimeOffPlanManagementUnitAssociation instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateTimeOffPlanManagementUnitAssociation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateTimeOffPlanManagementUnitAssociation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (StaffingGroupIds != null)
            {
                hash = hash * 59 + StaffingGroupIds.GetHashCode();
            }

            return hash;
        }
    }
}
