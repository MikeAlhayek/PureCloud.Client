using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchBuReschedulingOptionsManagementUnitRequest
/// </summary>

public partial class PatchBuReschedulingOptionsManagementUnitRequest : IEquatable<PatchBuReschedulingOptionsManagementUnitRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PatchBuReschedulingOptionsManagementUnitRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PatchBuReschedulingOptionsManagementUnitRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchBuReschedulingOptionsManagementUnitRequest" /> class.
    /// </summary>
    /// <param name="ManagementUnitId">The management unit portion of the rescheduling run to update (required).</param>
    /// <param name="Applied">Whether to mark the run as applied.  Only applies to reschedule runs.  Once applied, a run cannot be un-marked as applied.</param>
    public PatchBuReschedulingOptionsManagementUnitRequest(string ManagementUnitId = null, bool? Applied = null)
    {
        this.ManagementUnitId = ManagementUnitId;
        this.Applied = Applied;

    }



    /// <summary>
    /// The management unit portion of the rescheduling run to update
    /// </summary>
    /// <value>The management unit portion of the rescheduling run to update</value>
    [JsonPropertyName("managementUnitId")]
    public string ManagementUnitId { get; set; }



    /// <summary>
    /// Whether to mark the run as applied.  Only applies to reschedule runs.  Once applied, a run cannot be un-marked as applied
    /// </summary>
    /// <value>Whether to mark the run as applied.  Only applies to reschedule runs.  Once applied, a run cannot be un-marked as applied</value>
    [JsonPropertyName("applied")]
    public bool? Applied { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchBuReschedulingOptionsManagementUnitRequest {\n");

        sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
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
        return Equals(obj as PatchBuReschedulingOptionsManagementUnitRequest);
    }

    /// <summary>
    /// Returns true if PatchBuReschedulingOptionsManagementUnitRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchBuReschedulingOptionsManagementUnitRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchBuReschedulingOptionsManagementUnitRequest other)
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
            if (ManagementUnitId != null)
            {
                hash = hash * 59 + ManagementUnitId.GetHashCode();
            }

            if (Applied != null)
            {
                hash = hash * 59 + Applied.GetHashCode();
            }

            return hash;
        }
    }
}
