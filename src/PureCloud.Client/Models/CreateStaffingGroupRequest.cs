using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateStaffingGroupRequest
/// </summary>

public partial class CreateStaffingGroupRequest : IEquatable<CreateStaffingGroupRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateStaffingGroupRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateStaffingGroupRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateStaffingGroupRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the staffing group (required).</param>
    /// <param name="UserIds">The set of user IDs to associate with the staffing group.</param>
    /// <param name="ManagementUnitId">The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit.</param>
    public CreateStaffingGroupRequest(string Name = null, List<string> UserIds = null, string ManagementUnitId = null)
    {
        this.Name = Name;
        this.UserIds = UserIds;
        this.ManagementUnitId = ManagementUnitId;

    }



    /// <summary>
    /// The name of the staffing group
    /// </summary>
    /// <value>The name of the staffing group</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The set of user IDs to associate with the staffing group
    /// </summary>
    /// <value>The set of user IDs to associate with the staffing group</value>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; }



    /// <summary>
    /// The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit
    /// </summary>
    /// <value>The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit</value>
    [JsonPropertyName("managementUnitId")]
    public string ManagementUnitId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateStaffingGroupRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
        return Equals(obj as CreateStaffingGroupRequest);
    }

    /// <summary>
    /// Returns true if CreateStaffingGroupRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateStaffingGroupRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateStaffingGroupRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                UserIds == other.UserIds ||
                UserIds != null &&
                UserIds.SequenceEqual(other.UserIds)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            if (ManagementUnitId != null)
            {
                hash = hash * 59 + ManagementUnitId.GetHashCode();
            }

            return hash;
        }
    }
}
