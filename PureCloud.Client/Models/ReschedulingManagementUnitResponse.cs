using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReschedulingManagementUnitResponse
/// </summary>
[DataContract]
public partial class ReschedulingManagementUnitResponse : IEquatable<ReschedulingManagementUnitResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReschedulingManagementUnitResponse" /> class.
    /// </summary>
    /// <param name="ManagementUnit">The management unit.</param>
    /// <param name="Applied">Whether the rescheduling run is applied for the given management unit.</param>
    public ReschedulingManagementUnitResponse(ManagementUnitReference ManagementUnit = null, bool? Applied = null)
    {
        this.ManagementUnit = ManagementUnit;
        this.Applied = Applied;

    }



    /// <summary>
    /// The management unit
    /// </summary>
    /// <value>The management unit</value>
    [DataMember(Name = "managementUnit", EmitDefaultValue = false)]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// Whether the rescheduling run is applied for the given management unit
    /// </summary>
    /// <value>Whether the rescheduling run is applied for the given management unit</value>
    [DataMember(Name = "applied", EmitDefaultValue = false)]
    public bool? Applied { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReschedulingManagementUnitResponse {\n");

        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  Applied: ").Append(Applied).Append("\n");
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
        return Equals(obj as ReschedulingManagementUnitResponse);
    }

    /// <summary>
    /// Returns true if ReschedulingManagementUnitResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ReschedulingManagementUnitResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReschedulingManagementUnitResponse other)
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
                Applied == other.Applied ||
                Applied != null &&
                Applied.Equals(other.Applied)
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

            if (Applied != null)
            {
                hash = hash * 59 + Applied.GetHashCode();
            }

            return hash;
        }
    }
}
