using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchBuReschedulingOptionsRequest
/// </summary>
[DataContract]
public partial class PatchBuReschedulingOptionsRequest : IEquatable<PatchBuReschedulingOptionsRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchBuReschedulingOptionsRequest" /> class.
    /// </summary>
    /// <param name="ManagementUnits">Per-management unit rescheduling options to update.</param>
    public PatchBuReschedulingOptionsRequest(List<PatchBuReschedulingOptionsManagementUnitRequest> ManagementUnits = null)
    {
        this.ManagementUnits = ManagementUnits;

    }



    /// <summary>
    /// Per-management unit rescheduling options to update
    /// </summary>
    /// <value>Per-management unit rescheduling options to update</value>
    [DataMember(Name = "managementUnits", EmitDefaultValue = false)]
    public List<PatchBuReschedulingOptionsManagementUnitRequest> ManagementUnits { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchBuReschedulingOptionsRequest {\n");

        sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
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
        return Equals(obj as PatchBuReschedulingOptionsRequest);
    }

    /// <summary>
    /// Returns true if PatchBuReschedulingOptionsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchBuReschedulingOptionsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchBuReschedulingOptionsRequest other)
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

            return hash;
        }
    }
}
