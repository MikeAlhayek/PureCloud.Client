using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuCreateTimeOffLimitRequest
/// </summary>

public partial class BuCreateTimeOffLimitRequest : IEquatable<BuCreateTimeOffLimitRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuCreateTimeOffLimitRequest" /> class.
    /// </summary>
    /// <param name="StaffingGroupId">The ID of the staffing group to which this time-off limit is associated. It can be either management unit or business unit level staffing group. One of managementUnitId or staffingGroupId must be set. This must not be set if managementUnitId has value.</param>
    /// <param name="ManagementUnitId">The ID of the management unit to which this time-off limit is associated. One of managementUnitId or staffingGroupId must be set. This must not be set if staffingGroupId has value.</param>
    public BuCreateTimeOffLimitRequest(string StaffingGroupId = null, string ManagementUnitId = null)
    {
        this.StaffingGroupId = StaffingGroupId;
        this.ManagementUnitId = ManagementUnitId;

    }



    /// <summary>
    /// The ID of the staffing group to which this time-off limit is associated. It can be either management unit or business unit level staffing group. One of managementUnitId or staffingGroupId must be set. This must not be set if managementUnitId has value
    /// </summary>
    /// <value>The ID of the staffing group to which this time-off limit is associated. It can be either management unit or business unit level staffing group. One of managementUnitId or staffingGroupId must be set. This must not be set if managementUnitId has value</value>
    [JsonPropertyName("staffingGroupId")]
    public string StaffingGroupId { get; set; }



    /// <summary>
    /// The ID of the management unit to which this time-off limit is associated. One of managementUnitId or staffingGroupId must be set. This must not be set if staffingGroupId has value
    /// </summary>
    /// <value>The ID of the management unit to which this time-off limit is associated. One of managementUnitId or staffingGroupId must be set. This must not be set if staffingGroupId has value</value>
    [JsonPropertyName("managementUnitId")]
    public string ManagementUnitId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuCreateTimeOffLimitRequest {\n");

        sb.Append("  StaffingGroupId: ").Append(StaffingGroupId).Append("\n");
        sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
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
        return Equals(obj as BuCreateTimeOffLimitRequest);
    }

    /// <summary>
    /// Returns true if BuCreateTimeOffLimitRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuCreateTimeOffLimitRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuCreateTimeOffLimitRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StaffingGroupId == other.StaffingGroupId ||
                StaffingGroupId != null &&
                StaffingGroupId.Equals(other.StaffingGroupId)
            ) &&
            (
                ManagementUnitId == other.ManagementUnitId ||
                ManagementUnitId != null &&
                ManagementUnitId.Equals(other.ManagementUnitId)
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
            if (StaffingGroupId != null)
            {
                hash = hash * 59 + StaffingGroupId.GetHashCode();
            }

            if (ManagementUnitId != null)
            {
                hash = hash * 59 + ManagementUnitId.GetHashCode();
            }

            return hash;
        }
    }
}
