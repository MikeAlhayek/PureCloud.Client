using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentManagementUnitReference
/// </summary>

public partial class AgentManagementUnitReference : IEquatable<AgentManagementUnitReference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentManagementUnitReference" /> class.
    /// </summary>
    /// <param name="User">The user (agent) for whom the management unit was requested.</param>
    /// <param name="ManagementUnit">The management to which the user (agent) belongs.</param>
    /// <param name="BusinessUnit">The business unit to which the user (agent) belongs. Populate with expand&#x3D;businessUnit.</param>
    public AgentManagementUnitReference(UserReference User = null, ManagementUnitReference ManagementUnit = null, BusinessUnitReference BusinessUnit = null)
    {
        this.User = User;
        this.ManagementUnit = ManagementUnit;
        this.BusinessUnit = BusinessUnit;

    }



    /// <summary>
    /// The user (agent) for whom the management unit was requested
    /// </summary>
    /// <value>The user (agent) for whom the management unit was requested</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The management to which the user (agent) belongs
    /// </summary>
    /// <value>The management to which the user (agent) belongs</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// The business unit to which the user (agent) belongs. Populate with expand&#x3D;businessUnit
    /// </summary>
    /// <value>The business unit to which the user (agent) belongs. Populate with expand&#x3D;businessUnit</value>
    [JsonPropertyName("businessUnit")]
    public BusinessUnitReference BusinessUnit { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentManagementUnitReference {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
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
        return Equals(obj as AgentManagementUnitReference);
    }

    /// <summary>
    /// Returns true if AgentManagementUnitReference instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentManagementUnitReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentManagementUnitReference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
            ) &&
            (
                BusinessUnit == other.BusinessUnit ||
                BusinessUnit != null &&
                BusinessUnit.Equals(other.BusinessUnit)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            if (BusinessUnit != null)
            {
                hash = hash * 59 + BusinessUnit.GetHashCode();
            }

            return hash;
        }
    }
}
